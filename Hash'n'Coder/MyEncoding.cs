using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_n_Coder
{
    public partial class MyEncoding : UserControl
    {
        public MyEncoding()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = InputTextBox.Text;
                string algorithm = AlgoritmBox.SelectedItem?.ToString();
                string mode = CodeDecodeBox.SelectedItem?.ToString();
                string output = "";

                if (algorithm == "Base64")
                {
                    if (mode == "Encode")
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(input);
                        output = Convert.ToBase64String(bytes);
                    }
                    else if (mode == "Decode")
                    {
                        byte[] bytes = Convert.FromBase64String(input);
                        output = Encoding.UTF8.GetString(bytes);
                    }
                }
                else if (algorithm == "UrlEncode")
                {
                    if (mode == "Encode")
                    {
                        output = WebUtility.UrlEncode(input);
                    }
                    else if (mode == "Decode")
                    {
                        output = WebUtility.UrlDecode(input);
                    }
                }
                else if (algorithm == "HtmlEncode")
                {
                    if (mode == "Encode")
                    {
                        output = WebUtility.HtmlEncode(input);
                    }
                    else if (mode == "Decode")
                    {
                        output = WebUtility.HtmlDecode(input);
                    }
                }
                else if (algorithm == "Unescape")
                {
                    if (mode == "Encode")
                    {
                        output = Uri.EscapeDataString(input);
                    }
                    else if (mode == "Decode")
                    {
                        output = Uri.UnescapeDataString(input);
                    }
                }

                OutputTextBox.Text = output;

                OutputTextBox.Text = "Успешно!";
                OutputTextBox.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = $"Ошибка: {ex.Message}";
                OutputTextBox.ForeColor = Color.Red;
            }
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                InputTextBox.Text = Clipboard.GetText();
            }
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBox.Text))
            {
                Clipboard.SetText(OutputTextBox.Text);
            }
        }
    }
}
