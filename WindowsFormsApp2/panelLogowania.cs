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
    public partial class panelLogowania : Form
    {
        public panelLogowania()
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
            groupBoxRejestracja.Left = (this.ClientSize.Width - groupBoxRejestracja.Width) / 2;
            groupBoxLogin.Left = (this.ClientSize.Width - groupBoxLogin.Width) / 2;
            groupBoxRejestracja.Top = (this.ClientSize.Height - groupBoxRejestracja.Height) / 2;
            groupBoxLogin.Top = (this.ClientSize.Height - groupBoxLogin.Height) / 2;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            tryb_loguj();
        }
        private void tryb_rejestracja()
        {
            groupBoxRejestracja.Visible = true;
            groupBoxLogin.Visible = false;
        }
        private void tryb_loguj()
        {
            groupBoxLogin.Visible = true;
            groupBoxRejestracja.Visible = false;
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            panelGlowny PG = new panelGlowny();
            this.Hide();
            PG.ShowDialog();
        }
    }
}
