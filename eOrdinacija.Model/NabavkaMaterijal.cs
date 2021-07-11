using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class NabavkaMaterijal
    {
        public int Id { get; set; }
        public int NabavkaId { get; set; }
        public int MaterijalId { get; set; }
        public string Materijal { get; set; }
        public decimal Kolicina { get; set; }

        public decimal UkupnaCijena { get; set; }
    }
}
