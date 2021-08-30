using eOrdinacija.Model.Requests;
using eStudio.WinUI.Main;
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
    public partial class frmKlijentPregledi : Form
    {
        private int? _pregledId = null;
        private int? _pacijentId;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private readonly APIService _service = new APIService("Pregled");
        private readonly APIService _klijentService = new APIService("Klijent"); 
        private readonly APIService _zaposlenikService = new APIService("Zaposlenik");
        private readonly APIService _uslugaService = new APIService("Usluga");
        private readonly APIService _lijekService = new APIService("Lijek");
        private readonly APIService _receptService = new APIService("Recept");
        private readonly APIService uslugaMaterijalService = new APIService("UslugaMaterijal");
        private readonly APIService materijalService = new APIService("StomatoloskiMaterijal");

        public frmKlijentPregledi(int? pregledId = null, int? pacijentId = null)
        {
            InitializeComponent();
            _pregledId = pregledId;
            _pacijentId = pacijentId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frmKlijentPregledi_Load(object sender, EventArgs e)
        {
            var usluge = await _uslugaService.Get<List<eOrdinacija.Model.Usluga>>(null);
            var lijekovi = await _lijekService.Get<List<eOrdinacija.Model.Lijek>>(null);
            var klijent = await _klijentService.GetById<eOrdinacija.Model.Klijent>(_pacijentId);
            var uslugeNaziv = new List<String>();
            var lijekoviNaziv = new List<String>();
            uslugeNaziv.Add("Izaberite uslugu");
            lijekoviNaziv.Add("Izaberite lijek");
            foreach (var item in usluge)
            {
                uslugeNaziv.Add(item.Naziv);
            }
            foreach (var item in lijekovi)
            {
                lijekoviNaziv.Add(item.Naziv);
            }
            if (_pregledId.HasValue)
            {
                var pregled = await _service.GetById<eOrdinacija.Model.Pregled>(_pregledId);
                var usluga = await _uslugaService.GetById<eOrdinacija.Model.Usluga>(pregled.UslugaId);
                var zaposlenik = await _zaposlenikService.GetById<eOrdinacija.Model.Zaposlenik>(pregled.ZaposlenikId);
                labelPacijent.Text = klijent.Ime + " " + klijent.Prezime;
                labelDatum.Text = pregled.DatumPregleda.Date.ToShortDateString();
                labelVrijeme.Text = pregled.VrijemePregleda;
                labelZaposlenik.Text = zaposlenik.Ime + " " + zaposlenik.Prezime;
                comboBoxUsluge.DataSource = uslugeNaziv;
                comboBoxUsluge.SelectedItem = usluga.Naziv;
                comboBoxUsluge.Enabled = false;
                btnSnimi.Visible = _pregledId == null ? true : false;
                if (pregled.ReceptId != null)
                {
                    var recept = await _receptService.GetById<eOrdinacija.Model.Recept>(pregled.ReceptId);
                    var lijek = await _lijekService.GetById<eOrdinacija.Model.Lijek>(recept.LijekId);
                    comboBoxLijekovi.DataSource = lijekoviNaziv;
                    comboBoxLijekovi.SelectedItem = lijek.Naziv;
                    comboBoxLijekovi.Enabled = false;
                    txtKolicina.Text = recept.KolicinaLijeka.ToString();
                    txtKolicina.Enabled = false;
                    txtNapomena.Text = recept.Napomena;
                    txtNapomena.Enabled = false;
                }
                else
                {
                    comboBoxLijekovi.SelectedItem = "Izaberite lijek";
                    comboBoxLijekovi.Enabled = false;
                    txtKolicina.Text = "/";
                    txtKolicina.Enabled = false;
                    txtNapomena.Text = "";
                    txtNapomena.Enabled = false;
                    btnPrintaj.Enabled = false;
                }
            }
            else
            {
                labelPacijent.Text = klijent.Ime + " " + klijent.Prezime;
                labelZaposlenik.Text = Global.LoggedUser.Ime + " " + Global.LoggedUser.Prezime;
                labelDatum.Text = DateTime.Now.Date.ToShortDateString();
                labelVrijeme.Text = DateTime.Now.ToShortTimeString();
                comboBoxUsluge.DataSource = uslugeNaziv;
                comboBoxUsluge.SelectedItem = "Izaberite uslugu";
                comboBoxUsluge.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxLijekovi.DataSource = lijekoviNaziv;
                comboBoxLijekovi.DropDownStyle = ComboBoxStyle.DropDownList;
                btnPrintaj.Visible = false;
            }
        }

        private void frmKlijentPregledi_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmKlijentPregledi_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmKlijentPregledi_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (comboBoxUsluge.SelectedItem.ToString() == "Izaberite uslugu")
            {
                MessageBox.Show("Usluga je obavezna!");
                return;
            }
            var selectedUsluga = comboBoxUsluge.SelectedItem.ToString();
            var selectedLijek = comboBoxLijekovi.SelectedItem.ToString();
            var usluga = await _uslugaService.GetByName<eOrdinacija.Model.Usluga>(selectedUsluga);
            var lijek = await _lijekService.GetByName<eOrdinacija.Model.Lijek>(selectedLijek);
            var newRecept = new Model.Recept();
            var uslugeMaterijali = await uslugaMaterijalService.GetByUsluga<List<eOrdinacija.Model.UslugaMaterijal>>(usluga.Id);
            foreach (var item in uslugeMaterijali)
            {
                var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                if (materijal.StanjeUskladistu - item.Kolicina < 0)
                {
                    MessageBox.Show("Nemate dovoljno materijala za odabranu uslugu!");
                    return;
                }

            }
            if (lijek != null)
            {
                var recept = new ReceptInsertRequest()
                {
                    KlijentId = (int)_pacijentId,
                    ZaposlenikId = Global.LoggedUser.Id,
                    LijekId = lijek.Id,
                    KolicinaLijeka = decimal.Parse(txtKolicina.Text),
                    Napomena = txtNapomena.Text
                };
                newRecept = await _receptService.Insert<eOrdinacija.Model.Recept>(recept);
            }
            else
            {
                newRecept = null;
            }
            var pregled = new PregledInsertRequest()
            {
                ZaposlenikId = Global.LoggedUser.Id,
                KlijentId = (int)_pacijentId,
                UslugaId = usluga.Id,
                DatumPregleda = DateTime.Parse(labelDatum.Text),
                VrijemePregleda = labelVrijeme.Text,
                ReceptId=newRecept?.Id
            };
            
            await _service.Insert<eOrdinacija.Model.Pregled>(pregled);
            foreach (var item in uslugeMaterijali)
            {
                var materijal = await materijalService.GetById<eOrdinacija.Model.StomatoloskiMaterijal>(item.MaterijalId);
                var materijalRequest = new MaterijalUpdateRequest()
                {
                    StanjeUSkladistu = (int)item.Kolicina,
                    Operation = "Oduzimanje"
                };
                await materijalService.Update<eOrdinacija.Model.StomatoloskiMaterijal>(materijal.Id, materijalRequest);
            }

            Close();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Recept\n", new Font("Tahoma", 20, FontStyle.Bold), Brushes.Black, 150, 125);
            e.Graphics.DrawString("\nIme i prezime: " + labelPacijent.Text, new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 155);
            e.Graphics.DrawString("\nLijek: " + comboBoxLijekovi.SelectedItem, new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 215);
            e.Graphics.DrawString("\nKoličina: " + txtKolicina.Text, new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 245);
            e.Graphics.DrawString("\nNapomena: " + txtNapomena.Text, new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 305);
            e.Graphics.DrawString("\nStomatolog: " + labelZaposlenik.Text, new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 365);
            e.Graphics.DrawString("\nDatum: " + labelDatum.Text, new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 395);
            e.Graphics.DrawString("\n\n\nPotpis ovlaštenog lica", new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 435);
            e.Graphics.DrawString("\n______________________", new Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, 150, 465);
        }

        private void comboBoxUsluge_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxUsluge.SelectedItem.ToString() == "Izaberite uslugu")
            {
                errorProvider1.SetError(comboBoxUsluge, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(comboBoxUsluge, null);
            }
        }
    }
}
