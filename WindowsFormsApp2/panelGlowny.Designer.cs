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
            this.splitContainerGlowny = new System.Windows.Forms.SplitContainer();
            this.splitContainerMenuBoczne = new System.Windows.Forms.SplitContainer();
            this.splitContainerMenuBoczneWidok = new System.Windows.Forms.SplitContainer();
            this.splitContainerFiltr = new System.Windows.Forms.SplitContainer();
            this.buttonDodajPrzychód = new System.Windows.Forms.Button();
            this.buttonDodajWydatek = new System.Windows.Forms.Button();
            this.textBoxDodajKwote = new System.Windows.Forms.TextBox();
            this.dateTimePickerDodajOperacje = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDodaj = new System.Windows.Forms.RichTextBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.splitContainerSaldo = new System.Windows.Forms.SplitContainer();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonUstawienia = new System.Windows.Forms.Button();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltrWyborOperacji = new System.Windows.Forms.ComboBox();
            this.labelDoData = new System.Windows.Forms.Label();
            this.dateTimePickerFiltrDo = new System.Windows.Forms.DateTimePicker();
            this.labelOdData = new System.Windows.Forms.Label();
            this.dateTimePickerFiltrOd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFiltrZaawansowany = new System.Windows.Forms.CheckBox();
            this.labelOdKwota = new System.Windows.Forms.Label();
            this.labelDoKwota = new System.Windows.Forms.Label();
            this.comboBoxFiltrKategoria = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrKwotaOd = new System.Windows.Forms.TextBox();
            this.textBoxFiltrKwotaDo = new System.Windows.Forms.TextBox();
            this.labelSzukajWOpisie = new System.Windows.Forms.Label();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.textBoxSzukajWOpisie = new System.Windows.Forms.TextBox();
            this.listViewGlowny = new System.Windows.Forms.ListView();
            this.checkBoxCykliczny = new System.Windows.Forms.CheckBox();
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
            this.splitContainerMenuBoczneWidok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).BeginInit();
            this.splitContainerFiltr.Panel1.SuspendLayout();
            this.splitContainerFiltr.Panel2.SuspendLayout();
            this.splitContainerFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaldo)).BeginInit();
            this.splitContainerSaldo.Panel1.SuspendLayout();
            this.splitContainerSaldo.SuspendLayout();
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
            this.splitContainerGlowny.SplitterDistance = 367;
            this.splitContainerGlowny.TabIndex = 0;
            // 
            // splitContainerMenuBoczne
            // 
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
            this.splitContainerMenuBoczne.Size = new System.Drawing.Size(367, 832);
            this.splitContainerMenuBoczne.SplitterDistance = 200;
            this.splitContainerMenuBoczne.TabIndex = 0;
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
            this.splitContainerMenuBoczneWidok.Panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.moneyScreen;
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
            this.splitContainerMenuBoczneWidok.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitContainerMenuBoczneWidok.Size = new System.Drawing.Size(367, 628);
            this.splitContainerMenuBoczneWidok.SplitterDistance = 340;
            this.splitContainerMenuBoczneWidok.TabIndex = 0;
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
            this.splitContainerFiltr.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.splitContainerFiltr.Size = new System.Drawing.Size(974, 832);
            this.splitContainerFiltr.SplitterDistance = 80;
            this.splitContainerFiltr.TabIndex = 0;
            // 
            // buttonDodajPrzychód
            // 
            this.buttonDodajPrzychód.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajPrzychód.Location = new System.Drawing.Point(54, 41);
            this.buttonDodajPrzychód.Name = "buttonDodajPrzychód";
            this.buttonDodajPrzychód.Size = new System.Drawing.Size(372, 76);
            this.buttonDodajPrzychód.TabIndex = 0;
            this.buttonDodajPrzychód.Text = "Dodaj przychód";
            this.buttonDodajPrzychód.UseVisualStyleBackColor = true;
            // 
            // buttonDodajWydatek
            // 
            this.buttonDodajWydatek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWydatek.Location = new System.Drawing.Point(54, 140);
            this.buttonDodajWydatek.Name = "buttonDodajWydatek";
            this.buttonDodajWydatek.Size = new System.Drawing.Size(372, 76);
            this.buttonDodajWydatek.TabIndex = 1;
            this.buttonDodajWydatek.Text = "Dodaj wydatek";
            this.buttonDodajWydatek.UseVisualStyleBackColor = true;
            // 
            // textBoxDodajKwote
            // 
            this.textBoxDodajKwote.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDodajKwote.Location = new System.Drawing.Point(54, 64);
            this.textBoxDodajKwote.Name = "textBoxDodajKwote";
            this.textBoxDodajKwote.Size = new System.Drawing.Size(372, 28);
            this.textBoxDodajKwote.TabIndex = 1;
            // 
            // dateTimePickerDodajOperacje
            // 
            this.dateTimePickerDodajOperacje.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDodajOperacje.Location = new System.Drawing.Point(54, 109);
            this.dateTimePickerDodajOperacje.Name = "dateTimePickerDodajOperacje";
            this.dateTimePickerDodajOperacje.Size = new System.Drawing.Size(372, 28);
            this.dateTimePickerDodajOperacje.TabIndex = 2;
            // 
            // richTextBoxDodaj
            // 
            this.richTextBoxDodaj.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDodaj.Location = new System.Drawing.Point(54, 202);
            this.richTextBoxDodaj.Name = "richTextBoxDodaj";
            this.richTextBoxDodaj.Size = new System.Drawing.Size(372, 70);
            this.richTextBoxDodaj.TabIndex = 4;
            this.richTextBoxDodaj.Text = "";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisz.Location = new System.Drawing.Point(254, 306);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(172, 43);
            this.buttonZapisz.TabIndex = 5;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(51, 306);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(172, 43);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Resetuj";
            this.buttonReset.UseVisualStyleBackColor = true;
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
            this.splitContainerSaldo.Panel1.Controls.Add(this.listViewGlowny);
            // 
            // splitContainerSaldo.Panel2
            // 
            this.splitContainerSaldo.Panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainerSaldo.Size = new System.Drawing.Size(974, 748);
            this.splitContainerSaldo.SplitterDistance = 650;
            this.splitContainerSaldo.TabIndex = 0;
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyloguj.Location = new System.Drawing.Point(1390, 0);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(155, 34);
            this.buttonWyloguj.TabIndex = 0;
            this.buttonWyloguj.Text = "Wyloguj się";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            // 
            // buttonUstawienia
            // 
            this.buttonUstawienia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUstawienia.Location = new System.Drawing.Point(1220, 0);
            this.buttonUstawienia.Name = "buttonUstawienia";
            this.buttonUstawienia.Size = new System.Drawing.Size(155, 34);
            this.buttonUstawienia.TabIndex = 1;
            this.buttonUstawienia.Text = "Ustawienia";
            this.buttonUstawienia.UseVisualStyleBackColor = true;
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(54, 154);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(372, 29);
            this.comboBoxKategoria.TabIndex = 2;
            // 
            // comboBoxFiltrWyborOperacji
            // 
            this.comboBoxFiltrWyborOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrWyborOperacji.FormattingEnabled = true;
            this.comboBoxFiltrWyborOperacji.Location = new System.Drawing.Point(61, 52);
            this.comboBoxFiltrWyborOperacji.Name = "comboBoxFiltrWyborOperacji";
            this.comboBoxFiltrWyborOperacji.Size = new System.Drawing.Size(262, 27);
            this.comboBoxFiltrWyborOperacji.TabIndex = 3;
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
            // labelOdKwota
            // 
            this.labelOdKwota.AutoSize = true;
            this.labelOdKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdKwota.Location = new System.Drawing.Point(341, 109);
            this.labelOdKwota.Name = "labelOdKwota";
            this.labelOdKwota.Size = new System.Drawing.Size(36, 22);
            this.labelOdKwota.TabIndex = 15;
            this.labelOdKwota.Text = "Od";
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
            // comboBoxFiltrKategoria
            // 
            this.comboBoxFiltrKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrKategoria.FormattingEnabled = true;
            this.comboBoxFiltrKategoria.Location = new System.Drawing.Point(61, 105);
            this.comboBoxFiltrKategoria.Name = "comboBoxFiltrKategoria";
            this.comboBoxFiltrKategoria.Size = new System.Drawing.Size(262, 27);
            this.comboBoxFiltrKategoria.TabIndex = 17;
            // 
            // textBoxFiltrKwotaOd
            // 
            this.textBoxFiltrKwotaOd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFiltrKwotaOd.Location = new System.Drawing.Point(394, 105);
            this.textBoxFiltrKwotaOd.Name = "textBoxFiltrKwotaOd";
            this.textBoxFiltrKwotaOd.Size = new System.Drawing.Size(192, 27);
            this.textBoxFiltrKwotaOd.TabIndex = 18;
            // 
            // textBoxFiltrKwotaDo
            // 
            this.textBoxFiltrKwotaDo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFiltrKwotaDo.Location = new System.Drawing.Point(650, 105);
            this.textBoxFiltrKwotaDo.Name = "textBoxFiltrKwotaDo";
            this.textBoxFiltrKwotaDo.Size = new System.Drawing.Size(192, 27);
            this.textBoxFiltrKwotaDo.TabIndex = 19;
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
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszukaj.Location = new System.Drawing.Point(1232, 105);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(212, 29);
            this.buttonWyszukaj.TabIndex = 21;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            // 
            // textBoxSzukajWOpisie
            // 
            this.textBoxSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukajWOpisie.Location = new System.Drawing.Point(1015, 105);
            this.textBoxSzukajWOpisie.Name = "textBoxSzukajWOpisie";
            this.textBoxSzukajWOpisie.Size = new System.Drawing.Size(192, 27);
            this.textBoxSzukajWOpisie.TabIndex = 22;
            // 
            // listViewGlowny
            // 
            this.listViewGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGlowny.HideSelection = false;
            this.listViewGlowny.Location = new System.Drawing.Point(0, 0);
            this.listViewGlowny.Name = "listViewGlowny";
            this.listViewGlowny.Size = new System.Drawing.Size(974, 650);
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
            // panelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 832);
            this.Controls.Add(this.splitContainerGlowny);
            this.Name = "panelGlowny";
            this.Text = "panelGlowny";
            this.Activated += new System.EventHandler(this.panelGlowny_Activated);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).EndInit();
            this.splitContainerMenuBoczneWidok.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.PerformLayout();
            this.splitContainerFiltr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).EndInit();
            this.splitContainerFiltr.ResumeLayout(false);
            this.splitContainerSaldo.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaldo)).EndInit();
            this.splitContainerSaldo.ResumeLayout(false);
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
    }
}