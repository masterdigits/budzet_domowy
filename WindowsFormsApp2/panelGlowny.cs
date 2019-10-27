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

        bool trybPrzychod = true;
        bool filtrZaawansowany = false;

        private void panelGlowny_Load(object sender, EventArgs e)
        {
            trybDodajPrzychod();
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
                splitContainerSaldo.SplitterDistance = 605;
                filtrZaawansowany = true;
            }
            else
            {
                splitContainerFiltr.SplitterDistance = 80;
                splitContainerSaldo.SplitterDistance = 650;
                filtrZaawansowany = false;
                resetFiltruZaawansowanego();
            }
        }

        private void resetFiltruZaawansowanego()
        {
            comboBoxFiltrKategoria.Text = "Wybierz kategorię";
            textBoxFiltrKwotaOd.Text = "100 zł";
            textBoxFiltrKwotaDo.Text = "100 000 zł";
            comboBoxFiltrKategoria.ForeColor = Color.DimGray;
            textBoxFiltrKwotaDo.ForeColor = Color.DimGray;
            textBoxFiltrKwotaDo.ForeColor = Color.DimGray;
        }

        private void buttonDodajPrzychód_Click(object sender, EventArgs e)
        {
            trybDodajPrzychod();
        }

        private void buttonDodajWydatek_Click(object sender, EventArgs e)
        {
            trybDodajWydatek();
        }

        private void trybDodajPrzychod()
        {
            splitContainerMenuBoczneWidok.Panel1.BackgroundImage = WindowsFormsApp2.Properties.Resources.moneyScreen;
            checkBoxCykliczny.BackgroundImage = WindowsFormsApp2.Properties.Resources.moneyScreen;
            textBoxDodajKwote.Text = "Dodaj kwotę przychodu";
            textBoxDodajKwote.ForeColor = Color.DimGray;
            trybPrzychod = true;
        }

        private void trybDodajWydatek()
        {
            splitContainerMenuBoczneWidok.Panel1.BackgroundImage = WindowsFormsApp2.Properties.Resources.shoppingCartScreen;
            checkBoxCykliczny.BackgroundImage = WindowsFormsApp2.Properties.Resources.shoppingCartScreen;
            textBoxDodajKwote.Text = "Dodaj kwotę wydatku";
            textBoxDodajKwote.ForeColor = Color.DimGray;
            trybPrzychod = false;
        }

        private void buttonWidokKalendarz_Click(object sender, EventArgs e)
        {
            trybWidokKalendarz();
        }

        private void buttonWidokLiniowy_Click(object sender, EventArgs e)
        {
            trybWidokLiniowy();
        }

        private void buttonWidokKolowy_Click(object sender, EventArgs e)
        {
            trybKolowy();
        }

        private void buttonWidokKolumnowy_Click(object sender, EventArgs e)
        {
            trybKolumnowy();
        }

        private void buttonWidokTabelka_Click(object sender, EventArgs e)
        {
            trybWidokTabelka();
        }

        private void trybWidokTabelka()
        {
            labelInfoKalendarz.Visible = false;
            listViewGlowne.Visible = true;
            chartGlowny.Visible = false;
        }

        private void trybWidokKalendarz()
        {
            labelInfoKalendarz.Visible = true;
            listViewGlowne.Visible = false;
            chartGlowny.Visible = false;
        }

        private void trybWidokLiniowy()
        {
            labelInfoKalendarz.Visible = false;
            listViewGlowne.Visible = false;
            chartGlowny.Visible = true;
            chartGlowny.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }

        private void trybKolowy()
        {
            chartGlowny.Visible = true;
            chartGlowny.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            labelInfoKalendarz.Visible = false;
        }

        private void trybKolumnowy()
        {
            chartGlowny.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            labelInfoKalendarz.Visible = false;
            chartGlowny.Visible = true;
        }

        private void textBoxDodajKwote_Click(object sender, EventArgs e)
        {
            if (textBoxDodajKwote.Text  == "Dodaj kwotę przychodu" || textBoxDodajKwote.Text == "Dodaj kwotę wydatku")
            {
                textBoxDodajKwote.Text = "";
                textBoxDodajKwote.ForeColor = Color.Black;
            }
        }

        private void comboBoxKategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxKategoria.Text == "Wybierz kategorię")
            {
                comboBoxKategoria.Text = "";
                comboBoxKategoria.ForeColor = Color.Black;
            }
        }

        private void richTextBoxDodaj_Click(object sender, EventArgs e)
        {
            if (richTextBoxDodaj.Text == "Dodaj opcjonalny opis")
            {
                richTextBoxDodaj.Text = "";
                richTextBoxDodaj.ForeColor = Color.Black;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (trybPrzychod==true)
            {
                textBoxDodajKwote.Text = "Dodaj kwotę przychodu";
            }
            else
            {
                textBoxDodajKwote.Text = "Dodaj kwotę wydatku";
            }
            textBoxDodajKwote.ForeColor = Color.DimGray;
            comboBoxKategoria.Text = "Wybierz kategorię";
            comboBoxKategoria.ForeColor = Color.DimGray;
            richTextBoxDodaj.Text = "Dodaj opcjonalny opis";
            richTextBoxDodaj.ForeColor = Color.DimGray;
        }

        private void comboBoxFiltrWyborOperacji_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrWyborOperacji.Text == "Wybierz operację")
            {
                comboBoxFiltrWyborOperacji.Text = "";
                comboBoxFiltrWyborOperacji.ForeColor = Color.Black;
            }
        }

        private void comboBoxFiltrKategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrKategoria.Text == "Wybierz kategorię")
            {
                comboBoxFiltrKategoria.Text = "";
                comboBoxFiltrKategoria.ForeColor = Color.Black;
            }
        }

        private void textBoxFiltrKwotaOd_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrKwotaOd.Text == "100 zł")
            {
                textBoxFiltrKwotaOd.Text = "";
                textBoxFiltrKwotaOd.ForeColor = Color.Black;
            }
        }

        private void textBoxFiltrKwotaDo_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrKwotaDo.Text == "100 000 zł")
            {
                textBoxFiltrKwotaDo.Text = "";
                textBoxFiltrKwotaDo.ForeColor = Color.Black;
            }
        }
    }
}
