using Meziantou.Framework.Win32;
using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Constants;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDataImporter.Forms
{
    public partial class fMain : Form
    {
        private readonly IQueryStatementEngine _queryEngine;
        private readonly IAccessReader _accessReader;
        private readonly IStringEncryption _stringEncryption;
        private readonly IConfigurationManager _configManager;
        private readonly IAdoDbConnectionManager _dbManager;
        private readonly ILogger _logger;

        private bool isProcessing = false;
        private CancellationTokenSource ctSource = new CancellationTokenSource();

        public fMain(IQueryStatementEngine queryEngine, IAccessReader accessReader, IStringEncryption stringEncryption, IConfigurationManager configManager, IAdoDbConnectionManager dbManager, ILogger logger)
        {
            _queryEngine = queryEngine ?? throw new ArgumentNullException(nameof(queryEngine));
            _accessReader = accessReader ?? throw new ArgumentNullException(nameof(accessReader));
            _stringEncryption = stringEncryption ?? throw new ArgumentNullException(nameof(stringEncryption));
            _configManager = configManager ?? throw new ArgumentNullException(nameof(configManager));
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            InitializeComponent();
        }

        private async Task FetchQueriesAsync()
        {
            _configManager.Queries = await _queryEngine.FetchQueryStatementsAsync(CancellationToken.None);
        }

        private async void fMain_Load(object sender, EventArgs e)
        {
            _logger.Debug("Call to fMain_Load");

            await Task.Run(() => FetchQueriesAsync());
            LoadRecentConnections();
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
                
                // If the file the user selected exists in the list of previous connections, select it on the combo box
                var existingDb = _configManager.Settings.Databases.FirstOrDefault(db => db.FileName.Equals(dlgOpenFile.FileName, StringComparison.InvariantCultureIgnoreCase));
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

                var pwd = PromptUserForPassword(dlgOpenFile.FileName);
                if (string.IsNullOrWhiteSpace(pwd))
                {
                    return;
                }

                TestDbConnection(dlgOpenFile.FileName, pwd);
            }
            else
            {
                _logger.Debug("User cancelled opening a db file");
            }
        }

        private void TestDbConnection(string fileName, string pwd, bool removeOldConnection = false)
        {
            if (TestConnection(fileName, pwd))
            {
                _logger.Debug("Database with file name {fileName} successfully tested with provided credentials. Storing to recently used list.", fileName);
                if (removeOldConnection)
                {
                    var currentDb = _configManager.Settings.Databases.FirstOrDefault(f => f.FileName.Equals(fileName, StringComparison.InvariantCultureIgnoreCase));
                    if (currentDb != null)
                    {
                        _configManager.Settings.Databases.Remove(currentDb);
                    }
                }

                _configManager.Settings.Databases.Add(new AppSettingsDatabase
                {
                    ConnectionString = Formats.DefaultConnectionString,
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
            }
        }

        private void cmbPreviousConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionSelected();
        }

        private async void cmdStart_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                ctSource.Cancel();
                ResetUi();
            }
            else
            {
                _logger.Verbose("User invoked start of process with db file {fileName}", cmbPreviousConnections.SelectedItem.ToString());
                isProcessing = true;

                // Disable current controls to prevent user interaction...
                cmbPreviousConnections.Enabled = false;
                cmdBrowseFile.Enabled = false;
                cmdStart.Text = "Cancel";

                pbProcessing.Visible = true;

                var dbObject = _configManager.Settings.Databases.FirstOrDefault(db => db.FileName.Equals(txtDbFile.Text, StringComparison.InvariantCultureIgnoreCase));
                if (dbObject != null)
                {
                    await Task.Run(() => ProcessDbFile(dbObject, ctSource.Token));
                    ResetUi();
                }
            }
        }

        private void ResetUi()
        {
            pbProcessing.Visible = false;
            cmbPreviousConnections.Enabled = true;
            cmdBrowseFile.Enabled = true;
            cmdStart.Text = "Start";
        }

        private async Task ProcessDbFile(AppSettingsDatabase dbObject, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                var learners = await _accessReader.ReadLearnersAsync(dbObject, cancellationToken);
                isProcessing = false;
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException)
            {
                _logger.Warning("User cancelled processing of the DB file");
            }
        }

        private void ConnectionSelected()
        {
            _logger.Debug("Call to ConnectionSelected");

            var fi = new FileInfo(cmbPreviousConnections.SelectedItem.ToString());
            if (fi.Exists)
            {
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

            var connString = Formats.DefaultConnectionString.Replace("{dbFileName}", fileName).Replace("{dbPassword}", providedPassword);
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
    }
}
