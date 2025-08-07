using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Hash_n_Coder
{
    public partial class MyAES : UserControl
    {
        public MyAES()
        {
            InitializeComponent();
        }
        public static string Encrypt(string plainText, string key)
        {

            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(nameof(plainText));
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        byte[] encryptedBytes = msEncrypt.ToArray();
                        return Convert.ToBase64String(encryptedBytes);
                    }
                }
            }
        }
        public static string Decrypt(string cipherText, string key)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException(nameof(cipherText));
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
        private string EncryptAES_CBC(string plainText, string key)
        {
            byte[] keyBytes = PrepareKey(key);
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.GenerateIV();
                byte[] iv = aes.IV;
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] cipherBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    byte[] result = new byte[iv.Length + cipherBytes.Length];
                    Array.Copy(iv, 0, result, 0, iv.Length);
                    Array.Copy(cipherBytes, 0, result, iv.Length, cipherBytes.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }
        private string DecryptAES_CBC(string cipherText, string key)
        {
            byte[] keyBytes = PrepareKey(key);
            byte[] fullCipher = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                byte[] iv = new byte[16];
                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                aes.IV = iv;
                byte[] cipherBytes = new byte[fullCipher.Length - iv.Length];
                Array.Copy(fullCipher, iv.Length, cipherBytes, 0, cipherBytes.Length);
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] result = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                    return Encoding.UTF8.GetString(result);
                }
            }
        }
        private byte[] PrepareKey(string key)
        {

            int keySizeBits = int.Parse(KeyBox.SelectedItem?.ToString() ?? "128");
            int keySizeBytes = keySizeBits / 8;
            try
            {
                byte[] keyBytes = Convert.FromBase64String(key);
                if (keyBytes.Length != keySizeBytes)
                    throw new Exception($"Ключ должен быть ровно {keySizeBytes} байт.");

                return keyBytes;
            }
            catch
            {
                using (SHA256 sha = SHA256.Create())
                {
                    byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(key));

                    byte[] keyBytes = new byte[keySizeBytes];
                    Array.Copy(hash, keyBytes, keySizeBytes);

                    return keyBytes;
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try {
                string mode = ShifrBox.SelectedItem?.ToString();
                string algorithm = AlgoritmBox.SelectedItem?.ToString();
                string key = KeyTextBox.Text;
                string inputText = InputTextBox.Text;


                if (algorithm == "AES-ECB")
                {
                    if (mode == "Шифровать")
                        OutputTextBox.Text = Encrypt(inputText, key);
                    else if (mode == "Дешифровать")
                        OutputTextBox.Text = Decrypt(inputText, key);
                }
                else if (algorithm == "AES-CBC")
                {
                    if (mode == "Шифровать")
                        OutputTextBox.Text = EncryptAES_CBC(inputText, key);
                    else if (mode == "Дешифровать")
                        OutputTextBox.Text = DecryptAES_CBC(inputText, key);
                }
                OutputTextBox.Text = "Успешно!"; 
                OutputTextBox.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = $"Ошибка: {ex.Message}";
                OutputTextBox.ForeColor = Color.Red;
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int keySizeBits = int.Parse(KeyBox.SelectedItem?.ToString() ?? "128");
                int keySizeBytes = keySizeBits / 8;
                byte[] randomKey = new byte[keySizeBytes];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(randomKey);
                }
                KeyTextBox.Text = Convert.ToBase64String(randomKey);
                OutputTextBox.Text = "Успешно!";
                OutputTextBox.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = $"Ошибка: {ex.Message}";
                OutputTextBox.ForeColor = Color.Red;
            }
        }
        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                InputTextBox.Text = Clipboard.GetText();
            }
        }
        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBox.Text))
            {
                Clipboard.SetText(OutputTextBox.Text);
            }
        }
    }
}
