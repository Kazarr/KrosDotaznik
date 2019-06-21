using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileService
    {
        private byte[] CRYPTING_KEY = {17,174,194,123,135,243,85,78,116,25,69,215,155,207,55,181,12,12,14,122,120,222,252,59,58,85,116,34,64,110,113,149};
        private byte[] CRYPTING_IV = {200,49,19,118,85,177,161,224,143,241,247,102,44,16,232,8};
        /// <summary>
        /// Position of pass in List<byte[]> crypted password
        /// </summary>
        private const int  PASS = 0;
        /// <summary>
        /// Position of key in List<byte[]> crypted password
        /// </summary>
        private const int KEY = 1;
        /// <summary>
        /// Position of Inicialization vector in List<byte[]> crypted password
        /// </summary>
        private const int IV = 2;
        /// <summary>
        /// Save object to JSON on path
        /// </summary>
        /// <param name="objectToSerialize">Your object to save to json</param>
        /// <param name="filePath">Where you want to save it</param>
        public void SaveJson(object objectToSerialize, string filePath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);

            string json = JsonConvert.SerializeObject(
                        objectToSerialize,
                        Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ContractResolver = new
                            Newtonsoft.Json.Serialization
                            .CamelCasePropertyNamesContractResolver()
                        });
            using (var writer = new StreamWriter(new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.ReadWrite),Encoding.UTF8))
            {
                writer.Write(json);
            }
        }
        /// <summary>
        /// Return object from json
        /// </summary>
        /// <typeparam name="T">Your object</typeparam>
        /// <param name="path">Where is your json</param>
        /// <returns></returns>
        public T LoadJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json);
        }
        /// <summary>
        /// Encrypt password. Return List crypted password, key to decrypt password, inicialization vector to decrypt password
        /// </summary>
        /// <param name="pass">Your pass as plain text</param>
        /// <returns></returns>
        public byte[] Encrypt(string pass)
        {
            byte[] cipher;
            // Encrypt the string to an array of bytes.
            cipher = EncryptStringToBytes(pass,CRYPTING_KEY, CRYPTING_IV);
            return cipher;
        }
        /// <summary>
        /// Decrypt password. Return your password as plain text
        /// </summary>
        /// <param name="cipher">List of crypted password, key to decrypt password, inicialization vector to decrypt password</param>
        /// <returns></returns>
        public string Decrypt(byte[] cipher)
        {
            return DecryptStringFromBytes(cipher, CRYPTING_KEY, CRYPTING_IV);
        }

        private byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        private string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                return string.Empty;
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
    }
}
