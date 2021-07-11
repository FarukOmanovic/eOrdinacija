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
    public partial class frmUslugaMaterijali : Form
    {
        private int? _id = null;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private readonly APIService _service = new APIService("UslugaMaterijal");
        private readonly APIService materijalService = new APIService("StomatoloskiMaterijal");

        public frmUslugaMaterijali(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUslugaMaterijali_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmUslugaMaterijali_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmUslugaMaterijali_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private async void frmUslugaMaterijali_Load(object sender, EventArgs e)
        {
           var materijali = await materijalService.Get<List<eOrdinacija.Model.StomatoloskiMaterijal>>(null);
            comboBoxMaterijali.DisplayMember = "Naziv";
            comboBoxMaterijali.ValueMember = "Id";
            comboBoxMaterijali.DataSource = materijali;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(txtKolicina.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }
            var request = new UslugaMaterijalInsertRequest()
            {
                UslugaId = (int)_id,
                MaterijalId = (int)comboBoxMaterijali.SelectedValue,
                Kolicina = Decimal.Parse(txtKolicina.Text)
            };
            await _service.Insert<eOrdinacija.Model.UslugaMaterijal>(request);
            Close();
        }

        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                errorProvider1.SetError(txtKolicina, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtKolicina, null);
            }
        }
    }
}
