using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            Zaposlenik = new HashSet<Zaposlenik>();
        }

        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int Id { get; set; }

        public ICollection<Zaposlenik> Zaposlenik { get; set; }
    }
}
