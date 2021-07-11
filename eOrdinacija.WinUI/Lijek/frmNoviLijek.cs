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

namespace eOrdinacija.WinUI.Lijek
{
    public partial class frmNoviLijek : Form
    {
        private readonly APIService lijekService = new APIService("Lijek");

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmNoviLijek()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text.Length == 0 || txtCijena.Text.Length == 0)
            {
                MessageBox.Show("Popunite obavezna polja!");
                return;
            }
            var request = new LijekInsertRequest()
            {
                Naziv = txtNaziv.Text,
                Cijena = decimal.Parse(txtCijena.Text),
            };
            await lijekService.Insert<eOrdinacija.Model.Lijek>(request);
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNoviLijek_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmNoviLijek_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmNoviLijek_MouseUp(object sender, MouseEventArgs e)
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
