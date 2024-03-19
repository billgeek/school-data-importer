using SchoolDataImporter.Constants;
using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class Spouse : BaseModel
    {
        public string Gender { get; set; }
        public string IdNumber { get; set; }

        // From the parent model
        public string LearnerCode { get; set; }
        public string Status { get; set; }
        public string GradeOrClass { get; set; }
        public string House { get; set; }
        public string Hostel { get; set; }
        public string ChildName { get; set; }
        public string BusRouteName { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "Spouse", "LastName" },
                { "sGender", "Gender" },
                { "sName", "FirstName" },
                { "sIDno", "IdNumber" },
                { "sSell", "MobilePhoneNumber" },
                { "pStatus", "Status" },
                { "BusRouteName", "BusRouteName" }
            };
        }

        public override string GetItemIdentifier()
        {
            return $"Spouse/{LearnerCode}";
        }

        public override IDictionary<string, string> GetModelMap()
        {
            return new Dictionary<string, string>
            {
                { AppConstants.TypeCellName, "Parent" },
                { AppConstants.FirstNameCellName, FirstName },
                { AppConstants.LastNameCellName, LastName },
                { AppConstants.MobileNumberCellName, MobilePhoneNumber },
                { AppConstants.GenderCellName, Gender },
                { AppConstants.StatusCellName, string.IsNullOrWhiteSpace(Status) ? "Unassigned" : AppConstants.LearnerStatuses[Status] },
                { AppConstants.GradeClassCellName, GradeOrClass },
                { AppConstants.HouseCellName, House },
                { AppConstants.HostelCellName, Hostel },
                { AppConstants.ChildInformationCellName, ChildName },
                { AppConstants.BusRouteCellName, BusRouteName },
                { AppConstants.ParentTypeCellName, "Spouse" }
            };
        }
    }
}
