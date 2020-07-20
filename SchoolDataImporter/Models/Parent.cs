using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class Parent : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public string MobilePhoneCode { get; set; }
        public string MobilePhoneNumber { get; set; }

        public Spouse Spouse { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "pName", "FirstName" },
                { "pVan", "LastName" },
                { "pIDno", "IdNumber" },
                { "pGender", "Gender" },
                { "pSellK", "MobilePhoneCode" },
                { "pSell", "MobilePhoneNumber" }
            };
        }
    }
}