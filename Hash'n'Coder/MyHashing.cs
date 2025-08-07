using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_n_Coder
{
    public partial class MyHashing : UserControl
    {
        public MyHashing()
        {
            InitializeComponent();
        }

        private void guna2ImageButtonPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                InputTextBox.Text = Clipboard.GetText();
            }
        }

        private void guna2ImageButtonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBox.Text))
            {
                Clipboard.SetText(OutputTextBox.Text);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string inputText = InputTextBox.Text;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MD5:     " + ComputeHash(inputText, MD5.Create()));
            sb.AppendLine("SHA-1:   " + ComputeHash(inputText, SHA1.Create()));
            sb.AppendLine("SHA-256: " + ComputeHash(inputText, SHA256.Create()));
            sb.AppendLine("SHA-384: " + ComputeHash(inputText, SHA384.Create()));
            sb.AppendLine("SHA-512: " + ComputeHash(inputText, SHA512.Create()));

            OutputTextBox.Text = sb.ToString();
        }
        private string ComputeHash(string input, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }
    }
}
