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
    public partial class frmNoviMaterijal : Form
    {
        private readonly APIService materijalService = new APIService("StomatoloskiMaterijal");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmNoviMaterijal()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length == 0 || txtCijena.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return;
            }
            var request = new MaterijalInsertRequest()
            {
                Naziv = txtNaziv.Text,
                CijenaPoKomadu = decimal.Parse(txtCijena.Text),
                StanjeUSkladistu = 0
            };
            await materijalService.Insert<eOrdinacija.Model.StomatoloskiMaterijal>(request);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNoviMaterijal_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmNoviMaterijal_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmNoviMaterijal_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.ValidationRequiredField);
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }
    }
}
