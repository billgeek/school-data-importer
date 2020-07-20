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
        Task<ICollection<Learner>> ReadLearnersAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken);

        /// <summary>
        /// Reads the staff from the Database asynchronously.
        /// </summary>
        /// <param name="targetDatabase">The target database object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of Staff members.</returns>
        Task<ICollection<OtherStaff>> ReadStaffDataAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken);

        /// <summary>
        /// Reads the educators from the Database asynchronously.
        /// </summary>
        /// <param name="targetDatabase">The target database object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of Educators.</returns>
        Task<ICollection<Educator>> ReadEducatorsAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken);

        /// <summary>
        /// Reads the governing body from the Database asynchronously.
        /// </summary>
        /// <param name="targetDatabase">The target database object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of Governing body members.</returns>
        Task<ICollection<GoverningBody>> ReadGoverningBodyAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken);
    }
}
