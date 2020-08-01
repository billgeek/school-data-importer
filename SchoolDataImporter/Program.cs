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
using SchoolDataImporter.Forms.Interfaces;
using System.Collections.Generic;
using System.Threading;

namespace SchoolDataImporter
{
    static class Program
    {
        /// <summary>
        /// The Service Provider for resolving dependencies.
        /// </summary>
        private static IServiceProvider _serviceProvider;

        private static Logger _logger;

        public static ApplicationContext AppContext;

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

            // Resolve the main form from the service collection
            var mainForm = _serviceProvider.GetService<IMain>();

            // Show the form
            _logger.Information("Application Loaded and Ready");

            AppContext = new ApplicationContext((Form)mainForm);
            Application.Run(AppContext);
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

            // Setup dependencies: UI
            services.AddTransient<IMain, fMain>();

            services.AddTransient<IExportData, fRenderData>();
            // services.AddTransient<IExportData, fTest>();

            // Setup dependencies: Business Logic Layer (BLL)
            services.AddTransient<IExcelEngine, ExcelEngine>();
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
