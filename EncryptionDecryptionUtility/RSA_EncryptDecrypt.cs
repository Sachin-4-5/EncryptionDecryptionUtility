using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDecryptionUtility
{
    public static class RSA_EncryptDecrypt
    {
        private static readonly string publicKeyXml;
        private static readonly string privateKeyXml;

        static RSA_EncryptDecrypt()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                publicKeyXml = rsa.ToXmlString(false); // public only
                privateKeyXml = rsa.ToXmlString(true); // public + private
            }
        }

        public static string Encrypt(string plainText)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKeyXml);
                var bytesToEncrypt = Encoding.UTF8.GetBytes(plainText);
                var encryptedBytes = rsa.Encrypt(bytesToEncrypt, false);
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        public static string Decrypt(string cipherText)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKeyXml);
                var bytesToDecrypt = Convert.FromBase64String(cipherText);
                var decryptedBytes = rsa.Decrypt(bytesToDecrypt, false);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
