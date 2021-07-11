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

namespace eOrdinacija.WinUI.Zaposlenik
{
    public partial class frmZaposlenikDetalji : Form
    {
        private readonly APIService _service=new APIService("zaposlenik");
        private readonly APIService ulogaService = new APIService("uloga");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmZaposlenikDetalji(int? id=null)
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var selectedUloga = comboBoxUloge.SelectedItem.ToString();
                var uloga = await ulogaService.GetByName<eOrdinacija.Model.Uloga>(selectedUloga);
                var request = new ZaposlenikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    BrojTelefona = txtTelefon.Text,
                    DatumRodjenja = dateTimePickerDatumRodjenja.Value,
                    DatumZaposlenja = dateTimePickerDatumZaposlenja.Value,
                    Username = txtIme.Text + txtPrezime.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPotvrda.Text,
                    UlogaId = uloga.Id,
                    isAdministrator = checkBoxAdministrator.Checked
                };
                await _service.Insert<eOrdinacija.Model.Zaposlenik>(request);
                MessageBox.Show("Uspješno ste dodali novog zaposlenika!");
            }
        }

        private async void frmZaposlenikDetalji_Load(object sender, EventArgs e)
        {
            var uloge = await ulogaService.Get<List<eOrdinacija.Model.Uloga>>(null);
            var ulogeNaziv = new List<String>();
            foreach (var item in uloge)
            {
                ulogeNaziv.Add(item.Naziv);
            }
            comboBoxUloge.DataSource = ulogeNaziv;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void dateTimePickerDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimePickerDatumRodjenja.Text))
            {
                errorProvider.SetError(dateTimePickerDatumRodjenja, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dateTimePickerDatumRodjenja, null);
            }
        }

        private void dateTimePickerDatumZaposlenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimePickerDatumZaposlenja.Text))
            {
                errorProvider.SetError(dateTimePickerDatumZaposlenja, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dateTimePickerDatumZaposlenja, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmZaposlenikDetalji_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmZaposlenikDetalji_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmZaposlenikDetalji_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}
