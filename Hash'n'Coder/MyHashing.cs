using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                guna2TextBox1.Text = Clipboard.GetText();
            }
        }

        private void guna2ImageButtonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                Clipboard.SetText(guna2TextBox2.Text);
            }
        }
    }
}
