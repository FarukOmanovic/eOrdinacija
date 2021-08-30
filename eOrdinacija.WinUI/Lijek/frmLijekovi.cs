using eOrdinacija.Model.Requests;
using eOrdinacija.WinUI.Nabavka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrdinacija.WinUI.Lijek
{
    public partial class frmLijekovi : Form
    {
        private readonly APIService _apiService = new APIService("Lijek");
        private readonly APIService _ulogaService = new APIService("Uloga");

        public frmLijekovi()
        {
            InitializeComponent();
        }

        private async void frmLijekovi_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Lijek>>(null);
            var uloga = await _ulogaService.GetById<eOrdinacija.Model.Uloga>(Global.LoggedUser.UlogaId);

            btnNoviLijek.Enabled = uloga.Naziv == "Sestra" && Global.LoggedUser.isAdministrator == false ? false : true;
            dgvLijekovi.DataSource = result;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new LijekoviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<eOrdinacija.Model.Lijek>>(search);
            dgvLijekovi.AutoGenerateColumns = false;
            dgvLijekovi.DataSource = result;
        }

        private void btnNoviLijek_Click(object sender, EventArgs e)
        {
            frmNoviLijek frm = new frmNoviLijek();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Lijek>>(null);
            dgvLijekovi.DataSource = result;
        }
    }
}
