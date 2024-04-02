using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using SchoolDataImporter.Enums;
using System.Collections.Generic;

namespace SchoolDataImporter.Constants
{
    /// <summary>
    /// Constant values.
    /// </summary>
    public static class AppConstants
    {
        public static string UniqueIdentifierFieldName = "UniqueIdentifier";
        public static string Unassigned = "Not Applicable / Blank";

        public static string TypeCellName = "Category";
        public static string StaffTypeCellName = "Staff Type";
        public static string FirstNameCellName = "First Name";
        public static string LastNameCellName = "Last Name";
        public static string NickNameCellName = "Learner Nick Name";
        public static string MobileNumberCellName = "Cell. No.";
        public static string GenderCellName = "Gender";
        public static string StatusCellName = "Status";
        public static string GradeClassCellName = "Grade / Class";
        public static string BusRouteCellName = "Bus Route";
        public static string HouseCellName = "House";
        public static string HostelCellName = "Hostel";
        public static string GoverningBodyCellName = "Governing Body";
        public static string ChildInformationCellName = "Child Information";
        public static string ParentTypeCellName = "Parent Type";

        public static string[] ExcelExportColumnHeaders = new[] { "Name", "Mobile", "Merge1", "Merge2", "Merge3" };

        public static string[] ColumnNames = new[] { TypeCellName, StaffTypeCellName, FirstNameCellName, LastNameCellName, NickNameCellName, MobileNumberCellName, StatusCellName, GradeClassCellName, BusRouteCellName, HouseCellName, HostelCellName, GoverningBodyCellName, GenderCellName, ParentTypeCellName, ChildInformationCellName };
        /// <summary>
        /// The various learner statuses for lookup.
        /// </summary>
        public static IDictionary<string, string> LearnerStatuses = new Dictionary<string, string>
        {
            { "A", "Archived" },
            { "C", "Current" },
            { "F", "Future" }
        };

        public static Dictionary<FilterType, string> FilterEmptyValues = new Dictionary<FilterType, string>
        {
            { FilterType.Houses, "Not in a house" },
            { FilterType.BusRoutes, "Not in a bus route" },
            { FilterType.Hostels, "Not in a hostel" },
            { FilterType.GoverningBody, "Not Applicable / Blank" }
        };

        public static Dictionary<FilterCategory, FilterType[]> FilterTypesPerCategory = new Dictionary<FilterCategory, FilterType[]>
        {
            {
                FilterCategory.Default, new []
                {
                    FilterType.Gender,
                    FilterType.Status,
                    FilterType.Grades,
                    FilterType.BusRoutes,
                    FilterType.Houses,
                    FilterType.Hostels
                }
            },
            {
                FilterCategory.Staff, new []
                {
                    FilterType.Gender,
                    FilterType.Status,
                    FilterType.Staff
                }
            },
            {
                FilterCategory.GoverningBody, new []
                {
                    FilterType.Gender,
                    FilterType.Status,
                    FilterType.GoverningBody
                }
            }
        };
    }
}
