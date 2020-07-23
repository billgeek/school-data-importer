using System.Collections.Generic;

namespace SchoolDataImporter.Constants
{
    /// <summary>
    /// Constant values.
    /// </summary>
    public static class AppConstants
    {
        /// <summary>
        /// The default MS-Access DB connection string.
        /// </summary>
        public static string DefaultConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbFileName};Jet OLEDB:Database Password={dbPassword}";

        /// <summary>
        /// The columns to display on the data grid.
        /// </summary>
        public static Dictionary<int, string> DataGridColumns = new Dictionary<int, string>
        {
            { 0, "Type" },
            { 1, "Staff Type"},
            { 2, "First Name"},
            { 3, "Last Name"},
            { 4, "Cell. No."},
            { 5, "Gender"},
            { 6, "Status"},
            { 7, "Grade / Class"},
            { 8, "House"},
            { 9, "Hostel"},
            { 10, "Category / Gov. Body Type" }
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
