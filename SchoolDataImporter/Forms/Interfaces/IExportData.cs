using SchoolDataImporter.Models;
using System.Collections.Generic;

namespace SchoolDataImporter.Forms.Interfaces
{
    public interface IExportData
    {
        void SetData(ICollection<Learner> learnerDataSet, ICollection<Staff> staffDataSet);

        void ShowForm();
    }
}
