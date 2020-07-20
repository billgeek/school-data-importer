using SchoolDataImporter.Exceptions;
using SchoolDataImporter.Managers.Interfaces;
using Serilog;
using System;
using System.Data.Common;
using System.Data.OleDb;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataImporter.Managers
{
    /// <summary>
    /// The ADO DB Connection Manager.
    /// </summary>
    /// <inheritdoc />
    public class AdoDbConnectionManager : IAdoDbConnectionManager, IDisposable
    {
        /// <inheritdoc />
        public bool IsConnectionOpen
        {
            get
            {
                return (_dbConnection?.State ?? System.Data.ConnectionState.Closed) == System.Data.ConnectionState.Open;
            }
        }

        private readonly ILogger _logger;

        private OleDbConnection _dbConnection = null;

        public AdoDbConnectionManager(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc />
        public bool CloseConnection()
        {
            _logger.Debug("Call to CloseConnection");

            if (IsConnectionOpen)
            {
                try
                {
                    _dbConnection.Close();
                }
                catch(Exception e)
                {
                    _logger.Error(e, "Could not close connection to DB File");
                    throw;
                }
            }

            return true;
        }
        
        /// <inheritdoc />
        public Task<int> ExecuteNonQueryAsync(string sqlText, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ExecuteNonQueryAsync with sql command {sqlCommand}", sqlText);
            cancellationToken.ThrowIfCancellationRequested();

            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<DbDataReader> ExecuteQueryAsync(string sqlQuery, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ExecuteQueryAsync with sql command {sqlCommand}", sqlQuery);
            cancellationToken.ThrowIfCancellationRequested();

            // Ensure we have a connection that is open
            if (!IsConnectionOpen)
            {
                var ex = new NoActiveConnectionException("Call to ExecuteQueryAsync without an active connection is not permitted");
                _logger.Warning(ex, "Please open a connection before attempting to execute a query");
                throw ex;
            }

            // Create and execute the command
            var dbCommand = _dbConnection.CreateCommand();
            dbCommand.CommandText = sqlQuery;
            DbDataReader reader;
            using (_logger.BeginTimedOperation("Execute DB Query"))
            {
                try
                {
                    reader = await dbCommand.ExecuteReaderAsync(cancellationToken);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Could not create a data reader");
                    throw;
                }

                return reader;
            }
        }

        /// <inheritdoc />
        public async Task<bool> OpenConnectionAsync(string connectionString, CancellationToken cancellationToken)
        {
            var start = DateTime.UtcNow;

            string logConnStr = connectionString;
            var pwdIdx = connectionString.IndexOf("Database Password=", StringComparison.InvariantCultureIgnoreCase);
            if (pwdIdx > -1)
            {
                logConnStr = $"{connectionString.Substring(0, pwdIdx)}*****";
            }

            _logger.Debug("Call to OpenConnectionAsync with connection string {connectionString}", logConnStr);
            cancellationToken.ThrowIfCancellationRequested();

            using (_logger.BeginTimedOperation("Create DB Connection"))
            {
                try
                {
                    _dbConnection = new OleDbConnection(connectionString);
                    await _dbConnection.OpenAsync(cancellationToken);
                    return true;
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Could not open a connection to the desired file with the provided information.");
                    return false;
                }
            }
        }

        public void Dispose()
        {
            if (_dbConnection != null && _dbConnection.State == System.Data.ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Dispose();
        }
    }
}