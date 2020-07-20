using SchoolDataImporter.Forms.Interfaces;
using SchoolDataImporter.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolDataImporter.Forms
{
    public partial class fExportData : Form, IExportData
    {
        private ICollection<Learner> _learnerData;
        private ICollection<Staff> _staffData;

        public fExportData()
        {
            InitializeComponent();
        }

        public void SetData(ICollection<Learner> learnerDataSet, ICollection<Staff> staffDataSet)
        {
            _learnerData = learnerDataSet;
            _staffData = staffDataSet;
        }

        public void ShowForm()
        {
            base.Show();
        }

        private void fExportData_Load(object sender, System.EventArgs e)
        {
        }
    }
}
