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

namespace eOrdinacija.WinUI.Skladište
{
    public partial class frmSkladiste : Form
    {
        private readonly APIService _apiService = new APIService("StomatoloskiMaterijal");
        public frmSkladiste()
        {
            InitializeComponent();
        }

        private async void frmSkladiste_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.StomatoloskiMaterijal>>(null);
            dgvSkladiste.AutoGenerateColumns = false;
            dgvSkladiste.DataSource = result;
            foreach (DataGridViewRow row in dgvSkladiste.Rows)
            {
                if (Convert.ToInt32(row.Cells[3].Value) < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new SkladisteSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<eOrdinacija.Model.StomatoloskiMaterijal>>(search);
            dgvSkladiste.AutoGenerateColumns = false;
            dgvSkladiste.DataSource = result;
        }
    }
}
