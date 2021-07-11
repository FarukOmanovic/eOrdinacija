using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Ocjena
    {
        public int KlijentId { get; set; }
        public int UslugaId { get; set; }
        public int Ocjena1 { get; set; }
        public int Id { get; set; }

        public Klijent Klijent { get; set; }
        public Usluga Usluga { get; set; }
    }
}
