using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void LoadControl(UserControl uc)
        {
            guna2Panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadControl(new Encoding());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadControl(new AES());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadControl(new Hashing());
        }
    }
}
