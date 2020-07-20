using SchoolDataImporter.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataImporter.Bll.Interfaces
{
    public interface IAccessReader
    {
        /// <summary>
        /// Reads the learners from the Database asynchronously.
        /// </summary>
        /// <param name="targetDatabase">The target database object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of Learners.</returns>
        Task<List<Learner>> ReadLearnersAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken);
    }
}
