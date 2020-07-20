using SchoolDataImporter.Forms.Interfaces;
using SchoolDataImporter.Helpers;
using SchoolDataImporter.Models;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolDataImporter.Forms
{
    public partial class fTest : Form, IExportData
    {
        private ICollection<Learner> _learnerData;
        private ICollection<OtherStaff> _staffData;
        private ICollection<GoverningBody> _governingBodyData;
        private ICollection<Educator> _educatorData;

        public fTest()
        {
            InitializeComponent();
        }

        public void SetData(ICollection<Learner> learnerDataSet, ICollection<OtherStaff> staffDataSet, ICollection<GoverningBody> governingBodyDataSet, ICollection<Educator> educatorDataSet)
        {
            _learnerData = learnerDataSet;
            _staffData = staffDataSet;
            _governingBodyData = governingBodyDataSet;
            _educatorData = educatorDataSet;
        }

        public void ShowForm()
        {
            Show();
        }

        private void fTest_Load(object sender, System.EventArgs e)
        {
        }

        private void fTest_Activated(object sender, System.EventArgs e)
        {
            if (dg.Rows.Count == 0)
            {
                LoadLearnerDataToView();
            }
        }


        private void LoadLearnerDataToView()
        {
            dg.ColumnCount = 12;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.Font =
                new Font(dg.Font, FontStyle.Bold);

            dg.Columns[0].Name = "Type";
            dg.Columns[1].Name = "Staff Type";
            dg.Columns[2].Name = "First Name";
            dg.Columns[3].Name = "Last Name";
            dg.Columns[4].Name = "Cell. No.";
            dg.Columns[5].Name = "Gender";
            dg.Columns[6].Name = "Status";
            dg.Columns[7].Name = "Grade";
            dg.Columns[8].Name = "Class";
            dg.Columns[9].Name = "House";
            dg.Columns[10].Name = "Hostel";
            dg.Columns[11].Name = "Category / Gov. Body Type";

            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = true;

            dgSelected.ColumnCount = 12;
            dgSelected.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgSelected.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgSelected.ColumnHeadersDefaultCellStyle.Font =
                new Font(dg.Font, FontStyle.Bold);

            dgSelected.Columns[0].Name = "Type";
            dgSelected.Columns[1].Name = "Staff Type";
            dgSelected.Columns[2].Name = "First Name";
            dgSelected.Columns[3].Name = "Last Name";
            dgSelected.Columns[4].Name = "Cell. No.";
            dgSelected.Columns[5].Name = "Gender";
            dgSelected.Columns[6].Name = "Status";
            dgSelected.Columns[7].Name = "Grade";
            dgSelected.Columns[8].Name = "Class";
            dgSelected.Columns[9].Name = "House";
            dgSelected.Columns[10].Name = "Hostel";
            dgSelected.Columns[11].Name = "Category / Gov. Body Type";

            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = true;

            foreach (var item in _learnerData)
            {
                var rowData = new string[] {
                    "Learner",
                    string.Empty,
                    item.FirstName,
                    item.LastName,
                    $"{item.MobilePhoneCode}{item.MobilePhoneNumber}",
                    item.Gender,
                    item.Status,
                    item.Grade,
                    item.Class,
                    item.House,
                    item.HostelName,
                    string.Empty
                };
                dg.Rows.Add(rowData);
            }

            foreach (var item in _educatorData)
            {
                var rowData = new string[] {
                    "Staff",
                    "Educator",
                    item.FirstName,
                    item.LastName,
                    $"{item.MobilePhoneCode}{item.MobilePhoneNumber}",
                    item.Gender,
                    item.Status,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty
                };
                dg.Rows.Add(rowData);
            }

            foreach (var item in _staffData)
            {
                var rowData = new string[] {
                    "Staff",
                    "Other Staff",
                    item.FirstName,
                    item.LastName,
                    $"{item.MobilePhoneCode}{item.MobilePhoneNumber}",
                    item.Gender,
                    item.Status,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    item.PersonnelCategory
                };
                dg.Rows.Add(rowData);
            }

            foreach (var item in _governingBodyData)
            {
                var rowData = new string[] {
                    "Staff",
                    "Governing Body",
                    item.FirstName,
                    item.LastName,
                    $"{item.MobilePhoneCode}{item.MobilePhoneNumber}",
                    item.Gender,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    item.TypeOfMember
                };
                dg.Rows.Add(rowData);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pnlFilters.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void cmbPersonType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbPersonType.SelectedItem.ToString() == "All")
            {
                RemoveDataFilter(0);
            }
            else
            {
                ApplyDataFilter(0, cmbPersonType.SelectedItem.ToString());
            }
        }

        private void RemoveDataFilter(int fieldIndex)
        {
            foreach (var row in dg.Rows)
            {
                var dgRow = row as DataGridViewRow;
                dgRow.Visible = true;
            }
        }

        private void ApplyDataFilter(int fieldIndex, string fieldValue)
        {
            foreach(var row in dg.Rows)
            {
                var dgRow = row as DataGridViewRow;
                var valueToTest = dgRow.Cells[fieldIndex].Value.ToString();
                dgRow.Visible = valueToTest.Equals(fieldValue, System.StringComparison.InvariantCultureIgnoreCase);
            }
        }

        private void dg_SelectionChanged(object sender, System.EventArgs e)
        {
            cmdAddSelected.Enabled = dg.SelectedRows.Count > 0;
        }

        private void cmdAddSelected_Click(object sender, System.EventArgs e)
        {
            foreach(var row in dg.SelectedRows)
            {
                var dgRow = row as DataGridViewRow;
                dgRow.Visible = false;

                var newRowData = new List<string>();
                foreach(var item in dgRow.Cells)
                {
                    var cell = item as DataGridViewCell;
                    newRowData.Add(cell.Value.ToString());
                }
                dgSelected.Rows.Add(newRowData.ToArray());
            }
        }
    }
}
