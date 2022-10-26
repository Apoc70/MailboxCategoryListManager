// MIT License
// 
// Copyright (c) 2018 Thomas Stensitzki, Torsten Schlopsnies
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


// Source: https://www.codeproject.com/Articles/769741/Csharp-AES-bits-Encryption-Library-with-Salt

namespace CategoryManager
{
    public class EncryptionHelper
    {
        /// <summary>
        /// Encrypt bytes with AES256
        /// </summary>
        /// <param name="bytesToBeEncrypted">Bytes to be encrypted</param>
        /// <param name="passwordBytes">Password as byte</param>
        /// <returns>Byte array (encrypted)</returns>
        private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        /// <summary>
        /// Decrypt bytes
        /// </summary>
        /// <param name="bytesToBeDecrypted">Bytes to be decrypted</param>
        /// <param name="passwordBytes">Password as byte</param>
        /// <returns>Byte array (decyrpted)</returns>
        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        /// <summary>
        /// Encrypt a string with AES256
        /// </summary>
        /// <param name="text">Text to be encrypted</param>
        /// <param name="password">Password</param>
        /// <param name="SaltBytes">Size for salt</param>
        /// <returns>Returns text encrypted as string</returns>
        public static string EncryptString(string text, string password, int SaltBytes)
        {
            try
            {
                byte[] baPwd = Encoding.UTF8.GetBytes(password);

                // Hash the password with SHA256
                byte[] baPwdHash = SHA256Managed.Create().ComputeHash(baPwd);

                byte[] baText = Encoding.UTF8.GetBytes(text);

                byte[] baSalt = GetRandomBytes(SaltBytes);
                byte[] baEncrypted = new byte[baSalt.Length + baText.Length];

                // Combine Salt + Text
                for (int i = 0; i < baSalt.Length; i++)
                    baEncrypted[i] = baSalt[i];
                for (int i = 0; i < baText.Length; i++)
                    baEncrypted[i + baSalt.Length] = baText[i];

                baEncrypted = AES_Encrypt(baEncrypted, baPwdHash);

                string result = Convert.ToBase64String(baEncrypted);
                return result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="text">Text to be encrypted</param>
        /// <param name="password">Password</param>
        /// <param name="SaltBytes">Size for salt</param>
        /// <returns>Returns text decrypted as string</returns>
        public static string DecryptString(string text, string password, int SaltBytes)
        {
            try
            {
                byte[] baPwd = Encoding.UTF8.GetBytes(password);

                // Hash the password with SHA256
                byte[] baPwdHash = SHA256Managed.Create().ComputeHash(baPwd);

                byte[] baText = Convert.FromBase64String(text);

                byte[] baDecrypted = AES_Decrypt(baText, baPwdHash);

                // Remove salt
                int saltLength = SaltBytes;
                byte[] baResult = new byte[baDecrypted.Length - saltLength];
                for (int i = 0; i < baResult.Length; i++)
                    baResult[i] = baDecrypted[i + saltLength];

                string result = Encoding.UTF8.GetString(baResult);
                return result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        /// <summary>
        /// Generate random bytes
        /// </summary>
        /// <param name="SaltBytes">Size for the Bytes</param>
        /// <returns>Byte array, filled with random bytes</returns>
        private static byte[] GetRandomBytes(int SaltBytes)
        {
            byte[] ba = new byte[SaltBytes];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return ba;
        }

        /// <summary>
        /// Returns a string with random bytes, encoded as Base64
        /// </summary>
        /// <param name="Length">Length of the string</param>
        /// <returns>String with random bytes</returns>
        public static string GetRandomKey(int Length)
        {
            byte[] ba = new byte[Length];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return Base64Encode(String.Join("", ba));
        }

        /// <summary>
        /// Do a Bas64 encoding on a string
        /// </summary>
        /// <param name="plainText">Text to be encoded</param>
        /// <returns></returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Do a Base64 decode on a string
        /// </summary>
        /// <param name="base64EncodedData">Text do be decoded</param>
        /// <returns></returns>
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
