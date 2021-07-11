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
    public partial class frmNabavkaDetalji : Form
    {
        private int? _id = null;
        private readonly APIService nabavkaService = new APIService("Nabavka");
        private readonly APIService _service = new APIService("NabavkaMaterijal");
        private readonly APIService materijalService = new APIService("StomatoloskiMaterijal");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmNabavkaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmNabavkaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var nabavka = await nabavkaService.GetById<eOrdinacija.Model.Nabavka>(_id);
                labelDatum.Text = nabavka.DatumNabavke.ToShortDateString();
                var stavke = await _service.Get<List<eOrdinacija.Model.NabavkaMaterijal>>(_id);
                foreach (var item in stavke)
                {
                    var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                    item.UkupnaCijena = Math.Round(item.Kolicina * materijal.CijenaPoKomadu, 2);
                    item.Materijal = materijal.Naziv;
                }
                dgvNabavkaMaterijal.DataSource = stavke;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNabavkaDetalji_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmNabavkaDetalji_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmNabavkaDetalji_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
