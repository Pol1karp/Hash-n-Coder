using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Hash_n_Coder
{
    public partial class MyAES : UserControl
    {
        public MyAES()
        {
            InitializeComponent();
        }

        private string EncryptAES_ECB(string plainText, string key)
        {
            byte[] keyBytes = PrepareKey(key);
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] result = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }

        private string DecryptAES_ECB(string cipherText, string key)
        {
            byte[] keyBytes = PrepareKey(key);
            byte[] inputBytes = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] result = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    return Encoding.UTF8.GetString(result);
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
                aes.IV = keyBytes; // IV = KEY как по ТЗ
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] result = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }

        private string DecryptAES_CBC(string cipherText, string key)
        {
            byte[] keyBytes = PrepareKey(key);
            byte[] inputBytes = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = keyBytes; // IV = KEY как по ТЗ
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] result = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    return Encoding.UTF8.GetString(result);
                }
            }
        }

        private byte[] PrepareKey(string key)
        {
            int keySizeBits = int.Parse(guna2ComboBox3.SelectedItem?.ToString() ?? "128");
            int keySizeBytes = keySizeBits / 8;

            // Берем SHA-256 от ключа и обрезаем
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(key));
                byte[] keyBytes = new byte[keySizeBytes];
                Array.Copy(hash, keyBytes, keySizeBytes);
                return keyBytes;
            }
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                guna2TextBox1.Text = Clipboard.GetText();
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                Clipboard.SetText(guna2TextBox2.Text);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string mode = guna2ComboBox2.SelectedItem?.ToString();
            string algorithm = guna2ComboBox1.SelectedItem?.ToString();
            string key = guna2TextBox3.Text;
            string inputText = guna2TextBox1.Text;

            try
            {
                if (algorithm == "AES-ECB")
                {
                    if (mode == "Шифровать")
                    {
                        guna2TextBox2.Text = EncryptAES_ECB(inputText, key);
                    }
                    else if (mode == "Дешифровать")
                    {
                        guna2TextBox2.Text = DecryptAES_ECB(inputText, key);
                    }
                }
                else if (algorithm == "AES-CBC")
                {
                    if (mode == "Шифровать")
                    {
                        guna2TextBox2.Text = EncryptAES_CBC(inputText, key);
                    }
                    else if (mode == "Дешифровать")
                    {
                        guna2TextBox2.Text = DecryptAES_CBC(inputText, key);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int keySizeBits = int.Parse(guna2ComboBox3.SelectedItem?.ToString() ?? "128");
            int keySizeBytes = keySizeBits / 8;

            byte[] randomKey = new byte[keySizeBytes];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomKey);
            }

            guna2TextBox3.Text = Convert.ToBase64String(randomKey);
        }
    }
}
