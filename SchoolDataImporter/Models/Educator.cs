using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class Educator : BaseModel
    {
        public string EducatorCode { get; set; }
        public string DateOfBirth { get; set; }
        public string HomeLanguage { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "eKode", "EducatorCode" },
                { "eName", "FirstName" },
                { "eVan", "LastName" },
                { "eGDatum", "DateOfBirth" },
                { "eSellK", "MobilePhoneCode" },
                { "eSell", "MobilePhoneNumber" },
                { "eHTaal", "HomeLanguage" },
                { "eGender", "Gender" },
                { "eStatus", "Status" }
            };
        }
    }
}
