using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Recept
    {
        public Recept()
        {
            Pregled = new HashSet<Pregled>();
        }

        public int KlijentId { get; set; }
        public int ZaposlenikId { get; set; }
        public int LijekId { get; set; }
        public decimal KolicinaLijeka { get; set; }
        public string Napomena { get; set; }
        public int Id { get; set; }

        public Klijent Klijent { get; set; }
        public Lijek Lijek { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public ICollection<Pregled> Pregled { get; set; }
    }
}
