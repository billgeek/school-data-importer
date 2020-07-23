using SchoolDataImporter.Models;
using System.Collections.Generic;

namespace SchoolDataImporter.Forms.Interfaces
{
    /// <summary>
    /// Interface for the Export Data UI form.
    /// </summary>
    public interface IExportData
    {
        /// <summary>
        /// Set the internal variables for the data elements in the form.
        /// </summary>
        /// <param name="learnerDataSet">The Learner data set.</param>
        /// <param name="staffDataSet">The staff data set.</param>
        /// <param name="governingBodyDataSet">The governing body data set.</param>
        /// <param name="educatorDataSet">The teacher data set.</param>
        void SetData(ICollection<Learner> learnerDataSet, ICollection<OtherStaff> staffDataSet, ICollection<GoverningBody> governingBodyDataSet, ICollection<Educator> educatorDataSet);

        /// <summary>
        /// Shows the form.
        /// </summary>
        void ShowForm();
    }
}
