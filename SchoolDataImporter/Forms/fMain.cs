﻿using Meziantou.Framework.Win32;
using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Constants;
using SchoolDataImporter.Forms.Interfaces;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDataImporter.Forms
{
    public partial class fMain : Form, IMain
    {
        private readonly IQueryStatementEngine _queryEngine;
        private readonly IAccessReader _accessReader;
        private readonly IStringEncryption _stringEncryption;
        private readonly IConfigurationManager _configManager;
        private readonly IAdoDbConnectionManager _dbManager;
        private readonly ILogger _logger;

        private IExportData _exportForm;

        private bool isProcessing = false;
        private bool _formActivated = false;
        private bool _dbAuthSuccess = false;
        private string _dbFileName = string.Empty;

        private CancellationTokenSource ctSource = new CancellationTokenSource();

        private ICollection<Learner> _learnerData;
        private ICollection<Educator> _educatorData;
        private ICollection<OtherStaff> _staffData;
        private ICollection<GoverningBody> _governingBodyMembers;

        public fMain(IExportData exportForm, IQueryStatementEngine queryEngine, IAccessReader accessReader, IStringEncryption stringEncryption, IConfigurationManager configManager, IAdoDbConnectionManager dbManager, ILogger logger)
        {
            _exportForm = exportForm ?? throw new ArgumentNullException(nameof(exportForm));

            _queryEngine = queryEngine ?? throw new ArgumentNullException(nameof(queryEngine));
            _accessReader = accessReader ?? throw new ArgumentNullException(nameof(accessReader));
            _stringEncryption = stringEncryption ?? throw new ArgumentNullException(nameof(stringEncryption));
            _configManager = configManager ?? throw new ArgumentNullException(nameof(configManager));
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            _logger.Debug("Call to fMain_Load");
            LoadRecentConnections();
        }

        private async void fMain_Activated(object sender, EventArgs e)
        {
            if (!_formActivated)
            {
                _formActivated = true;
                pbProcessing.Visible = true;

                if (_configManager.FetchRemoteQueries)
                {
                    lblCurrentOperation.Text = "Fetching Configuration from Remote Server...";

                    await Task.Run(() => FetchQueriesAsync());
                }
                else
                {
                    _configManager.Queries = _queryEngine.FetchQueryStatementsLocally();
                }
                lblCurrentOperation.Text = "";
                pbProcessing.Visible = false;
                cmdStart.Enabled = true;
            }
        }

        private async Task FetchQueriesAsync()
        {
            _configManager.Queries = await _queryEngine.FetchQueryStatementsAsync(CancellationToken.None);
        }

        private void LoadRecentConnections()
        {
            _logger.Debug("Call to LoadRecentConnections");

            // Load the DB connections that exist in the settings file
            cmbPreviousConnections.Items.Clear();
            foreach (var dbConnection in _configManager.Settings.Databases)
            {
                cmbPreviousConnections.Items.Add(dbConnection.FileName);
            }

            if (cmbPreviousConnections.Items.Count == 1)
            {
                cmbPreviousConnections.SelectedIndex = 0;
                ConnectionSelected();
            }
        }

        private void cmdBrowseFile_Click(object sender, EventArgs e)
        {
            _logger.Debug("Call to cmdBrowseFile_Click");

            dlgOpenFile.Filter = "Microsoft Access Database File (*.mdb)|*.mdb";
            dlgOpenFile.Multiselect = false;
            
            // Display the dialog
            var dlgResult = dlgOpenFile.ShowDialog();
            if (dlgResult != DialogResult.Cancel)
            {
                _logger.Debug("User selected file {fileName}", dlgOpenFile.FileName);

                DbFileSelected(dlgOpenFile.FileName);
            }
            else
            {
                _logger.Debug("User cancelled opening a db file");
            }
        }

        private void DbFileSelected(string fileName)
        {
            // If the file the user selected exists in the list of previous connections, select it on the combo box
            var existingDb = _configManager.Settings.Databases.FirstOrDefault(db => db.FileName.Equals(fileName, StringComparison.InvariantCultureIgnoreCase));
            if (existingDb != null)
            {
                var idx = cmbPreviousConnections.Items.IndexOf(existingDb.FileName);
                if (idx > -1)
                {
                    cmbPreviousConnections.SelectedIndex = idx;
                    ConnectionSelected();
                    return;
                }
            }

            var pwd = PromptUserForPassword(fileName);
            if (string.IsNullOrWhiteSpace(pwd))
            {
                return;
            }

            TestDbConnection(fileName, pwd);
        }

        private void TestDbConnection(string fileName, string pwd, bool removeOldConnection = false)
        {
            if (TestConnection(fileName, pwd))
            {
                _dbAuthSuccess = true;
                _dbFileName = fileName;

                _logger.Debug("Database with file name {fileName} successfully tested with provided credentials. Storing to recently used list.", fileName);
                if (removeOldConnection)
                {
                    var currentDb = _configManager.Settings.Databases.FirstOrDefault(f => f.FileName.Equals(fileName, StringComparison.InvariantCultureIgnoreCase));
                    if (currentDb != null)
                    {
                        _configManager.Settings.Databases.Remove(currentDb);
                    }
                }

                var connectionString = "Provider={dataProvider};Data Source={dbFileName};Jet OLEDB:Database Password={dbPassword}";

                _configManager.Settings.Databases.Add(new AppSettingsDatabase
                {
                    ConnectionString = connectionString,
                    FileName = fileName,
                    Password = _stringEncryption.EncryptString(pwd)
                });
                _configManager.StoreConfiguration();

                LoadRecentConnections();
                var idx = cmbPreviousConnections.Items.IndexOf(fileName);
                if (idx > -1)
                {
                    cmbPreviousConnections.SelectedIndex = idx;
                    ConnectionSelected();
                }
            }
            else
            {
                _logger.Warning("User provided incorrect password for database file {fileName}", dlgOpenFile.FileName);
                MessageBox.Show("The username and password provided is invalid. Please try again.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _dbAuthSuccess = false;
                _dbFileName = string.Empty;
            }
        }

        private void cmbPreviousConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionSelected();
        }

        private async void cmdStart_Click(object sender, EventArgs e)
        {
            if (_dbFileName == string.Empty)
            {
                MessageBox.Show("Please select a database file", "No DB selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_dbAuthSuccess)
            {
                var pwd = PromptUserForPassword(_dbFileName);
                if (string.IsNullOrEmpty(pwd))
                {
                    return;
                }
                TestDbConnection(_dbFileName, pwd, true);
                if (!_dbAuthSuccess)
                {
                    return;
                }
            }

            if (isProcessing)
            {
                lblCurrentOperation.Text = "Cancelling the operation...";

                ctSource.Cancel();
                ResetUi();
            }
            else
            {
                _logger.Verbose("User invoked start of process with db file {fileName}", cmbPreviousConnections.SelectedItem.ToString());
                lblCurrentOperation.Text = "Reading Data...";

                _learnerData = new List<Learner>();
                _staffData = new List<OtherStaff>();
                isProcessing = true;

                // Disable current controls to prevent user interaction...
                cmbPreviousConnections.Enabled = false;
                cmdBrowseFile.Enabled = false;
                cmdStart.Text = "Cancel";

                pbProcessing.Visible = true;

                var dbObject = _configManager.Settings.Databases.FirstOrDefault(db => db.FileName.Equals(txtDbFile.Text, StringComparison.InvariantCultureIgnoreCase));
                if (dbObject != null)
                {
                    lblCurrentOperation.Text = "Reading Learner Data...";
                    await Task.Run(() => ReadLearnersAsync(dbObject, ctSource.Token));

                    if (!ctSource.IsCancellationRequested)
                    {
                        lblCurrentOperation.Text = "Reading Educator Data...";
                        await Task.Run(() => ReadEducatorsAsync(dbObject, ctSource.Token));
                    }

                    if (!ctSource.IsCancellationRequested)
                    {
                        lblCurrentOperation.Text = "Reading Other Staff Data...";
                        await Task.Run(() => ReadOtherStaffAsync(dbObject, ctSource.Token));
                    }

                    if (!ctSource.IsCancellationRequested)
                    {
                        lblCurrentOperation.Text = "Reading Governing Body Data...";
                        await Task.Run(() => ReadGoverningBodyAsync(dbObject, ctSource.Token));
                    }

                    ShowExportDataForm();
                }
            }
        }

        private void ShowExportDataForm()
        {
            // If we get up to here, it means that the user didn't cancel anything
            _exportForm.SetData(_learnerData, _staffData, _governingBodyMembers, _educatorData);
            _exportForm.ShowForm();

            Program.AppContext.MainForm = (Form)_exportForm;
            Close();
        }

        private void ResetUi()
        {
            pbProcessing.Visible = false;
            cmbPreviousConnections.Enabled = true;
            cmdBrowseFile.Enabled = true;
            cmdStart.Text = "Start";
        }

        private async Task ReadLearnersAsync(AppSettingsDatabase dbObject, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadLearnersAsync");
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                _learnerData = await _accessReader.ReadLearnersAsync(dbObject, cancellationToken);

                isProcessing = false;
                cancellationToken.ThrowIfCancellationRequested();   // This will cause the "catch" below to be triggered if the user selected "Cancel"
            }
            catch (OperationCanceledException)
            {
                _logger.Warning("User cancelled reading learners");
            }
        }

        private async Task ReadEducatorsAsync(AppSettingsDatabase dbObject, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadEducatorsAsync");
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                _educatorData = await _accessReader.ReadEducatorsAsync(dbObject, cancellationToken);

                isProcessing = false;
                cancellationToken.ThrowIfCancellationRequested();   // This will cause the "catch" below to be triggered if the user selected "Cancel"
            }
            catch (OperationCanceledException)
            {
                _logger.Warning("User cancelled reading educators");
            }
        }

        private async Task ReadOtherStaffAsync(AppSettingsDatabase dbObject, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadOtherStaffAsync");
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                _staffData = await _accessReader.ReadStaffDataAsync(dbObject, cancellationToken);

                isProcessing = false;
                cancellationToken.ThrowIfCancellationRequested();   // This will cause the "catch" below to be triggered if the user selected "Cancel"
            }
            catch (OperationCanceledException)
            {
                _logger.Warning("User cancelled reading other staff");
            }
        }

        private async Task ReadGoverningBodyAsync(AppSettingsDatabase dbObject, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadGoverningBodyAsync");
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                _governingBodyMembers = await _accessReader.ReadGoverningBodyAsync(dbObject, cancellationToken);

                isProcessing = false;
                cancellationToken.ThrowIfCancellationRequested();   // This will cause the "catch" below to be triggered if the user selected "Cancel"
            }
            catch (OperationCanceledException)
            {
                _logger.Warning("User cancelled reading governing body");
            }
        }

        private void ConnectionSelected()
        {
            _logger.Debug("Call to ConnectionSelected");

            var fi = new FileInfo(cmbPreviousConnections.SelectedItem.ToString());
            if (fi.Exists)
            {
                _dbAuthSuccess = true;
                _dbFileName = fi.FullName;
                var db = _configManager.Settings.Databases.FirstOrDefault(f => f.FileName.Equals(fi.FullName, StringComparison.InvariantCultureIgnoreCase));
                if (db != null)
                {
                    if (TestConnection(fi.FullName, _stringEncryption.DecryptString(db.Password)))
                    {
                        ShowDbInfo(fi.FullName);
                    }
                    else
                    {
                        MessageBox.Show("The stored credentials for the recently used database are no longer valid. Please provide the updated credentials in order to continue.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        var pwd = PromptUserForPassword(fi.FullName);
                        if (!string.IsNullOrEmpty(pwd))
                        {
                            TestDbConnection(fi.FullName, pwd, true);
                        }
                    }
                }
            }
            else
            {
                _logger.Warning("Previously selected file with file name {fileName} is not a valid file anymore.", fi.FullName);
                if (MessageBox.Show("The recently used file you have selected does not exist at this location anymore.\nDo you wish to remove it from the recent list?", "File does not Exist anymore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // remove from recent list
                    var db = _configManager.Settings.Databases.FirstOrDefault(f => f.FileName.Equals(fi.FullName, StringComparison.InvariantCultureIgnoreCase));
                    if (db != null)
                    {
                        _configManager.Settings.Databases.Remove(db);
                        _configManager.StoreConfiguration();
                        // At this stage the user will have to "start over"
                    }
                }
            }
        }

        private void ShowDbInfo(string fileName)
        {
            // When we get to this stage, we know the file must exist and the DB credentials are acurate
            var fi = new FileInfo(fileName);
            lblLastUseDate.Text = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
            txtDbFile.Text = fi.FullName;
            pnlDbSelected.Visible = true;
        }

        private bool TestConnection(string fileName, string providedPassword)
        {
            _logger.Debug("Testing connection to file {fileName}", fileName);

            var connString = $"Provider={_configManager.DataProvider};Data Source={fileName};Jet OLEDB:Database Password={providedPassword}";
            var connectionResult = _dbManager.OpenConnectionAsync(connString, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            if (connectionResult)
            {
                _dbManager.CloseConnection();
                return true;
            }

            _logger.Warning("Could not connect to provided file with filename {fileName}", fileName);
            return false;
        }

        private string PromptUserForPassword(string fileName)
        {
            _logger.Debug("Prompting user for password to file with fileName {fileName}", fileName);

            var fileNameOnly = Path.GetFileName(fileName);

            var creds = CredentialManager.PromptForCredentials(
                messageText: $"Please provide the administrator password for accessing the database {fileNameOnly}",
                captionText: "Provide Password for Database",
                userName: "Admin",
                saveCredential: CredentialSaveOption.Selected);

            if (creds == null)
            {
                _logger.Debug("User dismissed password request without providing a password");
                return string.Empty;
            }

            return creds.Password;
        }

        private void txtDbFile_Leave(object sender, EventArgs e)
        {
            var value = txtDbFile.Text.Trim();
            if (value.Length > 0)
            {
                // check if this is even a file...
                var fi = new FileInfo(value);
                if (!fi.Exists)
                {
                    // show error
                    MessageBox.Show("The provided file name is invalid.", "Invalid File Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDbFile.Text = string.Empty;
                    return;
                }

                DbFileSelected(value);
            }
        }
    }
}
