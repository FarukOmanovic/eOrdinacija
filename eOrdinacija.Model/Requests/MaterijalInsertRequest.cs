using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class MaterijalInsertRequest
    {
        public string Naziv { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public int StanjeUSkladistu { get; set; }

    }
}
