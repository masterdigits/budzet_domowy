using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tryb_loguj();

        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tryb_rejestracja();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            groupBox_register.Left = (this.ClientSize.Width - groupBox_register.Width) / 2;
            groupBox_login.Left = (this.ClientSize.Width - groupBox_login.Width) / 2;
            groupBox_register.Top = (this.ClientSize.Height - groupBox_register.Height) / 2;
            groupBox_login.Top = (this.ClientSize.Height - groupBox_login.Height) / 2;
 /*           textBox_login.Left = (this.groupBox_register.Width - textBox_login.Width) / 2;
            textBox_password.Left = (this.groupBox_register.Width - textBox_password.Width) / 2;
            textBox_email.Left = (this.groupBox_register.Width - textBox_email.Width) / 2;
            textBox_name.Left = (this.groupBox_register.Width - textBox_name.Width) / 2;
            textBox_surname.Left = (this.groupBox_register.Width - textBox_surname.Width) / 2;
            textBox_majatek.Left = (this.groupBox_register.Width - textBox_majatek.Width) / 2;*/
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            tryb_loguj();
        }
        private void tryb_rejestracja()
        {
            groupBox_register.Visible = true;
            groupBox_login.Visible = false;
        }
        private void tryb_loguj()
        {
            groupBox_login.Visible = true;
            groupBox_register.Visible = false;
        }

        private void linkLabel_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
