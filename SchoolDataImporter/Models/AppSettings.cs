using SchoolDataImporter.Constants;
using System.Collections.Generic;
using System.Linq;

namespace SchoolDataImporter.Models
{
    /// <summary>
    /// Model for Application Settings.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Flag determining if queries should be fetched from a remote URL.
        /// </summary>
        public bool FetchRemoteQueries { get; set; }

        /// <summary>
        /// The API where queries are retrieved from.
        /// </summary>
        public string QueryApiUri { get; set; }

        /// <summary>
        /// A list of databases that have been used.
        /// </summary>
        public List<AppSettingsDatabase> Databases { get; set; }

        public string[] ColumnNames { get; set; }

        public Dictionary<int, string> GetDataGridColumns()
        {
            var defaultCols = AppConstants.ColumnNames;
            var missingCols = defaultCols.Except(ColumnNames);

            if (missingCols.Any())
            {
                var newCols = ColumnNames.ToList();
                newCols.AddRange(missingCols);
                ColumnNames = newCols.ToArray();
            }

            return ColumnNames.Select((value, index) => new { value, index })
                .ToDictionary(p => p.index, p => p.value);
        }
    }
    
    public class AppSettingsDatabase
    {
        /// <summary>
        /// The connection string to the target database.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The file name of the database file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The password to connect to the database.
        /// </summary>
        /// <remarks>
        /// This value is encrypted with a key specific to the target machine.
        /// </remarks>
        public string Password { get; set; }
    }
}
