using Guna.UI2.WinForms;
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
                if (string.IsNullOrWhiteSpace(InputTextBox.Text))
                {
                    MessageBox.Show("Введите текст для обработки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (AlgoritmBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите алгоритм!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CodeDecodeBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите режим (кодировать/декодировать)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (algorithm == "Base64")
                {
                    if (mode == "Кодировать")
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(input);
                        output = Convert.ToBase64String(bytes);
                    }
                    else if (mode == "Декодировать")
                    {
                        byte[] bytes = Convert.FromBase64String(input);
                        output = Encoding.UTF8.GetString(bytes);
                    }
                }
                else if (algorithm == "UrlEncode")
                {
                    if (mode == "Кодировать")
                    {
                        output = WebUtility.UrlEncode(input);
                    }
                    else if (mode == "Декодировать")
                    {
                        output = WebUtility.UrlDecode(input);
                    }
                }
                else if (algorithm == "HtmlEncode")
                {
                    if (mode == "Кодировать")
                    {
                        output = WebUtility.HtmlEncode(input);
                    }
                    else if (mode == "Декодировать")
                    {
                        output = WebUtility.HtmlDecode(input);
                    }
                }
                else if (algorithm == "UnescapeEncode")
                {
                    if (mode == "Кодировать")
                    {
                        output = Uri.EscapeDataString(input);
                    }
                    else if (mode == "Декодировать")
                    {
                        output = Uri.UnescapeDataString(input);
                    }
                }
                OutputTextBox.ForeColor = Color.Green;
                OutputTextBox.Text = output;

                
                
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
            else
            {
                MessageBox.Show("В буфере обмена нет текста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OutputTextBox.Text))
            {
                Clipboard.SetText(OutputTextBox.Text);
                MessageBox.Show("Результат скопирован в буфер обмена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет данных для копирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void CodeDecodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = CodeDecodeBox.SelectedItem?.ToString();
            if (mode == "Кодировать")
                StartButton.Text = "Кодировать";
            else if (mode == "Декодировать")
                StartButton.Text = "Декодировать";
        }
    }
}
