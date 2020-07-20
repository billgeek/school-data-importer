using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    /// <summary>
    /// Model for Application Settings.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// The API where queries are retrieved from.
        /// </summary>
        public string QueryApiUri { get; set; }

        /// <summary>
        /// A list of databases that have been used.
        /// </summary>
        public List<AppSettingsDatabase> Databases { get; set; }
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
