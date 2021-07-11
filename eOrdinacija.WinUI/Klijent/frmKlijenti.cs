using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eOrdinacija.Model.Requests;
using eStudio.WinUI.Main;

namespace eOrdinacija.WinUI.Klijent
{
    public partial class frmKlijenti : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");

        public frmKlijenti()
        {
            InitializeComponent();
        }


        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<eOrdinacija.Model.Klijent>>(search);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }

        private async void frmKlijenti_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<eOrdinacija.Model.Klijent>>(null);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }

        private void dgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frmKlijentDetalji frm = new frmKlijentDetalji(int.Parse(id.ToString()));
            frm.MdiParent = frmMain.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

       


    }
}
