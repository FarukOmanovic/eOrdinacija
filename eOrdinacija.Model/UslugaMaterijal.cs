using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class UslugaMaterijal
    {
        public int Id { get; set; }
        public int UslugaId { get; set; }
        public int MaterijalId { get; set; }
        public string Materijal { get; set; }
        public decimal Kolicina { get; set; }
    }
}
