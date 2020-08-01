using System.Collections.Generic;

namespace SchoolDataImporter.Bll.Interfaces
{
    public interface IExcelEngine
    {
        byte[] ExportResultsToExcel(IList<string> columnHeadings, List<List<string>> exportData, string sheetName);
    }
}