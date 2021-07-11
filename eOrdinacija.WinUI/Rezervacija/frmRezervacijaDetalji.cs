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

namespace eOrdinacija.WinUI.Rezervacija
{
    public partial class frmRezervacijaDetalji : Form
    {
        private int? _id = null;
        private readonly APIService _service = new APIService("Rezervacija");
        private readonly APIService _uslugaService = new APIService("Usluga");
        private readonly APIService _klijentService = new APIService("Klijent");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmRezervacijaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmRezervacijaDetalji_Load(object sender, EventArgs e)
        {
            var rezervacija = await _service.GetById<eOrdinacija.Model.Rezervacija>(_id);
            var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(rezervacija.UslugaId);
            var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(rezervacija.KlijentId);
            labelDatum.Text = rezervacija.Datum.ToShortDateString();
            labelVrijeme.Text = rezervacija.Vrijeme;
            labelUsluga.Text = usluga.Naziv;
            labelKlijent.Text = klijent.Ime + " " + klijent.Prezime;
            if (rezervacija.NaCekanju == true)
            {
                rezervacija.Status = "Na čekanju";
            }
            if (rezervacija.Prihvaceno == true && rezervacija.Datum >= DateTime.Today)
            {
                rezervacija.Status = "Prihvaćeno";
            }
            if (rezervacija.Prihvaceno == true && rezervacija.Datum <= DateTime.Today)
            {
                rezervacija.Status = "Izvršeno";
            }
            if (rezervacija.Otkazano == true)
            {
                rezervacija.Status = "Otkazano";
            }

            if (rezervacija.Status != "Na čekanju")
            {
                picturePrihvati.Visible = false;
                label3.Visible = false;
                pictureOtkazi.Visible = false;
                label7.Visible = false;
            }
            
            labelStatus.Text = rezervacija.Status;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRezervacijaDetalji_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmRezervacijaDetalji_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmRezervacijaDetalji_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private async void picturePrihvati_Click(object sender, EventArgs e)
        {
            var rezervacija = await _service.GetById<eOrdinacija.Model.Rezervacija>(_id);

                var request = new RezervacijaUpdateRequest()
                {
                    Prihvaceno = true
                };
                await _service.Update<eOrdinacija.Model.Rezervacija>(rezervacija.Id, request);
                Close();
          
        }

        private async void pictureOtkazi_Click(object sender, EventArgs e)
        {
            var rezervacija = await _service.GetById<eOrdinacija.Model.Rezervacija>(_id);
                var request = new RezervacijaUpdateRequest()
                {
                    Prihvaceno = false,
                    Otkazano = true
                };
                await _service.Update<eOrdinacija.Model.Rezervacija>(rezervacija.Id, request);
                Close();
        }
    }
}
