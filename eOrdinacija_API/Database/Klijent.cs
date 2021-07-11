using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Ocjena = new HashSet<Ocjena>();
            Pregled = new HashSet<Pregled>();
            Recept = new HashSet<Recept>();
            Rezervacija = new HashSet<Rezervacija>();
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int Id { get; set; }

        public ICollection<Ocjena> Ocjena { get; set; }
        public ICollection<Pregled> Pregled { get; set; }
        public ICollection<Recept> Recept { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
