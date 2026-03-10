using MiniExcelLibs;
using SchoolDataImporter.Bll.Interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;

namespace SchoolDataImporter.Bll
{
    public class ExcelEngine : IExcelEngine
    {
        private readonly ILogger _logger;

        public ExcelEngine(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public byte[] ExportResultsToExcel(IList<string> columnHeadings, List<List<string>> exportData, string sheetName)
        {
            _logger.Information("Call to ExportResultsToExcelAsync with sheetName {sheetName}", sheetName);
            using (var ms = new MemoryStream())
            {

                // Combine column headers + data into a single enumerable
                var allRows = new List<IDictionary<string, object>>();

                foreach (var row in exportData)
                {
                    var dict = new Dictionary<string, object>();
                    for (int i = 0; i < columnHeadings.Count; i++)
                    {
                        // If row has fewer columns, leave blank
                        object value = i < row.Count ? row[i] : null;
                        dict[columnHeadings[i]] = value;
                    }
                    allRows.Add(dict);
                }

                // MiniExcel writes the data to the stream
                // sheetName parameter is optional
                ms.Position = 0;
                MiniExcel.SaveAs(ms, allRows, sheetName: sheetName);

                return ms.ToArray();
            }
        }
    }
}