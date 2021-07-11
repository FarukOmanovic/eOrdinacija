using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrdinacija.WinUI.Nabavka
{
    public partial class frmNabavka : Form
    {
        private readonly APIService _apiService = new APIService("Nabavka");
        private readonly APIService _zaposlenikService = new APIService("Zaposlenik");


        public frmNabavka()
        {
            InitializeComponent();
        }

        private async void frmNabavka_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Nabavka>>(null);
            foreach (var item in result)
            {
                var zaposlenik = await _zaposlenikService.GetById<eOrdinacija.Model.Zaposlenik>(item.ZaposlenikId);
                item.Zaposlenik = zaposlenik.Ime + " " + zaposlenik.Prezime;
            }
            dgvNabavke.AutoGenerateColumns = false;
            dgvNabavke.DataSource = result;
        }

        private void dgvNabavke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvNabavke.SelectedRows[0].Cells[0].Value;
            frmNabavkaDetalji frm = new frmNabavkaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Nabavka>>(null);
            foreach (var item in result)
            {
                var zaposlenik = await _zaposlenikService.GetById<eOrdinacija.Model.Zaposlenik>(item.ZaposlenikId);
                item.Zaposlenik = zaposlenik.Ime + " " + zaposlenik.Prezime;
            }
            dgvNabavke.AutoGenerateColumns = false;
            dgvNabavke.DataSource = result;

        }

        private void btnNovaNabavka_Click(object sender, EventArgs e)
        {
            frmNovaNabavka frm = new frmNovaNabavka();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }
    }
}
