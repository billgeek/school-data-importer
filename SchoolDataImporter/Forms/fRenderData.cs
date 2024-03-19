using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Constants;
using SchoolDataImporter.Controls;
using SchoolDataImporter.Forms.Interfaces;
using SchoolDataImporter.Helpers;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDataImporter.Forms
{
    public partial class fRenderData : Form, IExportData
    {
        private readonly string _rowsForExport = "{0} rows for export";

        private readonly ILogger _logger;
        private readonly IDataMapper _mapper;
        private readonly IConfigurationManager _configManager;
        private readonly IExcelEngine _excelEngine;

        // Data elements
        private ICollection<Learner> _learnerData;
        private ICollection<OtherStaff> _staffData;
        private ICollection<GoverningBody> _governingBodyData;
        private ICollection<Educator> _educatorData;

        // Internals
        private DataSet _dataSet = new DataSet();
        private bool _formInitialized = false;
        private bool _gridsInitialized = false;
        private int _sourceDataCount = 0;

        public fRenderData(IExcelEngine excelEngine, IDataMapper mapper, IConfigurationManager configManager, ILogger logger)
        {
            _excelEngine = excelEngine ?? throw new ArgumentNullException(nameof(excelEngine));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _configManager = configManager ?? throw new ArgumentNullException(nameof(configManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            // Wire up the PanelExpanded event for all expand panels - this is to collapse others when one is expanded
            expGender.PanelExpanded += new EventHandler(collapseOtherPanels);
            expGoverningBody.PanelExpanded += new EventHandler(collapseOtherPanels);
            expGradesClasses.PanelExpanded += new EventHandler(collapseOtherPanels);
            expHostels.PanelExpanded += new EventHandler(collapseOtherPanels);
            expHouses.PanelExpanded += new EventHandler(collapseOtherPanels);
            expPersonnelCategory.PanelExpanded += new EventHandler(collapseOtherPanels);
            expStatus.PanelExpanded += new EventHandler(collapseOtherPanels);
            expTextSearch.PanelExpanded += new EventHandler(collapseOtherPanels);
            expType.PanelExpanded += new EventHandler(collapseOtherPanels);

#if DEBUG
            pictureBox1.Visible = true;
#endif
        }

        private void collapseOtherPanels(object sender, EventArgs e)
        {
            ExpandingPanel actual = sender as ExpandingPanel;

            if (actual != expGender)
                expGender.CollapsePanel();
            if (actual != expGoverningBody)
                expGoverningBody.CollapsePanel();
            if (actual != expGradesClasses)
                expGradesClasses.CollapsePanel();
            if (actual != expHostels)
                expHostels.CollapsePanel();
            if (actual != expHouses)
                expHouses.CollapsePanel();
            if (actual != expPersonnelCategory)
                expPersonnelCategory.CollapsePanel();
            if (actual != expStatus)
                expStatus.CollapsePanel();
            if (actual != expTextSearch)
                expTextSearch.CollapsePanel();
            if (actual != expType)
                expType.CollapsePanel();
        }

        /// <inheritdoc />
        public void SetData(ICollection<Learner> learnerDataSet, ICollection<OtherStaff> staffDataSet, ICollection<GoverningBody> governingBodyDataSet, ICollection<Educator> educatorDataSet)
        {
            _logger.Information("Call to SetData on fRenderData");

            _learnerData = learnerDataSet;
            _staffData = staffDataSet;
            _governingBodyData = governingBodyDataSet;
            _educatorData = educatorDataSet;

            _sourceDataCount = _learnerData.Count + _staffData.Count + _governingBodyData.Count + _educatorData.Count;
            _sourceDataCount += _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.Parent?.FirstName) || !string.IsNullOrWhiteSpace(l.Parent?.LastName)).Count();
            _sourceDataCount += _learnerData.Where(item => !string.IsNullOrWhiteSpace(item.Parent?.Spouse?.FirstName) || !string.IsNullOrWhiteSpace(item.Parent?.Spouse?.LastName)).Count();

            _logger.Information($"{_sourceDataCount} unique rows to display");
        }

        /// <inheritdoc />
        public void ShowForm()
        {
            _logger.Information("Call to fRenderData ShowForm");
            Show();
        }

        private void fRenderData_Activated(object sender, System.EventArgs e)
        {
            // When activated, we need to load all the relevant information
            if (!_formInitialized)
            {
                _logger.Information("Call to fRenderData_Activated");

                _formInitialized = true;
                LoadAvailableData();
                LoadFilters();
                ConfigureDataViews();

                var rowCount = dgAvailableData.Rows.Count;
                lblRowCount.Text = $"{rowCount} / {_sourceDataCount} rows";

                // set timeout?
                Task.Delay(1000).ContinueWith(_ =>
                {
                    _gridsInitialized = true;
                });
            }
        }

        /// <summary>
        /// Load the values for all applicable filters
        /// </summary>
        private void LoadFilters()
        {
            _logger.Information("Call to LoadFilters");

            cmbLastNameOperator.SelectedIndex = 0;
            cmbFirstNameOperator.SelectedIndex = 0;

            // Default checks - Gender
            chkGenderFemale.Checked = true;
            chkGenderMale.Checked = true;
            chkGenderUnassigned.Checked = true;

            // Default checks - Status
            chkStatusArchived.Checked = false;
            chkStatusCurrent.Checked = true;
            chkStatusFuture.Checked = false;

            // Grades/Classes
            var gradesAndClasses = _learnerData.Select(l => MappingHelper.GetGradeClassCombination(l.Grade, l.Class)).Distinct().OrderBy(l => l).ToList();
            
            clbGradesClasses.Items.Clear();
            foreach (var item in gradesAndClasses)
            {
                clbGradesClasses.Items.Add(item);
                clbGradesClasses.SetItemChecked(clbGradesClasses.Items.Count - 1, true);
                _logger.Verbose("Filter item added: Grades and Classes - {gradeClass}", item);
            }

            // Houses
            var houses = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.House)).Select(l => l.House).Distinct().OrderBy(l => l).ToList();

            clbHouses.Items.Clear();
            clbHouses.Items.Add(AppConstants.Unassigned);
            clbHouses.SetItemChecked(clbHouses.Items.Count - 1, true);
            foreach (var house in houses)
            {
                clbHouses.Items.Add(house);
                clbHouses.SetItemChecked(clbHouses.Items.Count - 1, false);
                _logger.Verbose("Filter item added: House - {house}", house);
            }

            // Bus Routes
            var routes = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.BusRouteName)).Select(l => l.BusRouteName).Distinct().OrderBy(l => l).ToList();

            clbBusRoutes.Items.Clear();
            clbBusRoutes.Items.Add(AppConstants.Unassigned);
            clbBusRoutes.SetItemChecked(clbBusRoutes.Items.Count - 1, true);
            foreach (var route in routes)
            {
                clbBusRoutes.Items.Add(route);
                clbBusRoutes.SetItemChecked(clbBusRoutes.Items.Count - 1, true);
                _logger.Verbose("Filter item added: Bus Route - {route}", route);
            }

            // Hostels
            var hostels = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.HostelName)).Select(l => l.HostelName).Distinct().OrderBy(l => l).ToList();

            clbHostels.Items.Clear();
            clbHostels.Items.Add(AppConstants.Unassigned);
            clbHostels.SetItemChecked(clbHostels.Items.Count - 1, true);
            foreach (var hostel in hostels)
            {
                clbHostels.Items.Add(hostel);
                clbHostels.SetItemChecked(clbHostels.Items.Count - 1, false);
                _logger.Verbose("Filter item added: Hostel - {hostel}", hostel);
            }

            // Personnel Categories
            var categories = _staffData.Where(l => !string.IsNullOrWhiteSpace(l.PersonnelCategory)).Select(l => l.PersonnelCategory).Distinct().OrderBy(l => l).ToList();

            clbPersonnelCategory.Items.Clear();
            clbPersonnelCategory.Items.Add(AppConstants.Unassigned);
            clbPersonnelCategory.SetItemChecked(clbPersonnelCategory.Items.Count - 1, true);
            foreach (var category in categories)
            {
                clbPersonnelCategory.Items.Add(category);
                clbPersonnelCategory.SetItemChecked(clbPersonnelCategory.Items.Count - 1, false);
                _logger.Verbose("Filter item added: Personnel Category - {personnelCategory}", category);
            }

            // Governing Body
            var members = _governingBodyData.Select(l => l.TypeOfMember).Distinct().OrderBy(l => l).ToList();

            clbGoverningBody.Items.Clear();
            clbGoverningBody.Items.Add(AppConstants.Unassigned);
            clbGoverningBody.SetItemChecked(clbGoverningBody.Items.Count - 1, true);
            foreach (var member in members)
            {
                clbGoverningBody.Items.Add(member);
                clbGoverningBody.SetItemChecked(clbGoverningBody.Items.Count - 1, false);
                _logger.Verbose("Filter item added: Governing Body Member Type - {memberType}", member);
            }

            // Default checks - Type
            chkTypeLearner.Checked = false;
            chkTypeParent.Checked = true;
            chkTypeStaff.Checked = false;

            cmdApplyFilters_Click(this, new System.EventArgs());
        }

        private void ConfigureDataViews()
        {
            _logger.Information("Call to ConfigureDataViews");
            var columns = _configManager.Settings.GetDataGridColumns();

            dgAvailableData.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgAvailableData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgAvailableData.ColumnHeadersDefaultCellStyle.Font = new Font(dgAvailableData.Font, FontStyle.Bold);

            // dgAvailableData.ColumnCount = _dataViewColumns.Count + 1;
            foreach(var col in columns)
            {
                _logger.Verbose("Adding column {columnNumber} with column name {columnName} to Available DataGrid", col.Key, col.Value);

                dgAvailableData.Columns[col.Key].Name = col.Value;
                dgAvailableData.Columns[col.Key].DataPropertyName = col.Value;
            }
            dgAvailableData.Columns[dgAvailableData.ColumnCount - 1].Name = AppConstants.UniqueIdentifierFieldName;
            dgAvailableData.Columns[dgAvailableData.ColumnCount - 1].Visible = false;

            dgSelected.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgSelected.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgSelected.ColumnHeadersDefaultCellStyle.Font = new Font(dgAvailableData.Font, FontStyle.Bold);

            dgSelected.ColumnCount = columns.Count + 1;
            foreach (var col in columns)
            {
                _logger.Verbose("Adding column {columnNumber} with column name {columnName} to Selected DataGrid", col.Key, col.Value);
                dgSelected.Columns[col.Key].Name = col.Value;
            }
            dgSelected.Columns[dgSelected.ColumnCount - 1].Name = AppConstants.UniqueIdentifierFieldName;
            dgSelected.Columns[dgSelected.ColumnCount - 1].Visible = false;
        }

        private void LoadAvailableData()
        {
            _logger.Information("Call to LoadAvailableData");

            var table = new DataTable("Data");
            foreach(var col in _configManager.Settings.GetDataGridColumns())
            {
                _logger.Verbose("Adding column with column name {columnName} to data table", col.Value);
                table.Columns.Add(col.Value);
            }
            table.Columns.Add(AppConstants.UniqueIdentifierFieldName);

            _dataSet.Tables.Add(table);

            LoadLearnerData();
            LoadParentData();
            LoadParentSpouseData();
            LoadEducatorData();
            LoadStaffData();
            LoadGoverningBodyData();

            _logger.Information("Creating DataSource filter for data grid");
            var view = new DataView(_dataSet.Tables[0]);
            var src = new BindingSource();
            src.DataSource = view;
            dgAvailableData.DataSource = src;
        }

        private void LoadLearnerData()
        {
            _logger.Information("Call to LoadLearnerData");

            foreach (var item in _learnerData.Distinct())
            {
                var rowData = _mapper.GetModelRowData(item);
                _dataSet.Tables[0].Rows.Add(rowData);
            }
        }

        private void LoadParentData()
        {
            _logger.Information("Call to LoadParentData");

            foreach (var item in _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.Parent?.FirstName) || !string.IsNullOrWhiteSpace(l.Parent?.LastName)).Distinct())
            {
                var parentData = _mapper.GetModelRowData(item.Parent);
                _dataSet.Tables[0].Rows.Add(parentData);
            }
        }

        private void LoadParentSpouseData()
        {
            _logger.Information("Call to LoadParentSpouseData");

            foreach (var item in _learnerData.Where(item => !string.IsNullOrWhiteSpace(item.Parent?.Spouse?.FirstName) || !string.IsNullOrWhiteSpace(item.Parent?.Spouse?.LastName)).Distinct())
            {
                var parentData = _mapper.GetModelRowData(item.Parent.Spouse);
                _dataSet.Tables[0].Rows.Add(parentData);
            }
        }

        private void LoadEducatorData()
        {
            _logger.Information("Call to LoadEducatorData");

            foreach (var item in _educatorData.Distinct())
            {
                var rowData = _mapper.GetModelRowData(item);
                _dataSet.Tables[0].Rows.Add(rowData);
            }
        }

        private void LoadStaffData()
        {
            _logger.Information("Call to LoadStaffData");

            foreach (var item in _staffData.Distinct())
            {
                var rowData = _mapper.GetModelRowData(item);
                _dataSet.Tables[0].Rows.Add(rowData);
            }
        }

        private void LoadGoverningBodyData()
        {
            _logger.Information("Call to LoadGoverningBodyData");

            foreach (var item in _governingBodyData.Distinct())
            {
                var rowData = _mapper.GetModelRowData(item);
                _dataSet.Tables[0].Rows.Add(rowData);
            }
        }

        private void cmdClearFilters_Click(object sender, System.EventArgs e)
        {
            _logger.Verbose("User selected Clear Filters");

            LoadFilters();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            SetRowHighlighting();
        }

        private void cmdApplyFilters_Click(object sender, System.EventArgs e)
        {
            _logger.Verbose("User selected Apply Filters");

            var dv = new DataView(_dataSet.Tables[0]);
            var src = new BindingSource();
            src.DataSource = dv;

            dgAvailableData.DataSource = src;

            var filterString = string.Empty;

            // category
            _logger.Verbose("Checking Category filter");
            var typeValues = new List<string>();
            if (chkTypeLearner.Checked)
                typeValues.Add("Learner");
            if (chkTypeParent.Checked)
                typeValues.Add("Parent");
            if (chkTypeStaff.Checked)
                typeValues.Add("Staff");

            filterString = AppendMultiToFilterString(filterString, "Type", typeValues);

            // Gender
            _logger.Verbose("Checking Gender filter");
            var genderValues = new List<string>();
            if (chkGenderMale.Checked)
                genderValues.Add("Male");
            if (chkGenderFemale.Checked)
                genderValues.Add("Female");
            if (chkGenderUnassigned.Checked)
                genderValues.Add(string.Empty);

            filterString = AppendMultiToFilterString(filterString, "Gender", genderValues);

            // Status
            _logger.Verbose("Checking Status filter");
            var statusValues = new List<string>();
            if (chkStatusUnassigned.Checked)
                statusValues.Add(AppConstants.Unassigned);
            if (chkStatusCurrent.Checked)
                statusValues.Add("Current");
            if (chkStatusArchived.Checked)
                statusValues.Add("Archived");
            if (chkStatusFuture.Checked)
                statusValues.Add("Future");

            filterString = AppendMultiToFilterString(filterString, "Status", statusValues);

            // Do not check grades, houses or hostels when staff is selected
            if (!chkTypeStaff.Checked)
            {
                // Grades and classes
                _logger.Verbose("Checking Grades and Classes filter");
                filterString = GetCheckedValuesForFilter(clbGradesClasses, filterString, "Grade / Class", false);

                // Houses
                _logger.Verbose("Checking Houses filter");
                filterString = GetCheckedValuesForFilter(clbHouses, filterString, "House", true);

                // Hostels
                _logger.Verbose("Checking Hostels filter");
                filterString = GetCheckedValuesForFilter(clbHostels, filterString, "Hostel", true);

                // Bus Routes
                _logger.Verbose("Checking Bus Routes filter");
                filterString = GetCheckedValuesForFilter(clbBusRoutes, filterString, "Bus Route", true);
            }

            // TODO: We need to split these...
            // Personnel Categories
            _logger.Verbose("Checking Personnel Category filter");
            filterString = GetCheckedValuesForFilter(clbPersonnelCategory, filterString, "Other Staff Type", true);

            // Governing Body
            _logger.Verbose("Checking Governing Body filter");
            filterString = GetCheckedValuesForFilter(clbGoverningBody, filterString, "Governing Body", true);

            if (!string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                _logger.Verbose("Checking First Name filter");
                filterString = AppendToFilterString(filterString, "First Name", txtFirstName.Text, cmbFirstNameOperator.SelectedItem.ToString());
            }

            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                _logger.Verbose("Checking Last Name filter");
                filterString = AppendToFilterString(filterString, "Last Name", txtLastName.Text, cmbLastNameOperator.SelectedItem.ToString());
            }

            if (chkOnlyNonBlank.Checked)
            {
                filterString += $" AND [{AppConstants.MobileNumberCellName}] <> ''";
            }

            _logger.Verbose("Applying filter to data grid - filter string: {filterString}", filterString);
            src.Filter = filterString;
            txtTotalFilter.Text = filterString;
            var filteredCount = src.Count;
            lblRowCount.Text = $"{filteredCount} / {_sourceDataCount} rows";

            SetRowHighlighting();
        }

        private string GetCheckedValuesForFilter(CheckedListBox clb, string filterString, string fieldName, bool firstValueForAll)
        {
            _logger.Verbose("Getting filter values for checked list box with field name {fieldName} and first value selected for all {firstForAll}", firstValueForAll); ;

            // Don't filter if everything is selected
            if (clb.CheckedItems.Count == clb.Items.Count)
            {
                _logger.Verbose("Every element in check list box is selected; Skipping filtering");
                return filterString;
            }

            var values = new List<string>();
            if (firstValueForAll)
            {
                if (clb.GetItemChecked(0))
                {
                    values.Add(string.Empty);
                }
                else
                {
                    filterString = AppendToFilterString(filterString, fieldName, "", "Not Equal to");
                }
            }

            foreach (var item in clb.CheckedItems)
            {
                if (!item.ToString().Equals(AppConstants.Unassigned, StringComparison.InvariantCultureIgnoreCase))
                {
                    values.Add(item.ToString());
                }
            }
            filterString = AppendMultiToFilterString(filterString, fieldName, values);

            return filterString;
        }

        private string AppendToFilterString(string filterString, string fieldName, string fieldValue, string filterOperator = "")
        {
            _logger.Verbose("Appending to filter string with field name {fieldName}, field value {fieldValue} and operator {filterOperator}", fieldName, fieldValue, filterOperator);

            filterString += string.IsNullOrWhiteSpace(filterString) ? "" : " AND ";

            switch (filterOperator)
            {
                case "Starts with":
                    filterString += $"[{fieldName}] LIKE '{fieldValue}*'";
                    break;
                case "Ends with":
                    filterString += $"[{fieldName}] LIKE '*{fieldValue}'";
                    break;
                case "Contains":
                    filterString += $"[{fieldName}] LIKE '*{fieldValue}*'";
                    break;
                case "Not Equal to":
                    filterString += $"[{fieldName}] <> '{fieldValue}'";
                    break;
                default:
                    filterString += $"[{fieldName}] = '{fieldValue}'";
                    break;
            }

            return filterString;
        }

        private string AppendMultiToFilterString(string filterString, string fieldName, List<string> fieldValues)
        {
            _logger.Verbose("Appending multiple values for filter string with field name {fieldName} and values @{fieldValues}", fieldName, fieldValues);

            filterString += string.IsNullOrWhiteSpace(filterString) ? "" : " AND ";

            var combine = string.Join($"' OR [{fieldName}] = '", fieldValues);
            filterString += $"([{fieldName}] = '{combine}')";

            return filterString;
        }

        private void cmdAddSelected_Click(object sender, System.EventArgs e)
        {
            _logger.Verbose("User adding selected rows");

            foreach(var row in dgAvailableData.SelectedRows)
            {
                var item = row as DataGridViewRow;

                if (chkOnlyValidNumbers.Checked && item.Cells[AppConstants.MobileNumberCellName].Value?.ToString().Length < 10)
                {
                    _logger.Verbose("Selected item skipped as the number is less than 10 characters long");
                    continue;
                }

                item.DefaultCellStyle.BackColor = SystemColors.Info;

                var uniqueId = item.Cells[AppConstants.UniqueIdentifierFieldName].Value.ToString();
                _logger.Verbose("Finding unique row on existing selected rows with identifier {uniqueIdentifier}", uniqueId);

                var matchingRow = dgSelected.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[AppConstants.UniqueIdentifierFieldName].Value.ToString().Equals(uniqueId)).FirstOrDefault();
                if (matchingRow == null)
                {
                    _logger.Verbose("Matching row not found; Adding to selected list");

                    var rowIdx = dgSelected.Rows.Add();
                    for (int i = 0; i < item.Cells.Count; i++)
                    {
                        dgSelected.Rows[rowIdx].Cells[i].Value = item.Cells[i].Value;
                    }
                }
            }
            UpdateSelectionCount(dgSelected.Rows.Count);
        }

        private void dgAvailableData_SelectionChanged(object sender, System.EventArgs e)
        {
            cmdAddSelected.Enabled = dgAvailableData.SelectedRows.Count > 0;
        }

        private void dgSelected_SelectionChanged(object sender, System.EventArgs e)
        {
            cmdRemoveSelected.Enabled = dgSelected.SelectedRows.Count > 0;

            // If we select more than one row, only export the rows in question
            if (dgSelected.SelectedRows.Count > 1)
            {
                chkOnlySelected.Checked = true;
                UpdateSelectionCount(dgSelected.SelectedRows.Count);
            }
            else
            {
                chkOnlySelected.Checked = false;
                UpdateSelectionCount(dgSelected.Rows.Count);
            }
        }

        private void cmdRemoveAll_Click(object sender, System.EventArgs e)
        {
            _logger.Verbose("User selected to remove all");
            if (MessageBox.Show($"You have selected to remove all rows from the selected list.{Environment.NewLine}Are you sure that you wish to do this?", "Removing all Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                _logger.Verbose("User cancelled remove all");
                return;
            }

            dgSelected.Rows.Clear();

            _logger.Verbose("Clearing all row selections");
            foreach (var row in dgAvailableData.Rows)
            {
                var item = row as DataGridViewRow;
                item.DefaultCellStyle.BackColor = SystemColors.Window;
            }
            UpdateSelectionCount(dgSelected.Rows.Count);
        }

        private void cmdRemoveSelected_Click(object sender, System.EventArgs e)
        {
            _logger.Verbose("User selected to remove selected rows");

            foreach(var row in dgSelected.SelectedRows)
            {
                var item = row as DataGridViewRow;

                // We need to remove the highlighting from the source row
                var uniqueId = item.Cells[AppConstants.UniqueIdentifierFieldName].Value.ToString();
                _logger.Verbose("Attempting to find row in selected list with unique identifier {uniqueIdentifier}", uniqueId);
                var matchingRow = dgAvailableData.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[AppConstants.UniqueIdentifierFieldName].Value.ToString().Equals(uniqueId)).FirstOrDefault();
                if (matchingRow != null)
                {
                    _logger.Verbose("Found matching row; Removing selection");
                    matchingRow.DefaultCellStyle.BackColor = SystemColors.Window;
                }

                dgSelected.Rows.Remove(item);
            }
            UpdateSelectionCount(dgSelected.Rows.Count);
        }

        private void cmdAddAll_Click(object sender, System.EventArgs e)
        {
            _logger.Verbose("User selected to add all rows");
            if (MessageBox.Show($"You have selected to add all rows to the selected list.{Environment.NewLine}Are you sure that you wish to do this?","Adding all Rows",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                _logger.Verbose("User cancelled adding all rows");
                return;
            }

            foreach (var row in dgAvailableData.Rows)
            {
                _logger.Verbose("Setting background for row");
                var item = row as DataGridViewRow;

                if (chkOnlyValidNumbers.Checked && item.Cells[AppConstants.MobileNumberCellName].Value?.ToString().Length < 10)
                {
                    _logger.Verbose("Selected item skipped as the number is less than 10 characters long");
                    continue;
                }

                item.DefaultCellStyle.BackColor = SystemColors.Info;

                var rowIdx = dgSelected.Rows.Add();
                for (int i = 0; i < item.Cells.Count; i++)
                {
                    dgSelected.Rows[rowIdx].Cells[i].Value = item.Cells[i].Value;
                }
            }
            UpdateSelectionCount(dgSelected.Rows.Count);
        }

        private void dgSelected_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cmdExportData.Enabled = dgSelected.Rows.Count > 0;
            cmdCopyToClipboard.Enabled = dgSelected.Rows.Count > 0;
        }

        private void dgSelected_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cmdExportData.Enabled = dgSelected.Rows.Count > 0;
            cmdCopyToClipboard.Enabled = dgSelected.Rows.Count > 0;
        }

        private void cmdExportData_Click(object sender, EventArgs e)
        {
            _logger.Information("User selected to export data to Excel");

            dlgSave.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            var dlgResult = dlgSave.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                var (data, count) = CollectExportData();
                var fileContent = _excelEngine.ExportResultsToExcel(AppConstants.ExcelExportColumnHeaders, data, "Exported Data");
                File.WriteAllBytes(dlgSave.FileName, fileContent);

                if (MessageBox.Show($"{count} records exported successfully. Do you wish to open the file now?", "Export Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var pi = new ProcessStartInfo(dlgSave.FileName);
                    pi.UseShellExecute = true;
                    Process.Start(pi);
                }

                if (MessageBox.Show($"Do you wish to keep the current list selected?", "Export Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    _logger.Verbose("User selected to clear results after export");
                    cmdClearFilters_Click(this, new EventArgs());
                    dgSelected.Rows.Clear();
                    UpdateSelectionCount(0);
                }
            }
        }

        private void cmdGradesSelectAll_Click(object sender, EventArgs e)
        {
            _logger.Verbose("User selected to check all grades and classes");
            for (var i = 0; i < clbGradesClasses.Items.Count;i++)
            {
                clbGradesClasses.SetItemChecked(i, true);
            }
        }

        private void cmdGradesSelectNone_Click(object sender, EventArgs e)
        {
            _logger.Verbose("User selected to clear all grades and classes");
            for (var i = 0; i < clbGradesClasses.Items.Count; i++)
            {
                clbGradesClasses.SetItemChecked(i, false);
            }
        }

        private void SetRowHighlighting()
        {
            _logger.Verbose("Setting row highlighting for previously selected rows");

            foreach(var selRow in dgSelected.Rows)
            {
                var selItem = selRow as DataGridViewRow;
                var uniqueId = selItem.Cells[AppConstants.UniqueIdentifierFieldName].Value.ToString();
                _logger.Verbose("Attempting to find row with unique identifier {uniqueIdentifier}", uniqueId);
                var matchingRow = dgAvailableData.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[AppConstants.UniqueIdentifierFieldName].Value.ToString().Equals(uniqueId)).FirstOrDefault();
                if (matchingRow != null)
                {
                    _logger.Verbose("Found matching row; Setting highlighting");
                    matchingRow.DefaultCellStyle.BackColor = SystemColors.Info;
                }
            }
            UpdateSelectionCount(dgSelected.Rows.Count);
            SetColumnOrder();
        }

        private void dgAvailableData_Sorted(object sender, EventArgs e)
        {
            _logger.Verbose("Data grid sorted - need to set highlighting");
            SetRowHighlighting();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtTotalFilter.Visible = !txtTotalFilter.Visible;
        }

        private void TypeCheckChanged(object sender, EventArgs e)
        {
            // Wait for the form to be initialized before attempting this
            // Otherwise there are zero items in the list!
            if (!_formInitialized)
                return;

            if (chkTypeParent.Checked || chkTypeLearner.Checked)
            {
                SetAllCheckItemsForList(clbPersonnelCategory, true, false, true);
                SetAllCheckItemsForList(clbGoverningBody, true, false, true);
            }
            else
            {
                clbPersonnelCategory.Enabled = true;
                clbGoverningBody.Enabled = true;
            }

            if (chkTypeStaff.Checked)
            {
                SetAllCheckItemsForList(clbGradesClasses, true, true, true);
                SetAllCheckItemsForList(clbHouses, true, true, true);
                SetAllCheckItemsForList(clbHostels, true, true, true);
            }
            else
            {
                clbGradesClasses.Enabled = true;
                clbHouses.Enabled = true;
                clbHostels.Enabled = true;
            }
        }

        private void SetAllCheckItemsForList(CheckedListBox targetList, bool checkFirstRow, bool valueToSet, bool disableControl)
        {
            if (checkFirstRow)
            {
                targetList.SetItemChecked(0, true);
            }
            for (var i = 1; i < targetList.Items.Count; i++)
            {
                targetList.SetItemChecked(i, valueToSet);
            }
            targetList.Enabled = !disableControl;
        }

        private void cmdCopyToClipboard_Click(object sender, EventArgs e)
        {
            _logger.Information("User selected to copy data to clipboard");

            var sb = new StringBuilder();
            sb.Append($"Name\tMobile\tmerge1{Environment.NewLine}");

            var (data, count) = CollectExportData();
            foreach(var line in data)
            {
                sb.Append(string.Join("\t", line.ToArray()));
                sb.Append(Environment.NewLine);
            }

            var result = sb.ToString();
            _logger.Information("Setting clipboard data with {rowCount} rows", count);
            Clipboard.SetText(result);

            if (MessageBox.Show($"{count} records copied to the Clipboard.{Environment.NewLine}Do you wish to keep the current list selected?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                _logger.Verbose("User selected to clear results after export");
                cmdClearFilters_Click(this, new EventArgs());
                dgSelected.Rows.Clear();
                UpdateSelectionCount(0);
            }
        }

        private (List<List<string>>, int) CollectExportData()
        {
            var result = new List<List<string>>();
            var count = 0;

            if (chkOnlySelected.Checked)
            {
                count = dgSelected.SelectedRows.Count;
                foreach (var row in dgSelected.SelectedRows)
                {
                    var item = row as DataGridViewRow;

                    result.Add(new List<string>
                {
                    $"{item.Cells[AppConstants.FirstNameCellName].Value} {item.Cells[AppConstants.LastNameCellName].Value}",
                    item.Cells[AppConstants.MobileNumberCellName].Value.ToString(),
                    item.Cells[AppConstants.ChildInformationCellName].Value.ToString()
                });
                }
            }
            else
            {
                count = dgSelected.Rows.Count;
                foreach (var row in dgSelected.Rows)
                {
                    var item = row as DataGridViewRow;

                    result.Add(new List<string>
                {
                    $"{item.Cells[AppConstants.FirstNameCellName].Value} {item.Cells[AppConstants.LastNameCellName].Value}",
                    item.Cells[AppConstants.MobileNumberCellName].Value.ToString(),
                    item.Cells[AppConstants.ChildInformationCellName].Value.ToString()
                });
                }
            }
            
            return (result, count);
        }

        private void UpdateSelectionCount(int selectionCount)
        {
            lblExportCount.Text = string.Format(_rowsForExport, selectionCount);
        }

        private void chkOnlySelected_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnlySelected.Checked)
            {
                UpdateSelectionCount(dgSelected.SelectedRows.Count);
            }
            else
            {
                UpdateSelectionCount(dgSelected.Rows.Count);
            }
        }

        private void fRenderData_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveColumnOrders();
        }

        private struct GridColumn
        {
            public int Index { get; set; }
            public string Name { get; set; }
        }
        private void SaveColumnOrders()
        {
            var colDic = new List<GridColumn>();

            foreach (DataGridViewColumn col in dgAvailableData.Columns)
            {
                if (AppConstants.ColumnNames.Contains(col.Name))
                {
                    colDic.Add(new GridColumn { Name = col.Name, Index = col.DisplayIndex });
                }
            }

            _configManager.Settings.ColumnNames = colDic.OrderBy(s => s.Index).Select(s => s.Name).ToArray();

            // Store the config file
            _configManager.StoreConfiguration();
        }

        private void cmdRoutesSelNone_Click(object sender, EventArgs e)
        {
            _logger.Verbose("User selected to clear all bus routes");
            for (var i = 0; i < clbBusRoutes.Items.Count; i++)
            {
                clbBusRoutes.SetItemChecked(i, false);
            }
        }

        private void cmdRoutesSelAll_Click(object sender, EventArgs e)
        {
            _logger.Verbose("User selected to check all bus routes");
            for (var i = 0; i < clbBusRoutes.Items.Count; i++)
            {
                clbBusRoutes.SetItemChecked(i, true);
            }
        }

        private void dgAvailableData_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            SetColumnOrder();
        }

        private void SetColumnOrder()
        {
            if (_gridsInitialized)
            {
                var colDic = new List<GridColumn>();

                foreach (DataGridViewColumn col in dgAvailableData.Columns)
                {
                    if (AppConstants.ColumnNames.Contains(col.Name))
                    {
                        colDic.Add(new GridColumn { Name = col.Name, Index = col.DisplayIndex });
                    }
                }

                foreach (var col in colDic.OrderByDescending(s => s.Index))
                {
                    dgSelected.Columns[col.Name].DisplayIndex = col.Index;
                }
            }
        }
    }
}
