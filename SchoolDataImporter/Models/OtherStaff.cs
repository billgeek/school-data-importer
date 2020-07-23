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

        public override string[] GetDataRow()
        {
            return new string[]
            {
                "Staff",
                "Other Staff",
                FirstName,
                LastName,
                $"{MobilePhoneCode}{MobilePhoneNumber}",
                Gender,
                string.IsNullOrWhiteSpace(Status) ? "Unassigned" : AppConstants.LearnerStatuses[Status],
                string.Empty,
                string.Empty,
                string.Empty,
                PersonnelCategory,
                $"Staff/Other/{StaffCode}"
            };
        }
    }
}
