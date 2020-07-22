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

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "Spouse", "LastName" },
                { "sGender", "Gender" },
                { "sName", "FirstName" },
                { "sIDno", "IdNumber" },
                { "sSell", "MobilePhoneNumber" }
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
                "Spouse",
                $"Spouse/{LearnerCode}"
            };
        }
    }
}
