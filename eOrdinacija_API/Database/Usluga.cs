using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Usluga
    {
        public Usluga()
        {
            Ocjena = new HashSet<Ocjena>();
            Pregled = new HashSet<Pregled>();
            Rezervacija = new HashSet<Rezervacija>();
            UslugaMaterijal = new HashSet<UslugaMaterijal>();
        }

        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public int Id { get; set; }

        public ICollection<Ocjena> Ocjena { get; set; }
        public ICollection<Pregled> Pregled { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
        public ICollection<UslugaMaterijal> UslugaMaterijal { get; set; }
    }
}
