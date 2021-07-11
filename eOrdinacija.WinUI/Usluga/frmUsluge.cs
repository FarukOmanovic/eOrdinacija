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
    public partial class frmUsluge : Form
    {
        private readonly APIService _apiService = new APIService("Usluga");
        public frmUsluge()
        {
            InitializeComponent();
        }

        private async void frmUsluge_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Usluga>>(null);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = result;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new UslugaSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<eOrdinacija.Model.Usluga>>(search);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = result;
        }

        private void btnNovaUsluga_Click(object sender, EventArgs e)
        {
            frmUslugaDetalji frm = new frmUslugaDetalji();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }

        private void dgvUsluge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUsluge.SelectedRows[0].Cells[0].Value;
            frmUslugaDetalji frm = new frmUslugaDetalji(int.Parse(id.ToString()));
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Usluga>>(null);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = result;

        }
    }
}
