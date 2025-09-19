using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NINAHSaveEditor.Crypto {
    class AES {
        private const int IV_SIZE = 16;

        public static string Encrypt(string plainText) {
            Aes aes = Aes.Create();

            aes.Key = Keys.Latest;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.GenerateIV();

            ICryptoTransform cipher = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] cipherData;

            using (MemoryStream ms = new MemoryStream()) {
                using (CryptoStream cs = new CryptoStream(ms, cipher, CryptoStreamMode.Write)) {
                    using (StreamWriter sw = new StreamWriter(cs)) {
                        sw.Write(plainText);
                    }
                }

                cipherData = ms.ToArray();
            }

            byte[] combinedData = new byte[IV_SIZE + cipherData.Length];
            Array.Copy(aes.IV, 0, combinedData, 0, IV_SIZE);
            Array.Copy(cipherData, 0, combinedData, IV_SIZE, cipherData.Length);

            return Convert.ToBase64String(combinedData);
        }

        public static string Decrypt(string cipherText) {
            byte[] cipher = Convert.FromBase64String(cipherText);

            Aes aes = Aes.Create();
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = Keys.Latest;
            byte[] iv = new byte[IV_SIZE];
            byte[] buffer = new byte[cipher.Length - IV_SIZE];

            Array.Copy(cipher, iv, IV_SIZE);
            Array.Copy(cipher, IV_SIZE, buffer, 0, buffer.Length);

            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform decipher = aes.CreateDecryptor(aes.Key, aes.IV);
            string plainText;

            using (MemoryStream ms = new MemoryStream(buffer)) {
                using (CryptoStream cs = new CryptoStream(ms, decipher, CryptoStreamMode.Read)) {
                    using (StreamReader sr = new StreamReader(cs)) {
                        plainText = sr.ReadToEnd();
                    }
                }

                return plainText;
            }
        }
    }
}