using SchoolDataImporter.Forms.Interfaces;
using SchoolDataImporter.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolDataImporter.Forms
{
    public partial class fExportData : Form, IExportData
    {
        private ICollection<Learner> _learnerData;
        private ICollection<OtherStaff> _staffData;
        private ICollection<GoverningBody> _governingBodyData;
        private ICollection<Educator> _educatorData;

        public fExportData()
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

        private void fExportData_Load(object sender, System.EventArgs e)
        {
            LoadGradesAndClasses();
            LoadHouses();
            LoadHostels();
            LoadOtherStaffTypes();
        }

        private void LoadGradesAndClasses()
        {
            var grades = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.Grade)).Select(l => int.Parse(l.Grade)).OrderBy(l => l).Distinct().ToList();
            foreach (var grade in grades)
            {
                clbGrades.Items.Add($"Gr. {grade}");
            }

            var classes = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.Class)).Select(l => l.Class).OrderBy(l => l).Distinct().ToList();
            foreach (var learnerClass in classes)
            {
                clbGrades.Items.Add(learnerClass);
            }

            // Set all checks to TRUE
            for (var i = 0; i < clbGrades.Items.Count; i++)
            {
                clbGrades.SetItemChecked(i, true);
            }
        }

        private void LoadHouses()
        {
            var hostels = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.HostelName)).Select(l => l.HostelName).Distinct().OrderBy(l => l).ToList();
            
            foreach(var hostel in hostels)
            {
                clbHostel.Items.Add(hostel);
            }
        }

        private void LoadHostels()
        {
            var houses = _learnerData.Where(l => !string.IsNullOrWhiteSpace(l.House)).Select(l => l.House).Distinct().OrderBy(l => l).ToList();

            // Add the default
            clbHouse.Items.Add("UNASSIGNED");
            foreach (var house in houses)
            {
                clbHouse.Items.Add(house);
            }
        }

        private void LoadOtherStaffTypes()
        {
            var categories = _staffData.Where(s => !string.IsNullOrWhiteSpace(s.PersonnelCategory)).Select(s => s.PersonnelCategory).Distinct().OrderBy(s => s).ToList();

            foreach (var category in categories)
            {
                clbOtherStaff.Items.Add(category);
            }
        }

        private void optStaff_CheckedChanged(object sender, System.EventArgs e)
        {
            SetGradeSelectionEnabled();
            SetFilterPanelsVisible();
        }

        private void SetFilterPanelsVisible()
        {
            pnlStaffFilter.Visible = optStaff.Checked;
            pnlHostel.Visible = !optStaff.Checked;
            pnlHouseFilter.Visible = !optStaff.Checked;
        }

        /// <summary>
        /// Only allow
        /// </summary>
        /// <remarks>
        /// Only allow selecting grades if the Learners or Parents options are selected AND the "Current" status is selected.
        /// </remarks>
        private void SetGradeSelectionEnabled()
        {
            chkAllGrades.Enabled = (optLearners.Checked || optParents.Checked) && chkStatusCurrent.Checked;
            clbGrades.Enabled = chkAllGrades.Enabled;
        }

        private void chkStatusCurrent_CheckedChanged(object sender, System.EventArgs e)
        {
            SetGradeSelectionEnabled();
        }

        private void optStaffEducators_CheckedChanged(object sender, System.EventArgs e)
        {
            SetOtherStaffFilterVisible();
        }

        private void SetOtherStaffFilterVisible()
        {
            clbOtherStaff.Visible = optStaffOther.Checked;
        }
    }
}
