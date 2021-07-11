using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Pregled
    {
        public int Id { get; set; }
        public int ZaposlenikId { get; set; }
        public int KlijentId { get; set; }
        public int UslugaId { get; set; }
        public int? ReceptId { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string VrijemePregleda { get; set; }

        public Klijent Klijent { get; set; }
        public Recept Recept { get; set; }
        public Usluga Usluga { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
    }
}
