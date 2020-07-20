using Newtonsoft.Json;
using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Net.Http;
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
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);

            try
            {
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
                _logger.Error(e, "Could not retrieve the queries from the server.");
                throw;
            }
        }
    }
}
