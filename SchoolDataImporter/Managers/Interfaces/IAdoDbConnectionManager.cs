using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataImporter.Managers.Interfaces
{
    /// <summary>
    /// Interface for a connection manager to an external DB file.
    /// </summary>
    public interface IAdoDbConnectionManager
    {
        /// <summary>
        /// Flag indicating if the connection is open.
        /// </summary>
        bool IsConnectionOpen { get; }

        /// <summary>
        /// Open a connection using a connection string asynchronously.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Flag indicating if the connection is opened successfully.</returns>
        Task<bool> OpenConnectionAsync(string connectionString, CancellationToken cancellationToken);

        /// <summary>
        /// Closes an open connection.
        /// </summary>
        /// <returns>A flag indicating if the connection was closed successfully.</returns>
        bool CloseConnection();

        /// <summary>
        /// Execute a query to the active connection asynchronously.
        /// </summary>
        /// <param name="sqlQuery">The query to execute.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A DB Reader.</returns>
        Task<DbDataReader> ExecuteQueryAsync(string sqlQuery, CancellationToken cancellationToken);

        /// <summary>
        /// Execute a non-query (EG: Inserts or updates) to the active connection asynchronously.
        /// </summary>
        /// <param name="sqlText">The query to execute.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The number of rows affected.</returns>
        Task<int> ExecuteNonQueryAsync(string sqlText, CancellationToken cancellationToken);
    }
}
