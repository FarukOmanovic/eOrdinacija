using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Rezervacija
    {
        public int KlijentId { get; set; }
        public int UslugaId { get; set; }
        public DateTime Datum { get; set; }
        public string Vrijeme { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }
        public bool? Otkazano { get; set; }
        public int Id { get; set; }

        public Klijent Klijent { get; set; }
        public Usluga Usluga { get; set; }
    }
}
