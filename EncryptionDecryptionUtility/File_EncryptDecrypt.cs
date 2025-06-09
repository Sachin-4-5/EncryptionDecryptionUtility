using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDecryptionUtility
{
    public static class File_EncryptDecrypt
    {
        private static readonly string key = "ThisIsA16ByteKey"; // 16 bytes = 128 bits
        private static readonly byte[] iv = new byte[16];

        public static void EncryptFile(string inputPath, string outputPath)
        {
            using (FileStream inputFile = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
            using (FileStream outputFile = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                using (CryptoStream cs = new CryptoStream(outputFile, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputFile.CopyTo(cs);
                }
            }
        }


        public static void DecryptFile(string inputPath, string outputPath)
        {
            using (FileStream inputFile = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
            using (FileStream outputFile = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                using (CryptoStream cs = new CryptoStream(inputFile, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cs.CopyTo(outputFile);
                }
            }
        }
    }
}
