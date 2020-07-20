using SchoolDataImporter.Models;
using System.Collections.Generic;

namespace SchoolDataImporter.Forms.Interfaces
{
    public interface IExportData
    {
        void SetData(ICollection<Learner> learnerDataSet, ICollection<OtherStaff> staffDataSet, ICollection<GoverningBody> governingBodyDataSet, ICollection<Educator> educatorDataSet);

        void ShowForm();
    }
}
