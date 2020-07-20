using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataImporter.Bll
{
    public class AccessReader : IAccessReader
    {
        private readonly IQueryStatementEngine _statementEngine;
        private readonly IAdoDbConnectionManager _dbManager;
        private readonly IStringEncryption _stringEncryption;
        private readonly IDataMapper _dataMapper;
        private readonly ILogger _logger;

        public AccessReader(IQueryStatementEngine statementEngine, IAdoDbConnectionManager dbManager, IStringEncryption stringEncryption, IDataMapper dataMapper, ILogger logger)
        {
            _statementEngine = statementEngine ?? throw new ArgumentNullException(nameof(statementEngine));
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
            _stringEncryption = stringEncryption ?? throw new ArgumentNullException(nameof(stringEncryption));
            _dataMapper = dataMapper ?? throw new ArgumentNullException(nameof(dataMapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ICollection<Learner>> ReadLearnersAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadLearnersAsync with target database {fileName}", targetDatabase.FileName);
            cancellationToken.ThrowIfCancellationRequested();

            var statements = await _statementEngine.FetchQueryStatementsAsync(cancellationToken);

            if (!_dbManager.IsConnectionOpen)
            {
                var connectionString = targetDatabase.ConnectionString
                    .Replace("{dbFileName}", targetDatabase.FileName)
                    .Replace("{dbPassword}", _stringEncryption.DecryptString(targetDatabase.Password));

                if (!await _dbManager.OpenConnectionAsync(connectionString, cancellationToken))
                {
                    var ex = new Exception("Could not connect to database");
                    _logger.Error(ex, "Database connection was unsuccessful.");
                    throw ex;
                }
            }

            var reader = await _dbManager.ExecuteQueryAsync(statements.Learner, cancellationToken);
            var result = new List<Learner>();
            var rowCounter = 0;

            using (_logger.BeginTimedOperation("Read Learners from DB"))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        _logger.Debug("Mapping Learner row {rowNumber}", rowCounter);

                        var learner = _dataMapper.MapDataModelFromDbReader<Learner>(reader);

                        // We also need to map this current row to the learner's parent model
                        learner.Parent = _dataMapper.MapDataModelFromDbReader<Parent>(reader);

                        // We also need to map this current row to the learner's parent's spouse model
                        learner.Parent.Spouse = _dataMapper.MapDataModelFromDbReader<Spouse>(reader);

                        // Now we can add it to the collection!
                        result.Add(learner);
                    }
                }
            }
            return result;
        }

        public async Task<ICollection<Staff>> ReadStaffDataAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken)
        {
            // throw new NotImplementedException();
            return new List<Staff>();
        }
    }
}
