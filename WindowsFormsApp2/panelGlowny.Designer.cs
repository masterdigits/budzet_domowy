namespace WindowsFormsApp2
{
    partial class panelGlowny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

              #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea44 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend44 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerGlowny = new System.Windows.Forms.SplitContainer();
            this.splitContainerMenuBoczne = new System.Windows.Forms.SplitContainer();
            this.buttonDodajWydatek = new System.Windows.Forms.Button();
            this.buttonDodajPrzychód = new System.Windows.Forms.Button();
            this.splitContainerMenuBoczneWidok = new System.Windows.Forms.SplitContainer();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.richTextBoxDodaj = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDodajOperacje = new System.Windows.Forms.DateTimePicker();
            this.textBoxDodajKwote = new System.Windows.Forms.TextBox();
            this.buttonWidokTabelka = new System.Windows.Forms.Button();
            this.buttonWidokKolumnowy = new System.Windows.Forms.Button();
            this.buttonWidokKolowy = new System.Windows.Forms.Button();
            this.buttonWidokKalendarz = new System.Windows.Forms.Button();
            this.buttonWidokLiniowy = new System.Windows.Forms.Button();
            this.splitContainerFiltr = new System.Windows.Forms.SplitContainer();
            this.textBoxSzukajWOpisie = new System.Windows.Forms.TextBox();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.labelSzukajWOpisie = new System.Windows.Forms.Label();
            this.textBoxFiltrKwotaDo = new System.Windows.Forms.TextBox();
            this.textBoxFiltrKwotaOd = new System.Windows.Forms.TextBox();
            this.comboBoxFiltrKategoria = new System.Windows.Forms.ComboBox();
            this.labelDoKwota = new System.Windows.Forms.Label();
            this.labelOdKwota = new System.Windows.Forms.Label();
            this.checkBoxFiltrZaawansowany = new System.Windows.Forms.CheckBox();
            this.labelDoData = new System.Windows.Forms.Label();
            this.dateTimePickerFiltrDo = new System.Windows.Forms.DateTimePicker();
            this.labelOdData = new System.Windows.Forms.Label();
            this.dateTimePickerFiltrOd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFiltrWyborOperacji = new System.Windows.Forms.ComboBox();
            this.buttonUstawienia = new System.Windows.Forms.Button();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.splitContainerSaldo = new System.Windows.Forms.SplitContainer();
            this.labelInfoKalendarz = new System.Windows.Forms.Label();
            this.chartGlowny = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewGlowne = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperacj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewGlowny = new System.Windows.Forms.ListView();
            this.checkBoxCykliczny = new System.Windows.Forms.CheckBox();
            this.pictureBoxWyloguj = new System.Windows.Forms.PictureBox();
            this.pictureBoxUstawienia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlowny)).BeginInit();
            this.splitContainerGlowny.Panel1.SuspendLayout();
            this.splitContainerGlowny.Panel2.SuspendLayout();
            this.splitContainerGlowny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczne)).BeginInit();
            this.splitContainerMenuBoczne.Panel1.SuspendLayout();
            this.splitContainerMenuBoczne.Panel2.SuspendLayout();
            this.splitContainerMenuBoczne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).BeginInit();
            this.splitContainerMenuBoczneWidok.Panel1.SuspendLayout();
            this.splitContainerMenuBoczneWidok.Panel2.SuspendLayout();
            this.splitContainerMenuBoczneWidok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).BeginInit();
            this.splitContainerFiltr.Panel1.SuspendLayout();
            this.splitContainerFiltr.Panel2.SuspendLayout();
            this.splitContainerFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaldo)).BeginInit();
            this.splitContainerSaldo.Panel1.SuspendLayout();
            this.splitContainerSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlowny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWyloguj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUstawienia)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerGlowny
            // 
            this.splitContainerGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGlowny.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerGlowny.IsSplitterFixed = true;
            this.splitContainerGlowny.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGlowny.Name = "splitContainerGlowny";
            // 
            // splitContainerGlowny.Panel1
            // 
            this.splitContainerGlowny.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerGlowny.Panel1.Controls.Add(this.splitContainerMenuBoczne);
            // 
            // splitContainerGlowny.Panel2
            // 
            this.splitContainerGlowny.Panel2.Controls.Add(this.splitContainerFiltr);
            this.splitContainerGlowny.Size = new System.Drawing.Size(1345, 832);
            this.splitContainerGlowny.SplitterDistance = 350;
            this.splitContainerGlowny.TabIndex = 0;
            // 
            // splitContainerMenuBoczne
            // 
            this.splitContainerMenuBoczne.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenuBoczne.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMenuBoczne.IsSplitterFixed = true;
            this.splitContainerMenuBoczne.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMenuBoczne.Name = "splitContainerMenuBoczne";
            this.splitContainerMenuBoczne.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenuBoczne.Panel1
            // 
            this.splitContainerMenuBoczne.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczne.Panel1.Controls.Add(this.buttonDodajWydatek);
            this.splitContainerMenuBoczne.Panel1.Controls.Add(this.buttonDodajPrzychód);
            // 
            // splitContainerMenuBoczne.Panel2
            // 
            this.splitContainerMenuBoczne.Panel2.Controls.Add(this.splitContainerMenuBoczneWidok);
            this.splitContainerMenuBoczne.Size = new System.Drawing.Size(350, 832);
            this.splitContainerMenuBoczne.SplitterDistance = 200;
            this.splitContainerMenuBoczne.TabIndex = 0;
            // 
            // buttonDodajWydatek
            // 
            this.buttonDodajWydatek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajWydatek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajWydatek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDodajWydatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajWydatek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWydatek.Location = new System.Drawing.Point(54, 140);
            this.buttonDodajWydatek.Name = "buttonDodajWydatek";
            this.buttonDodajWydatek.Size = new System.Drawing.Size(372, 76);
            this.buttonDodajWydatek.TabIndex = 1;
            this.buttonDodajWydatek.Text = "Dodaj wydatek";
            this.buttonDodajWydatek.UseVisualStyleBackColor = true;
            this.buttonDodajWydatek.Click += new System.EventHandler(this.buttonDodajWydatek_Click);
            // 
            // buttonDodajPrzychód
            // 
            this.buttonDodajPrzychód.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajPrzychód.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDodajPrzychód.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDodajPrzychód.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajPrzychód.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajPrzychód.Location = new System.Drawing.Point(54, 41);
            this.buttonDodajPrzychód.Name = "buttonDodajPrzychód";
            this.buttonDodajPrzychód.Size = new System.Drawing.Size(372, 76);
            this.buttonDodajPrzychód.TabIndex = 0;
            this.buttonDodajPrzychód.Text = "Dodaj przychód";
            this.buttonDodajPrzychód.UseVisualStyleBackColor = true;
            this.buttonDodajPrzychód.Click += new System.EventHandler(this.buttonDodajPrzychód_Click);
            // 
            // splitContainerMenuBoczneWidok
            // 
            this.splitContainerMenuBoczneWidok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenuBoczneWidok.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMenuBoczneWidok.IsSplitterFixed = true;
            this.splitContainerMenuBoczneWidok.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMenuBoczneWidok.Name = "splitContainerMenuBoczneWidok";
            this.splitContainerMenuBoczneWidok.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenuBoczneWidok.Panel1
            // 
            this.splitContainerMenuBoczneWidok.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczneWidok.Panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.shoppingCartScreen;
            this.splitContainerMenuBoczneWidok.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.comboBoxKategoria);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.checkBoxCykliczny);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.buttonReset);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.buttonZapisz);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.richTextBoxDodaj);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.dateTimePickerDodajOperacje);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.textBoxDodajKwote);
            // 
            // splitContainerMenuBoczneWidok.Panel2
            // 
            this.splitContainerMenuBoczneWidok.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokTabelka);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKolumnowy);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKolowy);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKalendarz);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokLiniowy);
            this.splitContainerMenuBoczneWidok.Size = new System.Drawing.Size(350, 628);
            this.splitContainerMenuBoczneWidok.SplitterDistance = 345;
            this.splitContainerMenuBoczneWidok.TabIndex = 0;
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(54, 154);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(372, 29);
            this.comboBoxKategoria.TabIndex = 2;
            this.comboBoxKategoria.Text = "Wybierz kategorię";
            this.comboBoxKategoria.Click += new System.EventHandler(this.comboBoxKategoria_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(51, 306);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(172, 43);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Resetuj";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapisz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonZapisz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonZapisz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisz.Location = new System.Drawing.Point(254, 306);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(172, 43);
            this.buttonZapisz.TabIndex = 5;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDodaj
            // 
            this.richTextBoxDodaj.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDodaj.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBoxDodaj.Location = new System.Drawing.Point(54, 202);
            this.richTextBoxDodaj.Name = "richTextBoxDodaj";
            this.richTextBoxDodaj.Size = new System.Drawing.Size(372, 70);
            this.richTextBoxDodaj.TabIndex = 4;
            this.richTextBoxDodaj.Text = "Dodaj opcjonalny opis";
            this.richTextBoxDodaj.Click += new System.EventHandler(this.richTextBoxDodaj_Click);
            // 
            // dateTimePickerDodajOperacje
            // 
            this.dateTimePickerDodajOperacje.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDodajOperacje.Location = new System.Drawing.Point(54, 109);
            this.dateTimePickerDodajOperacje.Name = "dateTimePickerDodajOperacje";
            this.dateTimePickerDodajOperacje.Size = new System.Drawing.Size(372, 28);
            this.dateTimePickerDodajOperacje.TabIndex = 2;
            // 
            // textBoxDodajKwote
            // 
            this.textBoxDodajKwote.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDodajKwote.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDodajKwote.Location = new System.Drawing.Point(54, 64);
            this.textBoxDodajKwote.Name = "textBoxDodajKwote";
            this.textBoxDodajKwote.Size = new System.Drawing.Size(372, 28);
            this.textBoxDodajKwote.TabIndex = 1;
            this.textBoxDodajKwote.Text = "Dodaj kwotę przychodu";
            this.textBoxDodajKwote.Click += new System.EventHandler(this.textBoxDodajKwote_Click);
            // 
            // buttonWidokTabelka
            // 
            this.buttonWidokTabelka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokTabelka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokTabelka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokTabelka.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokTabelka.Location = new System.Drawing.Point(8, 6);
            this.buttonWidokTabelka.Name = "buttonWidokTabelka";
            this.buttonWidokTabelka.Size = new System.Drawing.Size(454, 59);
            this.buttonWidokTabelka.TabIndex = 5;
            this.buttonWidokTabelka.Text = "Tabela";
            this.buttonWidokTabelka.UseVisualStyleBackColor = true;
            this.buttonWidokTabelka.Click += new System.EventHandler(this.buttonWidokTabelka_Click);
            // 
            // buttonWidokKolumnowy
            // 
            this.buttonWidokKolumnowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolumnowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolumnowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolumnowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolumnowy.Location = new System.Drawing.Point(8, 267);
            this.buttonWidokKolumnowy.Name = "buttonWidokKolumnowy";
            this.buttonWidokKolumnowy.Size = new System.Drawing.Size(454, 64);
            this.buttonWidokKolumnowy.TabIndex = 4;
            this.buttonWidokKolumnowy.Text = "Wykres kolumnowy";
            this.buttonWidokKolumnowy.UseVisualStyleBackColor = true;
            this.buttonWidokKolumnowy.Click += new System.EventHandler(this.buttonWidokKolumnowy_Click);
            // 
            // buttonWidokKolowy
            // 
            this.buttonWidokKolowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolowy.Location = new System.Drawing.Point(8, 198);
            this.buttonWidokKolowy.Name = "buttonWidokKolowy";
            this.buttonWidokKolowy.Size = new System.Drawing.Size(454, 64);
            this.buttonWidokKolowy.TabIndex = 3;
            this.buttonWidokKolowy.Text = "Wykres kołowy";
            this.buttonWidokKolowy.UseVisualStyleBackColor = true;
            this.buttonWidokKolowy.Click += new System.EventHandler(this.buttonWidokKolowy_Click);
            // 
            // buttonWidokKalendarz
            // 
            this.buttonWidokKalendarz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKalendarz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKalendarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKalendarz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKalendarz.Location = new System.Drawing.Point(8, 70);
            this.buttonWidokKalendarz.Name = "buttonWidokKalendarz";
            this.buttonWidokKalendarz.Size = new System.Drawing.Size(454, 59);
            this.buttonWidokKalendarz.TabIndex = 0;
            this.buttonWidokKalendarz.Text = "Kalendarz";
            this.buttonWidokKalendarz.UseVisualStyleBackColor = true;
            this.buttonWidokKalendarz.Click += new System.EventHandler(this.buttonWidokKalendarz_Click);
            // 
            // buttonWidokLiniowy
            // 
            this.buttonWidokLiniowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokLiniowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokLiniowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokLiniowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokLiniowy.Location = new System.Drawing.Point(8, 134);
            this.buttonWidokLiniowy.Name = "buttonWidokLiniowy";
            this.buttonWidokLiniowy.Size = new System.Drawing.Size(454, 59);
            this.buttonWidokLiniowy.TabIndex = 2;
            this.buttonWidokLiniowy.Text = "Wykres liniowy";
            this.buttonWidokLiniowy.UseVisualStyleBackColor = true;
            this.buttonWidokLiniowy.Click += new System.EventHandler(this.buttonWidokLiniowy_Click);
            // 
            // splitContainerFiltr
            // 
            this.splitContainerFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFiltr.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFiltr.IsSplitterFixed = true;
            this.splitContainerFiltr.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFiltr.Name = "splitContainerFiltr";
            this.splitContainerFiltr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFiltr.Panel1
            // 
            this.splitContainerFiltr.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerFiltr.Panel1.Controls.Add(this.pictureBoxWyloguj);
            this.splitContainerFiltr.Panel1.Controls.Add(this.pictureBoxUstawienia);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxSzukajWOpisie);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonWyszukaj);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelSzukajWOpisie);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxFiltrKwotaDo);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxFiltrKwotaOd);
            this.splitContainerFiltr.Panel1.Controls.Add(this.comboBoxFiltrKategoria);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelDoKwota);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelOdKwota);
            this.splitContainerFiltr.Panel1.Controls.Add(this.checkBoxFiltrZaawansowany);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelDoData);
            this.splitContainerFiltr.Panel1.Controls.Add(this.dateTimePickerFiltrDo);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelOdData);
            this.splitContainerFiltr.Panel1.Controls.Add(this.dateTimePickerFiltrOd);
            this.splitContainerFiltr.Panel1.Controls.Add(this.comboBoxFiltrWyborOperacji);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonUstawienia);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonWyloguj);
            // 
            // splitContainerFiltr.Panel2
            // 
            this.splitContainerFiltr.Panel2.Controls.Add(this.splitContainerSaldo);
            this.splitContainerFiltr.Size = new System.Drawing.Size(991, 832);
            this.splitContainerFiltr.SplitterDistance = 80;
            this.splitContainerFiltr.TabIndex = 0;
            // 
            // textBoxSzukajWOpisie
            // 
            this.textBoxSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukajWOpisie.Location = new System.Drawing.Point(1015, 105);
            this.textBoxSzukajWOpisie.Name = "textBoxSzukajWOpisie";
            this.textBoxSzukajWOpisie.Size = new System.Drawing.Size(192, 27);
            this.textBoxSzukajWOpisie.TabIndex = 22;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyszukaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonWyszukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyszukaj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszukaj.Location = new System.Drawing.Point(1247, 105);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(180, 29);
            this.buttonWyszukaj.TabIndex = 21;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            // 
            // labelSzukajWOpisie
            // 
            this.labelSzukajWOpisie.AutoSize = true;
            this.labelSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzukajWOpisie.Location = new System.Drawing.Point(855, 109);
            this.labelSzukajWOpisie.Name = "labelSzukajWOpisie";
            this.labelSzukajWOpisie.Size = new System.Drawing.Size(139, 22);
            this.labelSzukajWOpisie.TabIndex = 20;
            this.labelSzukajWOpisie.Text = "Szukaj w opisie";
            // 
            // textBoxFiltrKwotaDo
            // 
            this.textBoxFiltrKwotaDo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFiltrKwotaDo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFiltrKwotaDo.Location = new System.Drawing.Point(650, 105);
            this.textBoxFiltrKwotaDo.Name = "textBoxFiltrKwotaDo";
            this.textBoxFiltrKwotaDo.Size = new System.Drawing.Size(192, 27);
            this.textBoxFiltrKwotaDo.TabIndex = 19;
            this.textBoxFiltrKwotaDo.Text = "100 000 zł";
            this.textBoxFiltrKwotaDo.Click += new System.EventHandler(this.textBoxFiltrKwotaDo_Click);
            // 
            // textBoxFiltrKwotaOd
            // 
            this.textBoxFiltrKwotaOd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFiltrKwotaOd.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFiltrKwotaOd.Location = new System.Drawing.Point(394, 105);
            this.textBoxFiltrKwotaOd.Name = "textBoxFiltrKwotaOd";
            this.textBoxFiltrKwotaOd.Size = new System.Drawing.Size(192, 27);
            this.textBoxFiltrKwotaOd.TabIndex = 18;
            this.textBoxFiltrKwotaOd.Text = "100 zł";
            this.textBoxFiltrKwotaOd.Click += new System.EventHandler(this.textBoxFiltrKwotaOd_Click);
            // 
            // comboBoxFiltrKategoria
            // 
            this.comboBoxFiltrKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrKategoria.FormattingEnabled = true;
            this.comboBoxFiltrKategoria.Location = new System.Drawing.Point(61, 105);
            this.comboBoxFiltrKategoria.Name = "comboBoxFiltrKategoria";
            this.comboBoxFiltrKategoria.Size = new System.Drawing.Size(262, 27);
            this.comboBoxFiltrKategoria.TabIndex = 17;
            this.comboBoxFiltrKategoria.Text = "Wybierz kategorię";
            this.comboBoxFiltrKategoria.Click += new System.EventHandler(this.comboBoxFiltrKategoria_Click);
            // 
            // labelDoKwota
            // 
            this.labelDoKwota.AutoSize = true;
            this.labelDoKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoKwota.Location = new System.Drawing.Point(598, 109);
            this.labelDoKwota.Name = "labelDoKwota";
            this.labelDoKwota.Size = new System.Drawing.Size(35, 22);
            this.labelDoKwota.TabIndex = 16;
            this.labelDoKwota.Text = "Do";
            // 
            // labelOdKwota
            // 
            this.labelOdKwota.AutoSize = true;
            this.labelOdKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdKwota.ForeColor = System.Drawing.Color.Black;
            this.labelOdKwota.Location = new System.Drawing.Point(341, 109);
            this.labelOdKwota.Name = "labelOdKwota";
            this.labelOdKwota.Size = new System.Drawing.Size(36, 22);
            this.labelOdKwota.TabIndex = 15;
            this.labelOdKwota.Text = "Od";
            // 
            // checkBoxFiltrZaawansowany
            // 
            this.checkBoxFiltrZaawansowany.AutoSize = true;
            this.checkBoxFiltrZaawansowany.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxFiltrZaawansowany.Location = new System.Drawing.Point(1220, 56);
            this.checkBoxFiltrZaawansowany.Name = "checkBoxFiltrZaawansowany";
            this.checkBoxFiltrZaawansowany.Size = new System.Drawing.Size(207, 21);
            this.checkBoxFiltrZaawansowany.TabIndex = 13;
            this.checkBoxFiltrZaawansowany.Text = "Pokaż filtry zaawansowane";
            this.checkBoxFiltrZaawansowany.UseVisualStyleBackColor = true;
            this.checkBoxFiltrZaawansowany.CheckedChanged += new System.EventHandler(this.checkBoxFiltrZaawansowany_CheckedChanged);
            // 
            // labelDoData
            // 
            this.labelDoData.AutoSize = true;
            this.labelDoData.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoData.Location = new System.Drawing.Point(750, 56);
            this.labelDoData.Name = "labelDoData";
            this.labelDoData.Size = new System.Drawing.Size(35, 22);
            this.labelDoData.TabIndex = 12;
            this.labelDoData.Text = "Do";
            // 
            // dateTimePickerFiltrDo
            // 
            this.dateTimePickerFiltrDo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFiltrDo.Location = new System.Drawing.Point(800, 52);
            this.dateTimePickerFiltrDo.Name = "dateTimePickerFiltrDo";
            this.dateTimePickerFiltrDo.Size = new System.Drawing.Size(334, 27);
            this.dateTimePickerFiltrDo.TabIndex = 11;
            // 
            // labelOdData
            // 
            this.labelOdData.AutoSize = true;
            this.labelOdData.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdData.Location = new System.Drawing.Point(341, 56);
            this.labelOdData.Name = "labelOdData";
            this.labelOdData.Size = new System.Drawing.Size(36, 22);
            this.labelOdData.TabIndex = 8;
            this.labelOdData.Text = "Od";
            // 
            // dateTimePickerFiltrOd
            // 
            this.dateTimePickerFiltrOd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFiltrOd.Location = new System.Drawing.Point(394, 52);
            this.dateTimePickerFiltrOd.Name = "dateTimePickerFiltrOd";
            this.dateTimePickerFiltrOd.Size = new System.Drawing.Size(334, 27);
            this.dateTimePickerFiltrOd.TabIndex = 10;
            // 
            // comboBoxFiltrWyborOperacji
            // 
            this.comboBoxFiltrWyborOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrWyborOperacji.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrWyborOperacji.FormattingEnabled = true;
            this.comboBoxFiltrWyborOperacji.Location = new System.Drawing.Point(61, 52);
            this.comboBoxFiltrWyborOperacji.Name = "comboBoxFiltrWyborOperacji";
            this.comboBoxFiltrWyborOperacji.Size = new System.Drawing.Size(262, 27);
            this.comboBoxFiltrWyborOperacji.TabIndex = 3;
            this.comboBoxFiltrWyborOperacji.Text = "Wybierz operację";
            this.comboBoxFiltrWyborOperacji.Click += new System.EventHandler(this.comboBoxFiltrWyborOperacji_Click);
            // 
            // buttonUstawienia
            // 
            this.buttonUstawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUstawienia.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUstawienia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUstawienia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUstawienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUstawienia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUstawienia.Location = new System.Drawing.Point(1260, 0);
            this.buttonUstawienia.Name = "buttonUstawienia";
            this.buttonUstawienia.Size = new System.Drawing.Size(150, 34);
            this.buttonUstawienia.TabIndex = 1;
            this.buttonUstawienia.Text = "Ustawienia";
            this.buttonUstawienia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUstawienia.UseVisualStyleBackColor = true;
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyloguj.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWyloguj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWyloguj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyloguj.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyloguj.Location = new System.Drawing.Point(1426, 0);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(150, 34);
            this.buttonWyloguj.TabIndex = 0;
            this.buttonWyloguj.Text = "Wyloguj się";
            this.buttonWyloguj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            // 
            // splitContainerSaldo
            // 
            this.splitContainerSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSaldo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSaldo.IsSplitterFixed = true;
            this.splitContainerSaldo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSaldo.Name = "splitContainerSaldo";
            this.splitContainerSaldo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSaldo.Panel1
            // 
            this.splitContainerSaldo.Panel1.Controls.Add(this.labelInfoKalendarz);
            this.splitContainerSaldo.Panel1.Controls.Add(this.chartGlowny);
            this.splitContainerSaldo.Panel1.Controls.Add(this.listViewGlowne);
            this.splitContainerSaldo.Panel1.Controls.Add(this.listViewGlowny);
            // 
            // splitContainerSaldo.Panel2
            // 
            this.splitContainerSaldo.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerSaldo.Size = new System.Drawing.Size(991, 748);
            this.splitContainerSaldo.SplitterDistance = 650;
            this.splitContainerSaldo.TabIndex = 0;
            // 
            // labelInfoKalendarz
            // 
            this.labelInfoKalendarz.AutoSize = true;
            this.labelInfoKalendarz.BackColor = System.Drawing.Color.White;
            this.labelInfoKalendarz.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoKalendarz.Location = new System.Drawing.Point(250, 300);
            this.labelInfoKalendarz.Name = "labelInfoKalendarz";
            this.labelInfoKalendarz.Size = new System.Drawing.Size(994, 49);
            this.labelInfoKalendarz.TabIndex = 4;
            this.labelInfoKalendarz.Text = "KALENDARZ W TRAKCIE PRZYGOTOWYWANIA";
            this.labelInfoKalendarz.Visible = false;
            // 
            // chartGlowny
            // 
            chartArea44.Name = "ChartArea1";
            this.chartGlowny.ChartAreas.Add(chartArea44);
            this.chartGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            legend44.Name = "Legend1";
            this.chartGlowny.Legends.Add(legend44);
            this.chartGlowny.Location = new System.Drawing.Point(0, 0);
            this.chartGlowny.Name = "chartGlowny";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series44.Legend = "Legend1";
            series44.Name = "Series1";
            this.chartGlowny.Series.Add(series44);
            this.chartGlowny.Size = new System.Drawing.Size(991, 650);
            this.chartGlowny.TabIndex = 3;
            this.chartGlowny.Text = "chart1";
            this.chartGlowny.Visible = false;
            // 
            // listViewGlowne
            // 
            this.listViewGlowne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnOperacj,
            this.columnKwota,
            this.columnData,
            this.columnKategoria,
            this.columnOpis});
            this.listViewGlowne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGlowne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewGlowne.GridLines = true;
            this.listViewGlowne.HideSelection = false;
            this.listViewGlowne.Location = new System.Drawing.Point(0, 0);
            this.listViewGlowne.Name = "listViewGlowne";
            this.listViewGlowne.Size = new System.Drawing.Size(991, 650);
            this.listViewGlowne.TabIndex = 2;
            this.listViewGlowne.UseCompatibleStateImageBehavior = false;
            this.listViewGlowne.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "";
            this.ID.Width = 0;
            // 
            // columnOperacj
            // 
            this.columnOperacj.Text = "Operacja";
            this.columnOperacj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOperacj.Width = 200;
            // 
            // columnKwota
            // 
            this.columnKwota.Text = "Kwota";
            this.columnKwota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnKwota.Width = 200;
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            this.columnData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnData.Width = 200;
            // 
            // columnKategoria
            // 
            this.columnKategoria.Text = "Kategoria";
            this.columnKategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnKategoria.Width = 200;
            // 
            // columnOpis
            // 
            this.columnOpis.Text = "Opis";
            this.columnOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOpis.Width = 200;
            // 
            // listViewGlowny
            // 
            this.listViewGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGlowny.HideSelection = false;
            this.listViewGlowny.Location = new System.Drawing.Point(0, 0);
            this.listViewGlowny.Name = "listViewGlowny";
            this.listViewGlowny.Size = new System.Drawing.Size(991, 650);
            this.listViewGlowny.TabIndex = 0;
            this.listViewGlowny.UseCompatibleStateImageBehavior = false;
            // 
            // checkBoxCykliczny
            // 
            this.checkBoxCykliczny.AutoSize = true;
            this.checkBoxCykliczny.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.moneyScreen;
            this.checkBoxCykliczny.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCykliczny.Location = new System.Drawing.Point(54, 24);
            this.checkBoxCykliczny.Name = "checkBoxCykliczny";
            this.checkBoxCykliczny.Size = new System.Drawing.Size(254, 23);
            this.checkBoxCykliczny.TabIndex = 7;
            this.checkBoxCykliczny.Text = "Ustaw jako przychód cykliczny";
            this.checkBoxCykliczny.UseVisualStyleBackColor = true;
            // 
            // pictureBoxWyloguj
            // 
            this.pictureBoxWyloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWyloguj.Image = global::WindowsFormsApp2.Properties.Resources.logOutIcon;
            this.pictureBoxWyloguj.Location = new System.Drawing.Point(1432, 4);
            this.pictureBoxWyloguj.Name = "pictureBoxWyloguj";
            this.pictureBoxWyloguj.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxWyloguj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWyloguj.TabIndex = 23;
            this.pictureBoxWyloguj.TabStop = false;
            // 
            // pictureBoxUstawienia
            // 
            this.pictureBoxUstawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUstawienia.Image = global::WindowsFormsApp2.Properties.Resources.SettingIcon;
            this.pictureBoxUstawienia.Location = new System.Drawing.Point(1270, 5);
            this.pictureBoxUstawienia.Name = "pictureBoxUstawienia";
            this.pictureBoxUstawienia.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxUstawienia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUstawienia.TabIndex = 8;
            this.pictureBoxUstawienia.TabStop = false;
            // 
            // panelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 832);
            this.Controls.Add(this.splitContainerGlowny);
            this.Name = "panelGlowny";
            this.Text = "panelGlowny";
            this.Activated += new System.EventHandler(this.panelGlowny_Activated);
            this.Load += new System.EventHandler(this.panelGlowny_Load);
            this.splitContainerGlowny.Panel1.ResumeLayout(false);
            this.splitContainerGlowny.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlowny)).EndInit();
            this.splitContainerGlowny.ResumeLayout(false);
            this.splitContainerMenuBoczne.Panel1.ResumeLayout(false);
            this.splitContainerMenuBoczne.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczne)).EndInit();
            this.splitContainerMenuBoczne.ResumeLayout(false);
            this.splitContainerMenuBoczneWidok.Panel1.ResumeLayout(false);
            this.splitContainerMenuBoczneWidok.Panel1.PerformLayout();
            this.splitContainerMenuBoczneWidok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).EndInit();
            this.splitContainerMenuBoczneWidok.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.PerformLayout();
            this.splitContainerFiltr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).EndInit();
            this.splitContainerFiltr.ResumeLayout(false);
            this.splitContainerSaldo.Panel1.ResumeLayout(false);
            this.splitContainerSaldo.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaldo)).EndInit();
            this.splitContainerSaldo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGlowny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWyloguj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUstawienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGlowny;
        private System.Windows.Forms.SplitContainer splitContainerMenuBoczne;
        private System.Windows.Forms.SplitContainer splitContainerMenuBoczneWidok;
        private System.Windows.Forms.SplitContainer splitContainerFiltr;
        private System.Windows.Forms.Button buttonDodajWydatek;
        private System.Windows.Forms.Button buttonDodajPrzychód;
        private System.Windows.Forms.RichTextBox richTextBoxDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePickerDodajOperacje;
        private System.Windows.Forms.TextBox textBoxDodajKwote;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxCykliczny;
        private System.Windows.Forms.SplitContainer splitContainerSaldo;
        private System.Windows.Forms.Button buttonUstawienia;
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.ComboBox comboBoxFiltrWyborOperacji;
        private System.Windows.Forms.Label labelDoData;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltrDo;
        private System.Windows.Forms.Label labelOdData;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltrOd;
        private System.Windows.Forms.CheckBox checkBoxFiltrZaawansowany;
        private System.Windows.Forms.Label labelSzukajWOpisie;
        private System.Windows.Forms.TextBox textBoxFiltrKwotaDo;
        private System.Windows.Forms.TextBox textBoxFiltrKwotaOd;
        private System.Windows.Forms.ComboBox comboBoxFiltrKategoria;
        private System.Windows.Forms.Label labelDoKwota;
        private System.Windows.Forms.Label labelOdKwota;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.TextBox textBoxSzukajWOpisie;
        private System.Windows.Forms.ListView listViewGlowny;
        private System.Windows.Forms.Button buttonWidokKalendarz;
        private System.Windows.Forms.Button buttonWidokLiniowy;
        private System.Windows.Forms.Button buttonWidokKolumnowy;
        private System.Windows.Forms.Button buttonWidokKolowy;
        private System.Windows.Forms.ListView listViewGlowne;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGlowny;
        private System.Windows.Forms.Label labelInfoKalendarz;
        private System.Windows.Forms.ColumnHeader columnKwota;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.ColumnHeader columnKategoria;
        private System.Windows.Forms.ColumnHeader columnOpis;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnOperacj;
        private System.Windows.Forms.Button buttonWidokTabelka;
        private System.Windows.Forms.PictureBox pictureBoxUstawienia;
        private System.Windows.Forms.PictureBox pictureBoxWyloguj;
    }
}