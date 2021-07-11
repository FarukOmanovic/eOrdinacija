using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrdinacija.WinUI.Klijent
{
    public partial class frmKlijentDetalji : Form
    {
        private int? _id = null;
        private readonly APIService _apiService = new APIService("Pregled");
        private readonly APIService _uslugaService = new APIService("Usluga");
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _zaposlenikService = new APIService("Zaposlenik");

        public frmKlijentDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }


        private async void frmKlijentDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var stavke = await _apiService.GetByKlijent<List<eOrdinacija.Model.Pregled>>(_id);
                var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(_id);
                labelImePrezime.Text = klijent.Ime + " " + klijent.Prezime;
                labelDatum.Text = klijent.DatumRodjenja.ToString();
                labelTelefon.Text = klijent.BrojTelefona;
                labelEmail.Text = klijent.Email;
                foreach (var item in stavke)
                {
                    item.VrijemePregleda = item.VrijemePregleda;
                    var zaposlenik = await _zaposlenikService.GetById<eOrdinacija.Model.Zaposlenik>(item.ZaposlenikId);
                    var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(item.UslugaId);
                    item.Usluga = usluga.Naziv;
                    item.Zaposlenik = zaposlenik.Ime + " " + zaposlenik.Prezime;
                }
                dgvPregledi.AutoGenerateColumns = false;
                dgvPregledi.DataSource = stavke;
            }
        }

        private void dgvPregledi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPregledi.SelectedRows[0].Cells[0].Value;
            frmKlijentPregledi frm = new frmKlijentPregledi(int.Parse(id.ToString()),_id);
            frm.Show();
        }

        private void btnNoviPregled_Click(object sender, EventArgs e)
        {
            frmKlijentPregledi frm = new frmKlijentPregledi(null,_id);
            frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frm.Show();
        }

        private async void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            var stavke = await _apiService.GetByKlijent<List<eOrdinacija.Model.Pregled>>(_id);
            var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(_id);
            labelImePrezime.Text = klijent.Ime + " " + klijent.Prezime;
            labelDatum.Text = klijent.DatumRodjenja.ToString();
            labelTelefon.Text = klijent.BrojTelefona;
            labelEmail.Text = klijent.Email;
            foreach (var item in stavke)
            {
                item.VrijemePregleda = item.VrijemePregleda;
                var zaposlenik = await _zaposlenikService.GetById<eOrdinacija.Model.Zaposlenik>(item.ZaposlenikId);
                var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(item.UslugaId);
                item.Usluga = usluga.Naziv;
                item.Zaposlenik = zaposlenik.Ime + " " + zaposlenik.Prezime;
            }
            dgvPregledi.AutoGenerateColumns = false;
            dgvPregledi.DataSource = stavke;
        }
    }
}
