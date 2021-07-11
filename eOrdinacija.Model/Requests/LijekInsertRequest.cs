using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class LijekInsertRequest
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
    }
}
