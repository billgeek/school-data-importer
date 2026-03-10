namespace SchoolDataImporter.Bll.Interfaces
{
    public interface IStringEncryption
    {
        string EncryptString(string toEncrypt);
        string DecryptString(string toDecrypt);
    }
}
