using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataImporter.Bll.Interfaces
{
    public interface IStringEncryption
    {
        string EncryptString(string toEncrypt);
        string DecryptString(string toDecrypt);
    }
}
