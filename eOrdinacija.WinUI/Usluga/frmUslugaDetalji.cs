using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrdinacija.WinUI.Usluga
{
    public partial class frmUslugaDetalji : Form
    {
        private int? _id = null;
        private int? _idNew = null;
        private readonly APIService uslugaService = new APIService("Usluga");
        private readonly APIService ulogaService = new APIService("Uloga");
        private readonly APIService uslugaMaterijalService = new APIService("UslugaMaterijal");
        private readonly APIService materijalService = new APIService("StomatoloskiMaterijal");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmUslugaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length == 0 || txtCijena.Text.Length == 0 || txtOpis.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }
            var request = new UslugaInsertRequest
            {
                Naziv = txtNaziv.Text,
                Cijena = Decimal.Parse(txtCijena.Text),
                Opis = txtOpis.Text
            };

                if (_idNew==null && _id==null)
            {
                var usluga = await uslugaService.Insert<eOrdinacija.Model.Usluga>(request);
                _idNew = usluga.Id;
                dgvMaterijali.Enabled = true;
                btnNoviMaterijal.Enabled = true;
            }
            else
            {
                await uslugaService.Update<eOrdinacija.Model.Usluga>((int)(_idNew !=null?_idNew:_id), request);
            }
            
        }

        private async void frmUslugaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var usluga = await uslugaService.GetById<eOrdinacija.Model.Usluga>(_id);
                var stavke = await uslugaMaterijalService.GetByUsluga<List<eOrdinacija.Model.UslugaMaterijal>>(usluga.Id);
                foreach (var item in stavke)
                {
                    var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                    item.Materijal = materijal.Naziv;
                }
                txtNaziv.Text = usluga.Naziv;   
                txtCijena.Text = usluga.Cijena.ToString();
                txtOpis.Text = usluga.Opis;
                dgvMaterijali.DataSource = stavke;
                dgvMaterijali.AutoGenerateColumns = false;
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Akcija";
                deleteButton.Text = "Izbriši";
                deleteButton.UseColumnTextForButtonValue = true;
                dgvMaterijali.Columns.Add(deleteButton);
            }
            else
            {
                dgvMaterijali.Enabled = false;
                btnNoviMaterijal.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUslugaDetalji_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmUslugaDetalji_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmUslugaDetalji_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnNoviMaterijal_Click(object sender, EventArgs e)
        {
            frmUslugaMaterijali frm = new frmUslugaMaterijali(_idNew!=null?_idNew:_id);
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var usluga = await uslugaService.GetById<eOrdinacija.Model.Usluga>(_idNew!=null?_idNew:_id);
            var stavke = await uslugaMaterijalService.GetByUsluga<List<eOrdinacija.Model.UslugaMaterijal>>(usluga.Id);
            foreach (var item in stavke)
            {
                var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                item.Materijal = materijal.Naziv;
            }
            txtNaziv.Text = usluga.Naziv;
            txtCijena.Text = usluga.Cijena.ToString();
            txtOpis.Text = usluga.Opis;
            dgvMaterijali.DataSource = stavke;
            dgvMaterijali.AutoGenerateColumns = false;
            if (_idNew != null && dgvMaterijali.Rows.Count==1)
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Akcija";
                deleteButton.Text = "Izbriši";
                deleteButton.UseColumnTextForButtonValue = true;
                dgvMaterijali.Columns.Add(deleteButton);
            }
        }

            private async void dgvMaterijali_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvMaterijali.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dgvMaterijali.Columns["dataGridViewDeleteButton"].Index)
            {
                var id = dgvMaterijali.SelectedRows[0].Cells[0].Value;
                uslugaMaterijalService.Remove((int)id);
            }
            var usluga = await uslugaService.GetById<eOrdinacija.Model.Usluga>(_idNew!=null?_idNew:_id);
            var stavke = await uslugaMaterijalService.GetByUsluga<List<eOrdinacija.Model.UslugaMaterijal>>(usluga.Id);
            foreach (var item in stavke)
            {
                var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                item.Materijal = materijal.Naziv;
            }
            txtNaziv.Text = usluga.Naziv;
            txtCijena.Text = usluga.Cijena.ToString();
            txtOpis.Text = usluga.Opis;
            dgvMaterijali.DataSource = stavke;
            dgvMaterijali.AutoGenerateColumns = false;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtOpis, null);
            }
        }
    }
}
