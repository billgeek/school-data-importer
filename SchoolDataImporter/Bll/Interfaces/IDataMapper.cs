using SchoolDataImporter.Models;
using System.Data.Common;

namespace SchoolDataImporter.Bll.Interfaces
{
    public interface IDataMapper
    {
        TModelType MapDataModelFromDbReader<TModelType>(DbDataReader dataReader) where TModelType : BaseModel;
    }
}
