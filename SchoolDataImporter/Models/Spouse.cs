using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class Spouse : BaseModel
    {
        public string Gender { get; set; }
        public string IdNumber { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "Spouse", "LastName" },
                { "sGender","Gender" },
                { "sName","FirstName" },
                { "sIDno", "IdNumber" },
                { "sSell","MobilePhoneNumber" }
            };
        }
    }
}
