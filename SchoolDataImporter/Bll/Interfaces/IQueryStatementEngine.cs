using SchoolDataImporter.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataImporter.Bll.Interfaces
{
    public interface IQueryStatementEngine
    {
        /// <summary>
        /// Retrieve the query statements from the server asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The populated query statement object.</returns>
        Task<QueryStatements> FetchQueryStatementsAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Fetches the query statements from a local file.
        /// </summary>
        /// <returns>The populated query statement object.</returns>
        QueryStatements FetchQueryStatementsLocally();
    }
}
