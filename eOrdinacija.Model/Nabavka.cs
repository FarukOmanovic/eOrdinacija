using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class Nabavka
    {
        public int Id { get; set; }
        public decimal UkupanIznos { get; set; }
        public DateTime DatumNabavke { get; set; }
        public int ZaposlenikId { get; set; }
        public string Zaposlenik { get; set; }

    }
}
