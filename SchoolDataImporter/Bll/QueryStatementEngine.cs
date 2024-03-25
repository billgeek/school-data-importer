using Newtonsoft.Json;
using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataImporter.Bll
{
    public class QueryStatementEngine : IQueryStatementEngine
    {
        private readonly IConfigurationManager _configManager;
        private readonly ILogger _logger;

        public QueryStatementEngine(IConfigurationManager configManager, ILogger logger)
        {
            _configManager = configManager ?? throw new ArgumentNullException(nameof(configManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<QueryStatements> FetchQueryStatementsAsync(CancellationToken cancellationToken)
        {
            _logger.Debug("Call to FetchQueryStatementsAsync");
            cancellationToken.ThrowIfCancellationRequested();

            var apiUrl = _configManager.QueryApiUri;

            try
            {
                if (!_configManager.FetchRemoteQueries)
                {
                    _logger.Information("Configuratino set to NOT fetch remote queries. Using local queries instead.");
                    return FetchQueryStatementsLocally();
                }

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);

                HttpResponseMessage response;
                using (_logger.BeginTimedOperation("Call Remote API to fetch queries"))
                {
                    response = await client.SendAsync(request);
                }
                response.EnsureSuccessStatusCode();

                string responseData;
                using (_logger.BeginTimedOperation("Serializing returned queries"))
                {
                    responseData = await response.Content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<QueryStatements>(responseData);
            }
            catch (Exception e)
            {
                _logger.Error(e, "Could not retrieve the queries from the server; Fallback to local version");
                return FetchQueryStatementsLocally();
            }
        }

        public QueryStatements FetchQueryStatementsLocally()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fileName = Path.Combine(appPath, "DefaultQueries.json");

            var fi = new FileInfo(fileName);
            if (!fi.Exists)
            {
                // Throw exception
            }

            var fileContent = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<QueryStatements>(fileContent);
        }
    }
}
