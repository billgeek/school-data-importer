using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataImporter.Exceptions
{
    public class NoActiveConnectionException : Exception
    {
        public NoActiveConnectionException()
        {
        }

        public NoActiveConnectionException(string message) : base(message)
        {
        }
    }
}
