using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string Uloga { get; set; }
        public int UlogaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Username { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isAdministrator { get; set; }
    }
}
