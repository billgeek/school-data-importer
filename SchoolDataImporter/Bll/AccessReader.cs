using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
            _logger.Debug("Call to ReadLearnersAsync");
            cancellationToken.ThrowIfCancellationRequested();

            return await ReadDataSetAsync<Learner>(targetDatabase, cancellationToken);
        }

        public async Task<ICollection<OtherStaff>> ReadStaffDataAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadStaffDataAsync");
            cancellationToken.ThrowIfCancellationRequested();

            return await ReadDataSetAsync<OtherStaff>(targetDatabase, cancellationToken);
        }

        public async Task<ICollection<Educator>> ReadEducatorsAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadEducatorsAsync");
            cancellationToken.ThrowIfCancellationRequested();

            return await ReadDataSetAsync<Educator>(targetDatabase, cancellationToken);
        }

        public async Task<ICollection<GoverningBody>> ReadGoverningBodyAsync(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken)
        {
            _logger.Debug("Call to ReadGoverningBodyAsync");
            cancellationToken.ThrowIfCancellationRequested();

            return await ReadDataSetAsync<GoverningBody>(targetDatabase, cancellationToken);
        }

        private async Task<ICollection<TReturnType>> ReadDataSetAsync<TReturnType>(AppSettingsDatabase targetDatabase, CancellationToken cancellationToken) where TReturnType : BaseModel
        {
            _logger.Debug("Call to ReadDataSetAsync with target database {fileName}", targetDatabase.FileName);
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

            DbDataReader reader;
            if (typeof(TReturnType) == typeof(Learner))
            {
                reader = await _dbManager.ExecuteQueryAsync(statements.Learner, cancellationToken);
            }
            else if (typeof(TReturnType) == typeof(OtherStaff))
            {
                reader = await _dbManager.ExecuteQueryAsync(statements.OtherStaff, cancellationToken);
            }
            else if (typeof(TReturnType) == typeof(GoverningBody))
            {
                reader = await _dbManager.ExecuteQueryAsync(statements.GoverningBody, cancellationToken);
            }
            else if (typeof(TReturnType) == typeof(Educator))
            {
                reader = await _dbManager.ExecuteQueryAsync(statements.Teacher, cancellationToken);
            }
            else
            {
                var ex = new Exception("Invalid return type specified for AccessReader.readDataSetAsync");
                _logger.Error(ex, "Could not process data type.");
                throw ex;
            }

            var result = new List<TReturnType>();
            var rowCounter = 0;

            using (_logger.BeginTimedOperation("Read Data Set from DB"))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        _logger.Debug("Mapping Learner row {rowNumber}", rowCounter);

                        var element = _dataMapper.MapDataModelFromDbReader<TReturnType>(reader);

                        // Learner is the exception to the case here - it has multiple child model properties that are mapped
                        if (element is Learner)
                        {
                            var learner = element as Learner;

                            // We also need to map this current row to the learner's parent model
                            learner.Parent = _dataMapper.MapDataModelFromDbReader<Parent>(reader);

                            // We also need to map this current row to the learner's parent's spouse model
                            learner.Parent.Spouse = _dataMapper.MapDataModelFromDbReader<Spouse>(reader);
                        }

                        // Now we can add it to the collection!
                        result.Add(element);
                    }
                }
            }
            return result;
        }
    }
}
