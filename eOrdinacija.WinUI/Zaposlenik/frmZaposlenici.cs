using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eOrdinacija.Model.Requests;

namespace eOrdinacija.WinUI.Zaposlenik
{
    public partial class frmZaposlenici : Form
    {
        private readonly APIService _apiService = new APIService("Zaposlenik");
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposlenikSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<eOrdinacija.Model.Zaposlenik>>(search);
            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;
        }

        private async void frmZaposlenici_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Zaposlenik>>(null);
            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;
            btnNoviZaposlenik.Visible = Global.LoggedUser.isAdministrator == true ? true : false;
        }

        private void btnNoviZaposlenik_Click(object sender, EventArgs e)
        {
            frmZaposlenikDetalji frm = new frmZaposlenikDetalji();
            frm.Show();
        }

    }
}
