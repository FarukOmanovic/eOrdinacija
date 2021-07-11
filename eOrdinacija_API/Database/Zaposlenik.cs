using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Zaposlenik
    {
        public Zaposlenik()
        {
            Nabavka = new HashSet<Nabavka>();
            Pregled = new HashSet<Pregled>();
            Recept = new HashSet<Recept>();
        }

        public int UlogaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int Id { get; set; }
        public bool? IsAdministrator { get; set; }

        public Uloga Uloga { get; set; }
        public ICollection<Nabavka> Nabavka { get; set; }
        public ICollection<Pregled> Pregled { get; set; }
        public ICollection<Recept> Recept { get; set; }
    }
}
