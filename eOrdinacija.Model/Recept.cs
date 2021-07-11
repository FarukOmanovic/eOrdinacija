using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class Recept
    {
        public int Id { get; set; }
        public int KlijentId { get; set; }
        public int ZaposlenikId { get; set; }
        public int LijekId { get; set; }
        public decimal KolicinaLijeka { get; set; }
        public string Napomena { get; set; }
    }
}
