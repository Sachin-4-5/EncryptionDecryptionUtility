using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDecryptionUtility
{
    internal class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.WriteLine("\n=== Encryption Decryption Utility ===");
                Console.WriteLine("1. AES Encrypt Text");
                Console.WriteLine("2. AES Decrypt Text");
                Console.WriteLine("3. RSA Encrypt Text");
                Console.WriteLine("4. RSA Decrypt Text");
                Console.WriteLine("5. AES Encrypt File");
                Console.WriteLine("6. AES Decrypt File");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option (1-7): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter plain text to encrypt (AES): ");
                            string aesPlain = Console.ReadLine();
                            string aesEncrypted = AES_EncryptDecrypt.Encrypt(aesPlain);
                            Console.WriteLine("Encrypted Text (AES): " + aesEncrypted);
                            break;

                        case "2":
                            Console.Write("Enter encrypted text to decrypt (AES): ");
                            string aesCipher = Console.ReadLine();
                            string aesDecrypted = AES_EncryptDecrypt.Decrypt(aesCipher);
                            Console.WriteLine("Decrypted Text (AES): " + aesDecrypted);
                            break;

                        case "3":
                            Console.Write("Enter plain text to encrypt (RSA): ");
                            string rsaPlain = Console.ReadLine();
                            string rsaEncrypted = RSA_EncryptDecrypt.Encrypt(rsaPlain);
                            Console.WriteLine("Encrypted Text (RSA): " + rsaEncrypted);
                            break;

                        case "4":
                            Console.Write("Enter encrypted text to decrypt (RSA): ");
                            string rsaCipher = Console.ReadLine();
                            string rsaDecrypted = RSA_EncryptDecrypt.Decrypt(rsaCipher);
                            Console.WriteLine("Decrypted Text (RSA): " + rsaDecrypted);
                            break;

                        case "5":
                            Console.Write("Enter path of file to encrypt: ");
                            string inputFile = Console.ReadLine();
                            Console.Write("Enter path to save encrypted file: ");
                            string encryptedFile = Console.ReadLine();
                            File_EncryptDecrypt.EncryptFile(inputFile, encryptedFile);
                            Console.WriteLine("File encrypted successfully.");
                            break;

                        case "6":
                            Console.Write("Enter path of file to decrypt: ");
                            string encryptedInput = Console.ReadLine();
                            Console.Write("Enter path to save decrypted file: ");
                            string decryptedFile = Console.ReadLine();
                            File_EncryptDecrypt.DecryptFile(encryptedInput, decryptedFile);
                            Console.WriteLine("File decrypted successfully.");
                            break;

                        case "7":
                            Console.WriteLine("Exiting...");
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
