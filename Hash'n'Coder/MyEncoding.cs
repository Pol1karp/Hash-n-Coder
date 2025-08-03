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
            string input = guna2TextBox1.Text;
            string algorithm = guna2ComboBox1.SelectedItem?.ToString();
            string mode = guna2ComboBox2.SelectedItem?.ToString();
            string output = "";

            try
            {
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

                guna2TextBox2.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
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
    }
}
