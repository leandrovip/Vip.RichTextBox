using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vip.RichTextBox.Demo
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/leandrovip");
        }
    }
}