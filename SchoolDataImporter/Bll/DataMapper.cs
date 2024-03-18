using SchoolDataImporter.Bll.Interfaces;
using SchoolDataImporter.Constants;
using SchoolDataImporter.Managers.Interfaces;
using SchoolDataImporter.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace SchoolDataImporter.Bll
{
    public class DataMapper : IDataMapper
    {
        private readonly IConfigurationManager _configManager;
        private readonly ILogger _logger;
        
        public DataMapper(IConfigurationManager configManager, ILogger logger)
        {
            _configManager = configManager ?? throw new ArgumentNullException(nameof(configManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public TModelType MapDataModelFromDbReader<TModelType>(DbDataReader dataReader) where TModelType : BaseModel
        {
            var targetType = typeof(TModelType).UnderlyingSystemType;
            _logger.Debug("Call to MapDataModelFromDbReader for type {typeName}", targetType.Name);

            var properties = targetType.GetProperties();

            var instance = (TModelType)Activator.CreateInstance(targetType);
            var dataMapping = instance.GetDataRowMap();

            foreach (var property in dataMapping)
            {
                _logger.Debug("In loop for property {propertyName}", property.Key);
                var ordinal = dataReader.GetOrdinal(property.Key);
                _logger.Debug("Processing column {ordinal} : {columnName}", ordinal, dataReader.GetName(ordinal));

                if (ordinal == -1)
                {
                    _logger.Warning("Could not find field \"{fieldName}\" in the data row for type \"{typeName}\"", property.Key, targetType.Name);
                    continue;
                }

                var currentProperty = properties.FirstOrDefault(p => p.Name.Equals(property.Value, StringComparison.InvariantCultureIgnoreCase));
                if (currentProperty == null)
                {
                    _logger.Warning("Could not find property \"{propertyName}\" in type \"{typeName}\"", property.Value, targetType.Name);
                    continue;
                }

                try
                {
                    if (currentProperty.PropertyType == typeof(string))
                    {
                        _logger.Debug("Mapping value for property {propertyName} by string", currentProperty.Name);
                        currentProperty.SetValue(instance, dataReader.GetValue(ordinal).ToString());
                    }
                    else if (currentProperty.PropertyType == typeof(bool))
                    {
                        var value = dataReader.GetValue(ordinal).ToString();

                        // test for 0 or 1 - these cannot be parsed through "TryParse"
                        if (value.Length == 1)
                        {
                            _logger.Debug("Mapping single digit boolean value for property {propertyName}", currentProperty.Name);
                            currentProperty.SetValue(instance, value == "1");
                        }
                        else
                        {
                            if (bool.TryParse(value, out bool valueResult))
                            {
                                _logger.Debug("Mapping value for property {propertyName} by boolean", currentProperty.Name);
                                currentProperty.SetValue(instance, dataReader.GetBoolean(ordinal));
                            }
                            else
                            {
                                _logger.Warning("Could not parse value {value} to boolean", value);
                            }
                        }

                    }
                    else
                    {
                        _logger.Warning("The field \"{fieldName}\" is not a string or a boolean and is not implemented.", property.Key);
                    }
                }
                catch (Exception e)
                {
                    _logger.Warning(e, "Could not map property due to an exception");
                    // Swallow error - we want to continue processing!
                }
            }

            return instance;
        }

        public string[] GetModelRowData(BaseModel model)
        {
            var dataRowDictionary = model.GetModelMap();
            var result = new List<string>();

            foreach (var item in _configManager.Settings.GetDataGridColumns())
            {
                if (dataRowDictionary.ContainsKey(item.Value))
                {
                    result.Add(dataRowDictionary[item.Value]);
                }
                else
                {
                    result.Add(string.Empty);
                }
            }
            result.Add(model.GetItemIdentifier());
            return result.ToArray();
        }
    }
}