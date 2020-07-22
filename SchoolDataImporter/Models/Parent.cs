using SchoolDataImporter.Constants;
using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class Parent : BaseModel
    {
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public Spouse Spouse { get; set; }

        // From the parent model
        public string LearnerCode { get; set; }
        public string Status { get; set; }

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

        public override string[] GetDataRow()
        {
            return new string[]
                {
                    "Parent",
                    string.Empty,
                    FirstName,
                    LastName,
                    $"{MobilePhoneCode}{MobilePhoneNumber}",
                    Gender,
                    string.IsNullOrWhiteSpace(Status) ? "Future" : Formats.LearnerStatuses[Status],
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    $"Parent/{LearnerCode}"
                };
        }
    }
}