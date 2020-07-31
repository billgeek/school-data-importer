using SchoolDataImporter.Constants;
using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class OtherStaff : BaseModel
    {
        public string StaffCode { get; set; }
        public string DateOfBirth { get; set; }
        public string HomeLanguage { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string PersonnelCategory { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "eKode", "StaffCode" },
                { "eName", "FirstName" },
                { "eVan", "LastName" },
                { "eGDatum", "DateOfBirth" },
                { "eSellK", "MobilePhoneCode" },
                { "eSell", "MobilePhoneNumber" },
                { "eHTaal", "HomeLanguage" },
                { "eGender", "Gender" },
                { "eStatus", "Status" },
                { "eCat", "PersonnelCategory" }
            };
        }

        public override string GetItemIdentifier()
        {
            return $"Staff/Other/{StaffCode}";
        }

        public override IDictionary<string, string> GetModelMap()
        {
            return new Dictionary<string, string>
            {
                { AppConstants.TypeCellName, "Parent" },
                { AppConstants.StaffTypeCellName, "Other Staff" },
                { AppConstants.FirstNameCellName, FirstName },
                { AppConstants.LastNameCellName, LastName },
                { AppConstants.MobileNumberCellName, $"{MobilePhoneCode}{MobilePhoneNumber}" },
                { AppConstants.GenderCellName, Gender },
                { AppConstants.StatusCellName, string.IsNullOrWhiteSpace(Status) ? "Unassigned" : AppConstants.LearnerStatuses[Status] },
                { AppConstants.OtherStaffTypeCellName, PersonnelCategory }
            };
        }
    }
}
