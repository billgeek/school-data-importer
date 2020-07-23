using System;

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
