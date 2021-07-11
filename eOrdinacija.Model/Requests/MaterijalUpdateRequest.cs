using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class MaterijalUpdateRequest
    {
        public int StanjeUSkladistu { get; set; }
        public string Operation { get; set; }
    }
}
