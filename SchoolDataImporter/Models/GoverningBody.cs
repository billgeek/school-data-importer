using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class GoverningBody : BaseModel
    {
        public string GoverningBodyCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneNumber { get; set; }
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
    }
}
