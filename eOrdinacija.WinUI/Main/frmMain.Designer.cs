namespace eStudio.WinUI.Main
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSkladiste = new System.Windows.Forms.Button();
            this.btnNabavke = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnPacijenti = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUsluge = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(8, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "eOrdinacija";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.btnLijekovi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSkladiste);
            this.panel1.Controls.Add(this.btnNabavke);
            this.panel1.Controls.Add(this.btnRezervacije);
            this.panel1.Controls.Add(this.btnPacijenti);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnUsluge);
            this.panel1.Controls.Add(this.btnZaposlenici);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 636);
            this.panel1.TabIndex = 16;
            // 
            // btnProfil
            // 
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfil.Image = global::eOrdinacija.WinUI.Properties.Resources.profile;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(12, 534);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(250, 50);
            this.btnProfil.TabIndex = 22;
            this.btnProfil.Text = " Profil";
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.FlatAppearance.BorderSize = 0;
            this.btnLijekovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLijekovi.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijekovi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLijekovi.Image = global::eOrdinacija.WinUI.Properties.Resources.medicine;
            this.btnLijekovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLijekovi.Location = new System.Drawing.Point(12, 484);
            this.btnLijekovi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(250, 50);
            this.btnLijekovi.TabIndex = 21;
            this.btnLijekovi.Text = " Lijekovi";
            this.btnLijekovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLijekovi.UseVisualStyleBackColor = true;
            this.btnLijekovi.Click += new System.EventHandler(this.btnLijekovi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eOrdinacija.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(41, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.FlatAppearance.BorderSize = 0;
            this.btnSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkladiste.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkladiste.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSkladiste.Image = global::eOrdinacija.WinUI.Properties.Resources.skladiste;
            this.btnSkladiste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkladiste.Location = new System.Drawing.Point(12, 434);
            this.btnSkladiste.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(250, 50);
            this.btnSkladiste.TabIndex = 19;
            this.btnSkladiste.Text = " Skladište";
            this.btnSkladiste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSkladiste.UseVisualStyleBackColor = true;
            this.btnSkladiste.Click += new System.EventHandler(this.btnSkladiste_Click);
            // 
            // btnNabavke
            // 
            this.btnNabavke.FlatAppearance.BorderSize = 0;
            this.btnNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNabavke.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNabavke.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNabavke.Image = global::eOrdinacija.WinUI.Properties.Resources.nabavke;
            this.btnNabavke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNabavke.Location = new System.Drawing.Point(12, 384);
            this.btnNabavke.Margin = new System.Windows.Forms.Padding(4);
            this.btnNabavke.Name = "btnNabavke";
            this.btnNabavke.Size = new System.Drawing.Size(250, 50);
            this.btnNabavke.TabIndex = 18;
            this.btnNabavke.Text = " Nabavke";
            this.btnNabavke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNabavke.UseVisualStyleBackColor = true;
            this.btnNabavke.Click += new System.EventHandler(this.btnNabavke_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.FlatAppearance.BorderSize = 0;
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacije.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRezervacije.Image = global::eOrdinacija.WinUI.Properties.Resources.rezervacija;
            this.btnRezervacije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervacije.Location = new System.Drawing.Point(12, 284);
            this.btnRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(250, 50);
            this.btnRezervacije.TabIndex = 17;
            this.btnRezervacije.Text = " Rezervacije";
            this.btnRezervacije.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnPacijenti
            // 
            this.btnPacijenti.FlatAppearance.BorderSize = 0;
            this.btnPacijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacijenti.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacijenti.ForeColor = System.Drawing.Color.White;
            this.btnPacijenti.Image = global::eOrdinacija.WinUI.Properties.Resources.pacijenti;
            this.btnPacijenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacijenti.Location = new System.Drawing.Point(12, 234);
            this.btnPacijenti.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacijenti.Name = "btnPacijenti";
            this.btnPacijenti.Size = new System.Drawing.Size(250, 50);
            this.btnPacijenti.TabIndex = 16;
            this.btnPacijenti.Text = " Pacijenti";
            this.btnPacijenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacijenti.UseVisualStyleBackColor = true;
            this.btnPacijenti.Click += new System.EventHandler(this.btnPacijenti_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::eOrdinacija.WinUI.Properties.Resources.logout;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 584);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 50);
            this.button6.TabIndex = 15;
            this.button6.Text = "  Odjava";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUsluge
            // 
            this.btnUsluge.FlatAppearance.BorderSize = 0;
            this.btnUsluge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsluge.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsluge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsluge.Image = ((System.Drawing.Image)(resources.GetObject("btnUsluge.Image")));
            this.btnUsluge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsluge.Location = new System.Drawing.Point(12, 334);
            this.btnUsluge.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsluge.Name = "btnUsluge";
            this.btnUsluge.Size = new System.Drawing.Size(250, 50);
            this.btnUsluge.TabIndex = 10;
            this.btnUsluge.Text = " Usluge";
            this.btnUsluge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsluge.UseVisualStyleBackColor = true;
            this.btnUsluge.Click += new System.EventHandler(this.btnUsluge_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.FlatAppearance.BorderSize = 0;
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenici.ForeColor = System.Drawing.Color.White;
            this.btnZaposlenici.Image = global::eOrdinacija.WinUI.Properties.Resources.zaposlenici;
            this.btnZaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposlenici.Location = new System.Drawing.Point(12, 184);
            this.btnZaposlenici.Margin = new System.Windows.Forms.Padding(4);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(250, 50);
            this.btnZaposlenici.TabIndex = 13;
            this.btnZaposlenici.Text = " Zaposlenici";
            this.btnZaposlenici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(277, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 57);
            this.panel2.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(813, 23);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(0, 21);
            this.txtUsername.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(707, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dobrodošli, ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTitle.Location = new System.Drawing.Point(293, 92);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(0, 32);
            this.txtTitle.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1339, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1339, 636);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUsluge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button btnPacijenti;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Button btnNabavke;
        private System.Windows.Forms.Button btnSkladiste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnLijekovi;
    }
}



