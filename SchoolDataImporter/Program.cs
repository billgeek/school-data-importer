using Microsoft.Extensions.DependencyInjection;
using SchoolDataImporter.Bll;
using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Managers;
using SchoolDataImporter.Forms;
using Serilog;
using Serilog.Core;
using System;
using System.Windows.Forms;
using SchoolDataImporter.Managers.Interfaces;

namespace SchoolDataImporter
{
    static class Program
    {
        /// <summary>
        /// The Service Provider for resolving dependencies.
        /// </summary>
        private static IServiceProvider _serviceProvider;

        private static Logger _logger;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Setup dependency injection
            ConfigureServices();

            // Resolve dependencies
            var queryEngine = _serviceProvider.GetService<IQueryStatementEngine>();
            var accessReader = _serviceProvider.GetService<IAccessReader>();
            var stringEncryption = _serviceProvider.GetService<IStringEncryption>();
            var configManager = _serviceProvider.GetService<IConfigurationManager>();
            var dbManager = _serviceProvider.GetService<IAdoDbConnectionManager>();
            var logger = _serviceProvider.GetService<ILogger>();

            // Show the form
            _logger.Information("Application Loaded and Ready");
            Application.Run(new fMain(queryEngine, accessReader, stringEncryption, configManager, dbManager, logger));
        }

        private static void ConfigureServices()
        {
            // Create the service collection
            var services = new ServiceCollection();

            // Setup logger
            _logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();

            Log.Logger = _logger;
            _logger.Information("Starting Application");

            services.AddSingleton(typeof(ILogger), _logger);

            // Setup dependencies: Business Logic Layer (BLL)
            services.AddTransient<IAccessReader, AccessReader>();
            services.AddTransient<IDataMapper, DataMapper>();
            services.AddTransient<IQueryStatementEngine, QueryStatementEngine>();
            services.AddTransient<IStringEncryption, StringEncryption>();

            // Setup dependencies: Managers
            services.AddTransient<IConfigurationManager, ConfigurationManager>();
            services.AddTransient<IAdoDbConnectionManager, AdoDbConnectionManager>();

            // Create the service provider
            _serviceProvider = services.BuildServiceProvider();
            _logger.Information("Services Configured Successfully");
        }
    }
}
