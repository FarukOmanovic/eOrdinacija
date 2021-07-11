namespace eOrdinacija.WinUI.Nabavka
{
    partial class frmNabavkaDetalji
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
            this.labelDatum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvNabavkaMaterijal = new System.Windows.Forms.DataGridView();
            this.StomatoloskiMaterijal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterijalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkaMaterijal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nabavka - ";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.Color.Transparent;
            this.labelDatum.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.ForeColor = System.Drawing.Color.White;
            this.labelDatum.Location = new System.Drawing.Point(185, 18);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(0, 34);
            this.labelDatum.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::eOrdinacija.WinUI.Properties.Resources.Close_16;
            this.button1.Location = new System.Drawing.Point(909, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvNabavkaMaterijal
            // 
            this.dgvNabavkaMaterijal.AllowUserToAddRows = false;
            this.dgvNabavkaMaterijal.AllowUserToDeleteRows = false;
            this.dgvNabavkaMaterijal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavkaMaterijal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNabavkaMaterijal.BackgroundColor = System.Drawing.Color.White;
            this.dgvNabavkaMaterijal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNabavkaMaterijal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvNabavkaMaterijal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkaMaterijal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNabavkaMaterijal.ColumnHeadersHeight = 50;
            this.dgvNabavkaMaterijal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StomatoloskiMaterijal,
            this.MaterijalId,
            this.Id,
            this.NabavkaId,
            this.Kolicina,
            this.UkupnaCijena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNabavkaMaterijal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNabavkaMaterijal.EnableHeadersVisualStyles = false;
            this.dgvNabavkaMaterijal.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNabavkaMaterijal.Location = new System.Drawing.Point(40, 84);
            this.dgvNabavkaMaterijal.Name = "dgvNabavkaMaterijal";
            this.dgvNabavkaMaterijal.ReadOnly = true;
            this.dgvNabavkaMaterijal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkaMaterijal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNabavkaMaterijal.RowHeadersVisible = false;
            this.dgvNabavkaMaterijal.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNabavkaMaterijal.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNabavkaMaterijal.RowTemplate.Height = 24;
            this.dgvNabavkaMaterijal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNabavkaMaterijal.Size = new System.Drawing.Size(855, 411);
            this.dgvNabavkaMaterijal.TabIndex = 18;
            // 
            // StomatoloskiMaterijal
            // 
            this.StomatoloskiMaterijal.DataPropertyName = "Materijal";
            this.StomatoloskiMaterijal.HeaderText = "Stomatološki materijal";
            this.StomatoloskiMaterijal.MinimumWidth = 6;
            this.StomatoloskiMaterijal.Name = "StomatoloskiMaterijal";
            this.StomatoloskiMaterijal.ReadOnly = true;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            this.UkupnaCijena.HeaderText = "Ukupna cijena";
            this.UkupnaCijena.MinimumWidth = 6;
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // frmNabavkaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eOrdinacija.WinUI.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 551);
            this.ControlBox = false;
            this.Controls.Add(this.dgvNabavkaMaterijal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNabavkaDetalji";
            this.Text = "frmNabavkaDetalji";
            this.Load += new System.EventHandler(this.frmNabavkaDetalji_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNabavkaDetalji_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNabavkaDetalji_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmNabavkaDetalji_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkaMaterijal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvNabavkaMaterijal;
        private System.Windows.Forms.DataGridViewTextBoxColumn StomatoloskiMaterijal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterijalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
    }
}