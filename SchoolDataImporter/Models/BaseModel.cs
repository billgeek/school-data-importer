using System;
using System.Collections.Generic;

namespace SchoolDataImporter.Models
{
    /// <summary>
    /// The base model which all other models that are mapped from the DB are to inherit from.
    /// </summary>
    public abstract class BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneCode { get; set; }
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// The mapping between the row on the Database and the Object Model.
        /// </summary>
        /// <returns>A dictionary (key value pair) where the key is the DB column name and the value is the property on the model.</returns>
        public abstract IDictionary<string, string> GetDataRowMap();

        public abstract string[] GetDataRow();
    }
}