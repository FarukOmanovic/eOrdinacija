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

namespace eOrdinacija.WinUI.Nabavka
{
    public partial class frmNovaNabavka : Form
    {
        private readonly APIService materijalService = new APIService("StomatoloskiMaterijal");
        private readonly APIService nabavkaService = new APIService("Nabavka");
        private readonly APIService nabavkaMaterijalService = new APIService("NabavkaMaterijal");
        private eOrdinacija.Model.Nabavka nabavka = new eOrdinacija.Model.Nabavka();
        private int? _idNew = null;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmNovaNabavka()
        {
            InitializeComponent();
        }

        async void frmNovaNabavka_Load(object sender, EventArgs e)
        {
            var materijali = await materijalService.Get<List<eOrdinacija.Model.StomatoloskiMaterijal>>(null);
            comboBoxMaterijali.DisplayMember = "Naziv";
            comboBoxMaterijali.ValueMember = "Id";
            comboBoxMaterijali.DataSource = materijali;
        }

        

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_idNew == null)
            {
                var nabavkaRequest = new NabavkaInsertRequest()
                {
                    DatumNabavke = DateTime.Now.Date,
                    Kolicina = 0,
                    ZaposlenikId = Global.LoggedUser.Id
                };
                nabavka = await nabavkaService.Insert<eOrdinacija.Model.Nabavka>(nabavkaRequest);
                _idNew = nabavka.Id;
            }
          
            
            var nabavkaMaterijalRequest = new NabavkaMaterijalInsertRequest()
            {
                NabavkaId=nabavka.Id,
                Kolicina=numericKolicina.Value,
                MaterijalId= (int)comboBoxMaterijali.SelectedValue
            };
            await nabavkaMaterijalService.Insert<eOrdinacija.Model.NabavkaMaterijal>(nabavkaMaterijalRequest);
            load(sender, e, nabavka.Id);
        }

        async void load(object sender, EventArgs e, int id)
        {
            var stavke = await nabavkaMaterijalService.Get<List<eOrdinacija.Model.NabavkaMaterijal>>(id);
            foreach (var item in stavke)
            {
                var materijalItem = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                item.UkupnaCijena = Math.Round(item.Kolicina * materijalItem.CijenaPoKomadu, 2);
                item.Materijal = materijalItem.Naziv;
               
            }
            dgvNabavkaMaterijali.DataSource = stavke;

            var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(comboBoxMaterijali.SelectedValue);
            var request = new NabavkaUpdateRequest()
            {
                Cijena = Math.Round(numericKolicina.Value * materijal.CijenaPoKomadu, 2)
            };
            await nabavkaService.Update<eOrdinacija.Model.Nabavka>(id, request);

            var materijalRequest = new MaterijalUpdateRequest()
            {
                StanjeUSkladistu = (int)numericKolicina.Value,
                Operation = "Dodavanje"
            };
            await materijalService.Update<eOrdinacija.Model.StomatoloskiMaterijal>(materijal.Id, materijalRequest);

            numericKolicina.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            if (_idNew == null)
            {
                MessageBox.Show("Nabavka mora sadržavati bar jednu stavku!");
            }
            else
            {
                Close();
            }
           
        }

        private void btnNoviMaterijal_Click(object sender, EventArgs e)
        {
            frmNoviMaterijal frm = new frmNoviMaterijal();
            frm.FormClosing += new FormClosingEventHandler(onFormClosing);
            frm.Show();
        }

        private async void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var materijali = await materijalService.Get<List<eOrdinacija.Model.StomatoloskiMaterijal>>(null);
            comboBoxMaterijali.DisplayMember = "Naziv";
            comboBoxMaterijali.ValueMember = "Id";
            comboBoxMaterijali.DataSource = materijali;
        }

        private void frmNovaNabavka_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmNovaNabavka_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmNovaNabavka_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

    }
}
