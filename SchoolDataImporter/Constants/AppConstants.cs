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
        public static string HouseCellName = "House";
        public static string HostelCellName = "Hostel";
        public static string GoverningBodyCellName = "Governing Body";
        public static string OtherStaffTypeCellName = "Other Staff Type";
        public static string ChildInformationCellName = "Child Information";
        public static string ParentTypeCellName = "Parent Type";

        /// <summary>
        /// The columns to display on the data grid.
        /// </summary>
        public static Dictionary<int, string> DataGridColumns = new Dictionary<int, string>
        {
            { 0, TypeCellName },
            { 1, StaffTypeCellName},
            { 2, FirstNameCellName},
            { 3, LastNameCellName},
            { 4, MobileNumberCellName},
            { 5, StatusCellName},
            { 6, GradeClassCellName},
            { 7, HouseCellName},
            { 8, HostelCellName},
            { 9, GoverningBodyCellName},
            { 10, OtherStaffTypeCellName },
            { 11, GenderCellName},
            { 12, ParentTypeCellName },
            { 13, ChildInformationCellName },
        };

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
