using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public int KlijentId { get; set; }
        public int UslugaId { get; set; }
        public DateTime Datum { get; set; }
        public string Vrijeme { get; set; }
    }
}
