namespace SchoolDataImporter.Models
{
    /// <summary>
    /// Model containing the Query Statements for each of the elements to query.
    /// </summary>
    public class QueryStatements
    {
        /// <summary>
        /// The query statement to fetch learners from the database.
        /// </summary>
        public string Learner { get; set; }

        /// <summary>
        /// The query statement to fetch teachers from the database.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// The query statement to fetch other staff members from the database.
        /// </summary>
        public string OtherStaff { get; set; }

        /// <summary>
        /// The query statement to fetch the governing body from the database.
        /// </summary>
        public string GoverningBody { get; set; }
    }
}
