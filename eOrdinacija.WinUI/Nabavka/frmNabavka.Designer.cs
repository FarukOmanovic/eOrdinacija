namespace eOrdinacija.WinUI.Nabavka
{
    partial class frmNabavka
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
            this.dgvNabavke = new System.Windows.Forms.DataGridView();
            this.NabavkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNabavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovaNabavka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNabavke
            // 
            this.dgvNabavke.AccessibleName = "s";
            this.dgvNabavke.AllowUserToAddRows = false;
            this.dgvNabavke.AllowUserToDeleteRows = false;
            this.dgvNabavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavke.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNabavke.BackgroundColor = System.Drawing.Color.White;
            this.dgvNabavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNabavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvNabavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNabavke.ColumnHeadersHeight = 50;
            this.dgvNabavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NabavkaId,
            this.DatumNabavke,
            this.UkupanIznos,
            this.Zaposlenik});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNabavke.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNabavke.EnableHeadersVisualStyles = false;
            this.dgvNabavke.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNabavke.Location = new System.Drawing.Point(28, 155);
            this.dgvNabavke.Name = "dgvNabavke";
            this.dgvNabavke.ReadOnly = true;
            this.dgvNabavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavke.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNabavke.RowHeadersVisible = false;
            this.dgvNabavke.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavke.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNabavke.RowTemplate.Height = 24;
            this.dgvNabavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNabavke.Size = new System.Drawing.Size(1217, 411);
            this.dgvNabavke.TabIndex = 1;
            this.dgvNabavke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNabavke_MouseDoubleClick);
            // 
            // NabavkaId
            // 
            this.NabavkaId.DataPropertyName = "Id";
            this.NabavkaId.HeaderText = "NabavkaId";
            this.NabavkaId.MinimumWidth = 6;
            this.NabavkaId.Name = "NabavkaId";
            this.NabavkaId.ReadOnly = true;
            this.NabavkaId.Visible = false;
            // 
            // DatumNabavke
            // 
            this.DatumNabavke.DataPropertyName = "DatumNabavke";
            this.DatumNabavke.HeaderText = "Datum nabavke";
            this.DatumNabavke.MinimumWidth = 6;
            this.DatumNabavke.Name = "DatumNabavke";
            this.DatumNabavke.ReadOnly = true;
            // 
            // UkupanIznos
            // 
            this.UkupanIznos.DataPropertyName = "UkupanIznos";
            this.UkupanIznos.HeaderText = "Ukupan iznos";
            this.UkupanIznos.MinimumWidth = 6;
            this.UkupanIznos.Name = "UkupanIznos";
            this.UkupanIznos.ReadOnly = true;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.DataPropertyName = "Zaposlenik";
            this.Zaposlenik.HeaderText = "Evidentirao zaposlenik";
            this.Zaposlenik.MinimumWidth = 6;
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            // 
            // btnNovaNabavka
            // 
            this.btnNovaNabavka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.btnNovaNabavka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaNabavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaNabavka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaNabavka.ForeColor = System.Drawing.Color.White;
            this.btnNovaNabavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaNabavka.Location = new System.Drawing.Point(28, 77);
            this.btnNovaNabavka.Name = "btnNovaNabavka";
            this.btnNovaNabavka.Size = new System.Drawing.Size(193, 50);
            this.btnNovaNabavka.TabIndex = 5;
            this.btnNovaNabavka.Text = "Nova nabavka";
            this.btnNovaNabavka.UseVisualStyleBackColor = false;
            this.btnNovaNabavka.Click += new System.EventHandler(this.btnNovaNabavka_Click);
            // 
            // frmNabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::eOrdinacija.WinUI.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 676);
            this.ControlBox = false;
            this.Controls.Add(this.btnNovaNabavka);
            this.Controls.Add(this.dgvNabavke);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNabavka";
            this.Text = "frmNabavka";
            this.Load += new System.EventHandler(this.frmNabavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanIznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik;
        private System.Windows.Forms.Button btnNovaNabavka;
    }
}