using eOrdinacija.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
    public partial class frmProfil : Form
    {
        private readonly APIService _service = new APIService("zaposlenik");
        private readonly APIService ulogaService = new APIService("uloga");
        public frmProfil()
        {
            InitializeComponent();
        }

        private async void frmProfil_Load(object sender, EventArgs e)
        {
            var uloge = await ulogaService.Get<List<eOrdinacija.Model.Uloga>>(null);
            var zaposlenik = await _service.GetById<eOrdinacija.Model.Zaposlenik>(Global.LoggedUser.Id);

            comboBoxUloge.DisplayMember = "Naziv";
            comboBoxUloge.ValueMember = "Id";
            comboBoxUloge.DataSource = uloge;
            comboBoxUloge.SelectedValue = zaposlenik.UlogaId;
            comboBoxUloge.Enabled = Global.LoggedUser.isAdministrator == true ? true : false;
            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtTelefon.Text = zaposlenik.BrojTelefona;
            txtEmail.Text = zaposlenik.Email;
            txtUsername.Text = zaposlenik.Username;
            dateTimePickerDatumRodjenja.Value = zaposlenik.DatumRodjenja;
            checkBoxAdministrator.Checked = zaposlenik.isAdministrator;
            checkBoxAdministrator.Visible = zaposlenik.isAdministrator;
    }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var zaposlenik = await _service.GetById<eOrdinacija.Model.Zaposlenik>(Global.LoggedUser.Id);
                var zaposlenici = await _service.Get<List<eOrdinacija.Model.Zaposlenik>>(null);
         
                var request = new ZaposlenikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    BrojTelefona = txtTelefon.Text,
                    DatumRodjenja = dateTimePickerDatumRodjenja.Value,
                    DatumZaposlenja = zaposlenik.DatumZaposlenja,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPotvrda.Text,
                    UlogaId = (int)comboBoxUloge.SelectedValue,
                    isAdministrator = checkBoxAdministrator.Checked
                };
                if (zaposlenici.Where(x=>x.Username == request.Username && x.Id != Global.LoggedUser.Id).Count() > 0)
                {
                    MessageBox.Show("Korisničko ime zauzeto!");
                    return;
                }
                if (request.Password != request.PasswordConfirmation)
                {
                    MessageBox.Show("Passwordi se ne podudaraju!");
                    return;
                }
                try
                {
                    var response = await _service.Update<eOrdinacija.Model.Zaposlenik>(zaposlenik.Id, request);
                    MessageBox.Show("Uspješno ste izmijenili svoje podatke!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void dateTimePickerDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimePickerDatumRodjenja.Text))
            {
                errorProvider1.SetError(dateTimePickerDatumRodjenja, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dateTimePickerDatumRodjenja, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }
    }
}
