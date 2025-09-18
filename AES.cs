using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class AES {
    // Must be reverse-engineered from the game's code.
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("e38c9861b43264e37c1eef64d7925dde");
    private const int IV_SIZE = 16;

    public static string Encrypt(string plainText) {
        Aes aes = Aes.Create();

        aes.Key = Key;
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

    public static string Decrypt(string combinedString) {
        byte[] combinedData = Convert.FromBase64String(combinedString);

        Aes aes = Aes.Create();
        aes.Padding = PaddingMode.PKCS7;
        aes.Key = Key;
        byte[] iv = new byte[IV_SIZE];
        byte[] cipherText = new byte[combinedData.Length - IV_SIZE];

        Array.Copy(combinedData, iv, IV_SIZE);
        Array.Copy(combinedData, IV_SIZE, cipherText, 0, cipherText.Length);

        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        ICryptoTransform decipher = aes.CreateDecryptor(aes.Key, aes.IV);
        string plainText;

        using (MemoryStream ms = new MemoryStream(cipherText)) {
            using (CryptoStream cs = new CryptoStream(ms, decipher, CryptoStreamMode.Read)) {
                using (StreamReader sr = new StreamReader(cs)) {
                    plainText = sr.ReadToEnd();
                }
            }

            return plainText;
        }
    }
}