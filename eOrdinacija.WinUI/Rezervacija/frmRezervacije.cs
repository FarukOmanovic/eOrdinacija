using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrdinacija.WinUI.Rezervacija
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _apiService = new APIService("Rezervacija");
        private readonly APIService _uslugaService = new APIService("Usluga");
        private readonly APIService _klijentService = new APIService("Klijent");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetByDates<List<eOrdinacija.Model.Rezervacija>>(DateTime.Now.ToString("dd-MMM-yyyy"), DateTime.Now.ToString("dd-MMM-yyyy"));
            foreach (var item in result)
            {
                var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(item.UslugaId);
                var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(item.KlijentId);
                item.Usluga = usluga.Naziv;
                item.Klijent = klijent.Ime + " " + klijent.Prezime;
                if (item.NaCekanju == true)
                {
                    item.Status = "Na čekanju";
                }
                if (item.Prihvaceno == true && item.Datum >= DateTime.Today)
                {
                    item.Status = "Prihvaćeno";
                }
                if (item.Prihvaceno == true && item.Datum <= DateTime.Today)
                {
                    item.Status = "Izvršeno";
                }
                if (item.Otkazano==true)
                {
                    item.Status = "Otkazano";
                }
            }
            dgvRezervacije.DataSource = result;
        }

        private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var startDate = monthCalendar1.SelectionRange.Start.ToString("dd-MMM-yyyy");
            var endDate = monthCalendar1.SelectionRange.End.ToString("dd-MMM-yyyy");
            var result = await _apiService.GetByDates<List<eOrdinacija.Model.Rezervacija>>(startDate,endDate);
            foreach (var item in result)
            {
                var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(item.UslugaId);
                var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(item.KlijentId);
                item.Usluga = usluga.Naziv;
                item.Klijent = klijent.Ime + " " + klijent.Prezime;
                if (item.NaCekanju == true)
                {
                    item.Status = "Na čekanju";
                }
                if (item.Prihvaceno == true && item.Datum >= DateTime.Today)
                {
                    item.Status = "Prihvaćeno";
                }
                if (item.Prihvaceno == true && item.Datum <= DateTime.Today)
                {
                    item.Status = "Izvršeno";
                }
                if (item.Otkazano == true)
                {
                    item.Status = "Otkazano";
                }
            }
            dgvRezervacije.DataSource = result;
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var result = await _apiService.GetByDates<List<eOrdinacija.Model.Rezervacija>>(DateTime.Now.ToString("dd-MMM-yyyy"), DateTime.Now.ToString("dd-MMM-yyyy"));
            if (monthCalendar1.SelectionEnd.Date != DateTime.Today)
            {
                monthCalendar1.SelectionStart = monthCalendar1.SelectionStart;
                monthCalendar1.SelectionEnd = monthCalendar1.SelectionEnd;

            }
            foreach (var item in result)
            {
                var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(item.UslugaId);
                var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(item.KlijentId);
                item.Usluga = usluga.Naziv;
                item.Klijent = klijent.Ime + " " + klijent.Prezime;
                if (item.NaCekanju == true)
                {
                    item.Status = "Na čekanju";
                }
                if (item.Prihvaceno == true && item.Datum >= DateTime.Today)
                {
                    item.Status = "Prihvaćeno";
                }
                if (item.Prihvaceno == true && item.Datum <= DateTime.Today)
                {
                    item.Status = "Izvršeno";
                }
                if (item.Otkazano == true)
                {
                    item.Status = "Otkazano";
                }
            }
            dgvRezervacije.DataSource = result;
        }

        private void dgvRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvRezervacije.SelectedRows[0].Cells[0].Value;
            frmRezervacijaDetalji frm = new frmRezervacijaDetalji(int.Parse(id.ToString()));
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }
    }
}
