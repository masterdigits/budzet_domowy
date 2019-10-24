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
    public partial class panelGlowny : Form
    {
        public panelGlowny()
        {
            InitializeComponent();
        }

        private void panelGlowny_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void checkBoxFiltrZaawansowany_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender as CheckBox;

            if (c.Checked == true)
            {
                splitContainerFiltr.SplitterDistance = 125;
                splitContainerSaldo.SplitterDistance = 650;
            }
            else
            {
                splitContainerFiltr.SplitterDistance = 80;
                splitContainerSaldo.SplitterDistance = 650;
            }
        }
    }
}
