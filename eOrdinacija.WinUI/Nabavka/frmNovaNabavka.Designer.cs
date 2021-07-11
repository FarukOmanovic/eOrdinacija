namespace eOrdinacija.WinUI.Nabavka
{
    partial class frmNovaNabavka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMaterijali = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericKolicina = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvNabavkaMaterijali = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterijalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StomatoloskiMaterijal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNoviMaterijal = new System.Windows.Forms.Button();
            this.btnZakljuci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkaMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nova nabavka";
            // 
            // comboBoxMaterijali
            // 
            this.comboBoxMaterijali.FormattingEnabled = true;
            this.comboBoxMaterijali.Location = new System.Drawing.Point(139, 136);
            this.comboBoxMaterijali.Name = "comboBoxMaterijali";
            this.comboBoxMaterijali.Size = new System.Drawing.Size(180, 24);
            this.comboBoxMaterijali.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Materijal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(328, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Količina";
            // 
            // numericKolicina
            // 
            this.numericKolicina.Location = new System.Drawing.Point(424, 136);
            this.numericKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKolicina.Name = "numericKolicina";
            this.numericKolicina.Size = new System.Drawing.Size(211, 22);
            this.numericKolicina.TabIndex = 14;
            this.numericKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::eOrdinacija.WinUI.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(657, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::eOrdinacija.WinUI.Properties.Resources.Close_16;
            this.button1.Location = new System.Drawing.Point(719, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvNabavkaMaterijali
            // 
            this.dgvNabavkaMaterijali.AccessibleName = "";
            this.dgvNabavkaMaterijali.AllowUserToAddRows = false;
            this.dgvNabavkaMaterijali.AllowUserToDeleteRows = false;
            this.dgvNabavkaMaterijali.AllowUserToResizeColumns = false;
            this.dgvNabavkaMaterijali.AllowUserToResizeRows = false;
            this.dgvNabavkaMaterijali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavkaMaterijali.BackgroundColor = System.Drawing.Color.White;
            this.dgvNabavkaMaterijali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNabavkaMaterijali.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvNabavkaMaterijali.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkaMaterijali.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNabavkaMaterijali.ColumnHeadersHeight = 50;
            this.dgvNabavkaMaterijali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MaterijalId,
            this.NabavkaId,
            this.StomatoloskiMaterijal,
            this.Kolicina,
            this.UkupnaCijena});
            this.dgvNabavkaMaterijali.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNabavkaMaterijali.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNabavkaMaterijali.EnableHeadersVisualStyles = false;
            this.dgvNabavkaMaterijali.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNabavkaMaterijali.Location = new System.Drawing.Point(30, 190);
            this.dgvNabavkaMaterijali.Name = "dgvNabavkaMaterijali";
            this.dgvNabavkaMaterijali.ReadOnly = true;
            this.dgvNabavkaMaterijali.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkaMaterijali.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNabavkaMaterijali.RowHeadersVisible = false;
            this.dgvNabavkaMaterijali.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkaMaterijali.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNabavkaMaterijali.RowTemplate.Height = 24;
            this.dgvNabavkaMaterijali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNabavkaMaterijali.Size = new System.Drawing.Size(690, 357);
            this.dgvNabavkaMaterijali.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // MaterijalId
            // 
            this.MaterijalId.DataPropertyName = "MaterijalId";
            this.MaterijalId.HeaderText = "MaterijalId";
            this.MaterijalId.MinimumWidth = 6;
            this.MaterijalId.Name = "MaterijalId";
            this.MaterijalId.ReadOnly = true;
            this.MaterijalId.Visible = false;
            // 
            // NabavkaId
            // 
            this.NabavkaId.DataPropertyName = "NabavkaId";
            this.NabavkaId.HeaderText = "NabavkaId";
            this.NabavkaId.MinimumWidth = 6;
            this.NabavkaId.Name = "NabavkaId";
            this.NabavkaId.ReadOnly = true;
            this.NabavkaId.Visible = false;
            // 
            // StomatoloskiMaterijal
            // 
            this.StomatoloskiMaterijal.DataPropertyName = "Materijal";
            this.StomatoloskiMaterijal.HeaderText = "Stomatološki materijal";
            this.StomatoloskiMaterijal.MinimumWidth = 6;
            this.StomatoloskiMaterijal.Name = "StomatoloskiMaterijal";
            this.StomatoloskiMaterijal.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna Cijena";
            this.UkupnaCijena.MinimumWidth = 6;
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // btnNoviMaterijal
            // 
            this.btnNoviMaterijal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.btnNoviMaterijal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNoviMaterijal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviMaterijal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviMaterijal.ForeColor = System.Drawing.Color.White;
            this.btnNoviMaterijal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviMaterijal.Location = new System.Drawing.Point(30, 71);
            this.btnNoviMaterijal.Name = "btnNoviMaterijal";
            this.btnNoviMaterijal.Size = new System.Drawing.Size(193, 43);
            this.btnNoviMaterijal.TabIndex = 20;
            this.btnNoviMaterijal.Text = "Novi materijal";
            this.btnNoviMaterijal.UseVisualStyleBackColor = false;
            this.btnNoviMaterijal.Click += new System.EventHandler(this.btnNoviMaterijal_Click);
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.BackColor = System.Drawing.Color.Green;
            this.btnZakljuci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZakljuci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakljuci.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakljuci.ForeColor = System.Drawing.Color.White;
            this.btnZakljuci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakljuci.Location = new System.Drawing.Point(245, 71);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(193, 43);
            this.btnZakljuci.TabIndex = 21;
            this.btnZakljuci.Text = "Zaključi nabavku";
            this.btnZakljuci.UseVisualStyleBackColor = false;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // frmNovaNabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eOrdinacija.WinUI.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 574);
            this.ControlBox = false;
            this.Controls.Add(this.btnZakljuci);
            this.Controls.Add(this.btnNoviMaterijal);
            this.Controls.Add(this.dgvNabavkaMaterijali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMaterijali);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovaNabavka";
            this.Text = "frmNovaNabavka";
            this.Load += new System.EventHandler(this.frmNovaNabavka_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNovaNabavka_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNovaNabavka_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmNovaNabavka_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkaMaterijali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMaterijali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericKolicina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvNabavkaMaterijali;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterijalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StomatoloskiMaterijal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.Button btnNoviMaterijal;
        private System.Windows.Forms.Button btnZakljuci;
    }
}