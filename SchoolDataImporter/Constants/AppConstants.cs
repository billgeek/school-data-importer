using System.Collections.Generic;

namespace SchoolDataImporter.Constants
{
    /// <summary>
    /// Constant values.
    /// </summary>
    public static class AppConstants
    {
        public static string UniqueIdentifierFieldName = "UniqueIdentifier";
        public static string Unassigned = "Unassigned";

        public static string TypeCellName = "Type";
        public static string StaffTypeCellName = "Staff Type";
        public static string FirstNameCellName = "First Name";
        public static string LastNameCellName = "Last Name";
        public static string MobileNumberCellName = "Cell. No.";
        public static string GenderCellName = "Gender";
        public static string StatusCellName = "Status";
        public static string GradeClassCellName = "Grade / Class";
        public static string BusRouteCellName = "Bus Route";
        public static string HouseCellName = "House";
        public static string HostelCellName = "Hostel";
        public static string GoverningBodyCellName = "Governing Body";
        public static string OtherStaffTypeCellName = "Other Staff Type";
        public static string ChildInformationCellName = "Child Information";
        public static string ParentTypeCellName = "Parent Type";

        public static string[] ExcelExportColumnHeaders = new[] { "Name", "Mobile", "Merge1", "Merge2", "Merge3" };

        public static string[] ColumnNames = new[] { TypeCellName, StaffTypeCellName, FirstNameCellName, LastNameCellName, MobileNumberCellName, StatusCellName, GradeClassCellName, BusRouteCellName, HouseCellName, HostelCellName, GoverningBodyCellName, OtherStaffTypeCellName, GenderCellName, ParentTypeCellName, ChildInformationCellName };
        /// <summary>
        /// The various learner statuses for lookup.
        /// </summary>
        public static IDictionary<string, string> LearnerStatuses = new Dictionary<string, string>
        {
            { "A", "Archived" },
            { "C", "Current" },
            { "F", "Future" }
        };
    }
}
