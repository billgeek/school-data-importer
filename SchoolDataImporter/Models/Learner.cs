using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    public class Learner : BaseModel
    {
        public string LearnerCode { get; set; }
        public string NickName { get; set; }
        public string DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public string DateLeft { get; set; }
        public string HostelName { get; set; }
        public bool IsHostel { get; set; }
        public string Status { get; set; }
        public string Grade { get; set; }
        public string Class { get; set; }
        public string House { get; set; }
        public Parent Parent { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "lKode", "LearnerCode" },
                { "lVan", "LastName" },
                { "lName" ,"FirstName" },
                { "lGDatum", "DateOfBirth" },
                { "lIDno", "IdNumber" },
                { "lGender", "Gender" },
                { "lSellK", "MobilePhoneCode" },
                { "lSell", "MobilePhoneNumber" },
                { "dWeg", "DateLeft" },
                { "kNaam", "HostelName" },
                { "isHostel", "IsHostel" },
                { "lStatus", "Status" },
                { "Graad", "Grade" },
                { "Klas", "Class" },
                { "House", "House" }
            };
        }
    }
}
