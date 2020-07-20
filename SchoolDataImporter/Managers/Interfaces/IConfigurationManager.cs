using SchoolDataImporter.Models;

namespace SchoolDataImporter.Managers.Interfaces
{
    public interface IConfigurationManager
    {
        QueryStatements Queries { get; set; }
        string QueryApiUri { get; set; }
        AppSettings Settings { get; set; }
        void StoreConfiguration();
    }
}
