using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public int KlijentId { get; set; }
        public string Klijent { get; set; }
        public int UslugaId { get; set; }
        public string Usluga { get; set; }
        public DateTime Datum { get; set; }
        public string Vrijeme { get; set; }
        public string Status { get; set; }
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Izvrseno { get; set; }
        public bool? Otkazano { get; set; }

    }
}
