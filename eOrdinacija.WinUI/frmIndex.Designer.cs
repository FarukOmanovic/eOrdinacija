namespace eOrdinacija.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviZaposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nabavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPregledaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.nabavkeToolStripMenuItem,
            this.lijekoviToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.preglediToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviZaposlenikToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviZaposlenikToolStripMenuItem
            // 
            this.noviZaposlenikToolStripMenuItem.Name = "noviZaposlenikToolStripMenuItem";
            this.noviZaposlenikToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.noviZaposlenikToolStripMenuItem.Text = "Novi zaposlenik";
            this.noviZaposlenikToolStripMenuItem.Click += new System.EventHandler(this.noviZaposlenikToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.klijentiToolStripMenuItem_Click_1);
            // 
            // nabavkeToolStripMenuItem
            // 
            this.nabavkeToolStripMenuItem.Name = "nabavkeToolStripMenuItem";
            this.nabavkeToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.nabavkeToolStripMenuItem.Text = "Nabavke";
            this.nabavkeToolStripMenuItem.Click += new System.EventHandler(this.nabavkeToolStripMenuItem_Click);
            // 
            // lijekoviToolStripMenuItem
            // 
            this.lijekoviToolStripMenuItem.Name = "lijekoviToolStripMenuItem";
            this.lijekoviToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.lijekoviToolStripMenuItem.Text = "Lijekovi";
            this.lijekoviToolStripMenuItem.Click += new System.EventHandler(this.lijekoviToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaRezervacijaToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            this.rezervacijeToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeToolStripMenuItem_Click);
            // 
            // novaRezervacijaToolStripMenuItem
            // 
            this.novaRezervacijaToolStripMenuItem.Name = "novaRezervacijaToolStripMenuItem";
            this.novaRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.novaRezervacijaToolStripMenuItem.Text = "Nova rezervacija";
            this.novaRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.novaRezervacijaToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPregledaToolStripMenuItem,
            this.noviPregledToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // listaPregledaToolStripMenuItem
            // 
            this.listaPregledaToolStripMenuItem.Name = "listaPregledaToolStripMenuItem";
            this.listaPregledaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaPregledaToolStripMenuItem.Text = "Lista pregleda";
            // 
            // noviPregledToolStripMenuItem
            // 
            this.noviPregledToolStripMenuItem.Name = "noviPregledToolStripMenuItem";
            this.noviPregledToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noviPregledToolStripMenuItem.Text = "Novi pregled";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviZaposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nabavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPregledaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviPregledToolStripMenuItem;
    }
}



