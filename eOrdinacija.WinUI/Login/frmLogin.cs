using eStudio.WinUI.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrdinacija.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("zaposlenik");
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                var list = await _service.Get<List<eOrdinacija.Model.Zaposlenik>>(null);
                var user = list.Where(x => x.Username == APIService.Username).FirstOrDefault();
                if (user != null)
                {
                    var newHash = Util.GenerateHash(user.passwordSalt, APIService.Password);
                    if (newHash == user.passwordHash)
                    {
                        Global.LoggedUser = user;
                        Hide();
                        frmMain frm = new frmMain();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešna lozinka!");
                    }
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
