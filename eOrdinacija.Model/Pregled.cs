using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class Pregled
    {
        public int Id { get; set; }
        public int ZaposlenikId { get; set; }
        public int KlijentId { get; set; }
        public string Zaposlenik { get; set; }
        public int UslugaId { get; set; }
        public string Usluga { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string VrijemePregleda { get; set; }
        public int? ReceptId { get; set; }

    }
}
