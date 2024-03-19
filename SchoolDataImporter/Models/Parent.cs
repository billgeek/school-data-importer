using SchoolDataImporter.Constants;
using System.Collections.Generic;
using System.Text;

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
        public string GradeOrClass { get; set; }
        public string House { get; set; }
        public string Hostel { get; set; }
        public string ChildName { get; set; }
        public string BusRouteName { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "pName", "FirstName" },
                { "pVan", "LastName" },
                { "pIDno", "IdNumber" },
                { "pGender", "Gender" },
                { "pSellK", "MobilePhoneCode" },
                { "pSell", "MobilePhoneNumber" },
                { "pStatus", "Status" },
                { "BusRouteName", "BusRouteName" }
            };
        }

        public override string GetItemIdentifier()
        {
            return $"Parent/{LearnerCode}";
        }

        public override IDictionary<string, string> GetModelMap()
        {
            return new Dictionary<string, string>
            {
                { AppConstants.TypeCellName, "Parent" },
                { AppConstants.FirstNameCellName, FirstName },
                { AppConstants.LastNameCellName, LastName },
                { AppConstants.MobileNumberCellName, MobilePhoneNumber },
                { AppConstants.GenderCellName, Gender },
                { AppConstants.StatusCellName, string.IsNullOrWhiteSpace(Status) ? "Unassigned" : AppConstants.LearnerStatuses[Status] },
                { AppConstants.GradeClassCellName, GradeOrClass },
                { AppConstants.HouseCellName, House },
                { AppConstants.HostelCellName, Hostel },
                { AppConstants.ChildInformationCellName, ChildName },
                { AppConstants.BusRouteCellName, BusRouteName },
                { AppConstants.ParentTypeCellName, "Parent" }
            };
        }
    }
}