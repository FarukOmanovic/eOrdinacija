using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class UslugaMaterijal
    {
        public int UslugaId { get; set; }
        public int MaterijalId { get; set; }
        public decimal Kolicina { get; set; }
        public int Id { get; set; }

        public StomatoloskiMaterijal Materijal { get; set; }
        public Usluga Usluga { get; set; }
    }
}
