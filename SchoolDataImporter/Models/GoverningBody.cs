using SchoolDataImporter.Constants;
using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class GoverningBody : BaseModel
    {
        public string GoverningBodyCode { get; set; }
        public string HomeLanguage { get; set; }
        public string Gender { get; set; }
        public string TypeOfMember { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "eKode", "GoverningBodyCode" },
                { "eName", "FirstName" },
                { "eVan", "LastName" },
                { "eSell", "MobilePhoneNumber" },
                { "eHTaal", "HomeLanguage" },
                { "eGender", "Gender" },
                { "eCat", "TypeOfMember" }
            };
        }

        public override string GetItemIdentifier()
        {
            return $"Staff/GoverningBody/{GoverningBodyCode}";
        }

        public override IDictionary<string, string> GetModelMap()
        {
            return new Dictionary<string, string>
            {
                { AppConstants.TypeCellName, "Staff" },
                { AppConstants.StaffTypeCellName, "Governing Body" },
                { AppConstants.FirstNameCellName, FirstName },
                { AppConstants.LastNameCellName, LastName },
                { AppConstants.MobileNumberCellName, MobilePhoneNumber },
                { AppConstants.GenderCellName, Gender },
                { AppConstants.StatusCellName, "Current" },
                { AppConstants.GoverningBodyCellName, TypeOfMember },
                { AppConstants.BusRouteCellName, string.Empty },
            };
        }
    }
}
