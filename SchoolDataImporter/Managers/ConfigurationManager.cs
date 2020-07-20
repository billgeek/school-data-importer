using Newtonsoft.Json;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SchoolDataImporter.Managers
{
    public class ConfigurationManager : IConfigurationManager
    {
        public QueryStatements Queries { get; set; }
        public AppSettings Settings { get; set; }
        public string QueryApiUri { get; set; }

        private readonly ILogger _logger;

        public ConfigurationManager(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            // Retrieve the "default" from the app config
            QueryApiUri = System.Configuration.ConfigurationManager.AppSettings["QueryApiUri"];

            ReadConfiguration();
        }

        private void ReadConfiguration()
        {
            _logger.Debug("Call to ReadConfiguration");

            var settingsFile = GetConfigFileName();
            var fi = new FileInfo(settingsFile);
            if (!fi.Exists)
            {
                _logger.Warning("Settings file not found in application path. New settings file will be created when required.");
                Settings = new AppSettings
                {
                    QueryApiUri = QueryApiUri,
                    Databases = new List<AppSettingsDatabase>()
                };
                return;
            }

            Settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(settingsFile));
        }

        public void StoreConfiguration()
        {
            _logger.Debug("Call to StoreConfiguration");

            var settingsFile = GetConfigFileName();
            File.WriteAllText(settingsFile, JsonConvert.SerializeObject(Settings));
        }

        private string DecryptDbPassword(string storedPassword)
        {
            return storedPassword;
        }

        private string EncryptDbPassword(string toEncrypt)
        {
            return toEncrypt;
        }

        private string GetConfigFileName()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(appPath, "settings.json");
        }
    }
}