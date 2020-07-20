using DeviceId;
using SchoolDataImporter.Bll.Interfaces;
using Serilog;
using Serilog.Events;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SchoolDataImporter.Bll
{
    public class StringEncryption : IStringEncryption
    {
        private readonly ILogger _logger;
        private const string EncryptionPassword = "SomeRandomPasswordHere";

        public StringEncryption(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public string DecryptString(string toDecrypt)
        {
            _logger.Debug("Call to DecryptString with input {input}", toDecrypt);

            using (_logger.BeginTimedOperation("DecryptString"))
            {
                // Get a uniue key for the current machine
                var encryptionKey = new DeviceIdBuilder()
                    .AddMachineName()
                    .AddProcessorId()
                    .AddMotherboardSerialNumber()
                    .ToString();

                _logger.Debug("Generated encryption key {encryptionKey}", encryptionKey);

                var salt = Encoding.UTF8.GetBytes(encryptionKey);

                return DecryptStringAES(toDecrypt, salt);
            }
        }

        public string EncryptString(string toEncrypt)
        {
            _logger.Debug("Call to EncryptString");

            // Get a uniue key for the current machine
            var encryptionKey = new DeviceIdBuilder()
                .AddMachineName()
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .ToString();

            _logger.Debug("Generated encryption key {encryptionKey}", encryptionKey);

            var salt = Encoding.UTF8.GetBytes(encryptionKey);

            return EncryptStringAes(toEncrypt, salt);
        }

        private string EncryptStringAes(string plainText, byte[] salt)
        {
            string outStr = null;
            RijndaelManaged aesAlg = null;

            try
            {
                var key = new Rfc2898DeriveBytes(EncryptionPassword, salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        private string DecryptStringAES(string cipherText, byte[] salt)
        {
            RijndaelManaged aesAlg = null;
            string plaintext = null;

            try
            {
                var key = new Rfc2898DeriveBytes(EncryptionPassword, salt);

                // Create the streams used for decryption.                
                var bytes = Convert.FromBase64String(cipherText);
                using (var msDecrypt = new MemoryStream(bytes))
                {
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                _logger.Warning("Could not decrypt previously stored password. Returning empty instead.");
                return string.Empty;
            }
            finally
            {
                if (aesAlg != null)
                {
                    aesAlg.Clear();
                }
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
    }
}
