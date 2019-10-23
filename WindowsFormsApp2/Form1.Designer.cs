namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_register = new System.Windows.Forms.GroupBox();
            this.button_back = new System.Windows.Forms.Button();
            this.label_majatek = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_majatek = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.linkLabel_register = new System.Windows.Forms.LinkLabel();
            this.linkLabel_forgot = new System.Windows.Forms.LinkLabel();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.button_zaloguj = new System.Windows.Forms.Button();
            this.textBox_password1 = new System.Windows.Forms.TextBox();
            this.label_password1 = new System.Windows.Forms.Label();
            this.textBox_login1 = new System.Windows.Forms.TextBox();
            this.label_login1 = new System.Windows.Forms.Label();
            this.groupBox_register.SuspendLayout();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_register
            // 
            this.groupBox_register.AutoSize = true;
            this.groupBox_register.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_register.Controls.Add(this.button_back);
            this.groupBox_register.Controls.Add(this.label_majatek);
            this.groupBox_register.Controls.Add(this.label_surname);
            this.groupBox_register.Controls.Add(this.label_name);
            this.groupBox_register.Controls.Add(this.label_email);
            this.groupBox_register.Controls.Add(this.textBox_majatek);
            this.groupBox_register.Controls.Add(this.textBox_surname);
            this.groupBox_register.Controls.Add(this.textBox_name);
            this.groupBox_register.Controls.Add(this.textBox_email);
            this.groupBox_register.Controls.Add(this.label_password);
            this.groupBox_register.Controls.Add(this.label_login);
            this.groupBox_register.Controls.Add(this.button_register);
            this.groupBox_register.Controls.Add(this.textBox_password);
            this.groupBox_register.Controls.Add(this.textBox_login);
            this.groupBox_register.Location = new System.Drawing.Point(512, 91);
            this.groupBox_register.Name = "groupBox_register";
            this.groupBox_register.Size = new System.Drawing.Size(403, 500);
            this.groupBox_register.TabIndex = 0;
            this.groupBox_register.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.Location = new System.Drawing.Point(192, 440);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 35);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "Powrót";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_majatek
            // 
            this.label_majatek.AutoSize = true;
            this.label_majatek.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_majatek.ForeColor = System.Drawing.SystemColors.Control;
            this.label_majatek.Location = new System.Drawing.Point(31, 363);
            this.label_majatek.Name = "label_majatek";
            this.label_majatek.Size = new System.Drawing.Size(99, 29);
            this.label_majatek.TabIndex = 14;
            this.label_majatek.Text = "Majątek";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_surname.ForeColor = System.Drawing.SystemColors.Control;
            this.label_surname.Location = new System.Drawing.Point(31, 294);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(115, 29);
            this.label_surname.TabIndex = 13;
            this.label_surname.Text = "Nazwisko";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.SystemColors.Control;
            this.label_name.Location = new System.Drawing.Point(31, 225);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(62, 29);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Imie";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email.ForeColor = System.Drawing.SystemColors.Control;
            this.label_email.Location = new System.Drawing.Point(31, 156);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(85, 29);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-mail";
            // 
            // textBox_majatek
            // 
            this.textBox_majatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_majatek.Location = new System.Drawing.Point(36, 395);
            this.textBox_majatek.Name = "textBox_majatek";
            this.textBox_majatek.Size = new System.Drawing.Size(273, 34);
            this.textBox_majatek.TabIndex = 10;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_surname.Location = new System.Drawing.Point(36, 326);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(273, 34);
            this.textBox_surname.TabIndex = 9;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_name.Location = new System.Drawing.Point(36, 257);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(273, 34);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_email.Location = new System.Drawing.Point(36, 188);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(273, 34);
            this.textBox_email.TabIndex = 7;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.ForeColor = System.Drawing.SystemColors.Control;
            this.label_password.Location = new System.Drawing.Point(31, 87);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(115, 29);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login.ForeColor = System.Drawing.SystemColors.Control;
            this.label_login.Location = new System.Drawing.Point(31, 18);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(73, 29);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Login";
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.SystemColors.Control;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_register.Location = new System.Drawing.Point(36, 440);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(150, 35);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "Zarejestruj";
            this.button_register.UseVisualStyleBackColor = false;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_password.Location = new System.Drawing.Point(36, 119);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(273, 34);
            this.textBox_password.TabIndex = 1;
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login.Location = new System.Drawing.Point(36, 50);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(273, 34);
            this.textBox_login.TabIndex = 0;
            // 
            // linkLabel_register
            // 
            this.linkLabel_register.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel_register.AutoSize = true;
            this.linkLabel_register.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel_register.LinkColor = System.Drawing.Color.White;
            this.linkLabel_register.Location = new System.Drawing.Point(28, 227);
            this.linkLabel_register.Name = "linkLabel_register";
            this.linkLabel_register.Size = new System.Drawing.Size(115, 20);
            this.linkLabel_register.TabIndex = 6;
            this.linkLabel_register.TabStop = true;
            this.linkLabel_register.Text = "Zarejestruj się";
            this.linkLabel_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_LinkClicked);
            // 
            // linkLabel_forgot
            // 
            this.linkLabel_forgot.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel_forgot.AutoSize = true;
            this.linkLabel_forgot.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel_forgot.LinkColor = System.Drawing.Color.White;
            this.linkLabel_forgot.Location = new System.Drawing.Point(28, 197);
            this.linkLabel_forgot.Name = "linkLabel_forgot";
            this.linkLabel_forgot.Size = new System.Drawing.Size(158, 20);
            this.linkLabel_forgot.TabIndex = 5;
            this.linkLabel_forgot.TabStop = true;
            this.linkLabel_forgot.Text = "Zapomniałem hasło";
            this.linkLabel_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgot_LinkClicked);
            // 
            // groupBox_login
            // 
            this.groupBox_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_login.Controls.Add(this.button_zaloguj);
            this.groupBox_login.Controls.Add(this.linkLabel_register);
            this.groupBox_login.Controls.Add(this.linkLabel_forgot);
            this.groupBox_login.Controls.Add(this.textBox_password1);
            this.groupBox_login.Controls.Add(this.label_password1);
            this.groupBox_login.Controls.Add(this.textBox_login1);
            this.groupBox_login.Controls.Add(this.label_login1);
            this.groupBox_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_login.Location = new System.Drawing.Point(27, 91);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(400, 280);
            this.groupBox_login.TabIndex = 16;
            this.groupBox_login.TabStop = false;
            // 
            // button_zaloguj
            // 
            this.button_zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zaloguj.Location = new System.Drawing.Point(28, 159);
            this.button_zaloguj.Name = "button_zaloguj";
            this.button_zaloguj.Size = new System.Drawing.Size(100, 35);
            this.button_zaloguj.TabIndex = 4;
            this.button_zaloguj.Text = "Zaloguj";
            this.button_zaloguj.UseVisualStyleBackColor = true;
            // 
            // textBox_password1
            // 
            this.textBox_password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_password1.Location = new System.Drawing.Point(28, 119);
            this.textBox_password1.Name = "textBox_password1";
            this.textBox_password1.Size = new System.Drawing.Size(273, 34);
            this.textBox_password1.TabIndex = 3;
            // 
            // label_password1
            // 
            this.label_password1.AutoSize = true;
            this.label_password1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password1.ForeColor = System.Drawing.SystemColors.Control;
            this.label_password1.Location = new System.Drawing.Point(27, 87);
            this.label_password1.Name = "label_password1";
            this.label_password1.Size = new System.Drawing.Size(75, 29);
            this.label_password1.TabIndex = 2;
            this.label_password1.Text = "Hasło";
            // 
            // textBox_login1
            // 
            this.textBox_login1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login1.Location = new System.Drawing.Point(28, 50);
            this.textBox_login1.Name = "textBox_login1";
            this.textBox_login1.Size = new System.Drawing.Size(273, 34);
            this.textBox_login1.TabIndex = 1;
            // 
            // label_login1
            // 
            this.label_login1.AutoSize = true;
            this.label_login1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login1.ForeColor = System.Drawing.SystemColors.Control;
            this.label_login1.Location = new System.Drawing.Point(27, 18);
            this.label_login1.Name = "label_login1";
            this.label_login1.Size = new System.Drawing.Size(73, 29);
            this.label_login1.TabIndex = 0;
            this.label_login1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 778);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.groupBox_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox_register.ResumeLayout(false);
            this.groupBox_register.PerformLayout();
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_register;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.LinkLabel linkLabel_forgot;
        private System.Windows.Forms.LinkLabel linkLabel_register;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_majatek;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_majatek;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.Button button_zaloguj;
        private System.Windows.Forms.TextBox textBox_password1;
        private System.Windows.Forms.Label label_password1;
        private System.Windows.Forms.TextBox textBox_login1;
        private System.Windows.Forms.Label label_login1;
    }
}

