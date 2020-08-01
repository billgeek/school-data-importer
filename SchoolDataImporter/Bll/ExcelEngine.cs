using OfficeOpenXml;
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

            byte[] result;
            using (var ms = new MemoryStream())
            {
                using (var pkg = new ExcelPackage(ms))
                {
                    var sheet = pkg.Workbook.Worksheets.Add(sheetName);

                    // Render columns
                    for (var i = 0; i < columnHeadings.Count; i++)
                    {
                        var colName = columnHeadings[i];
                        sheet.SetValue(1, i + 1, colName);
                    }

                    // Render data
                    for (var i = 0; i < exportData.Count; i++)
                    {
                        var dataRow = exportData[i];
                        for (var j = 0; j < dataRow.Count; j++)
                        {
                            sheet.SetValue(i + 2, j + 1, dataRow[j]);
                        }
                    }

                    pkg.Save();
                    result = ms.ToArray();
                }
            }

            return result;
        }
    }
}
