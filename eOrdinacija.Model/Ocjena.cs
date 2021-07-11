using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class Ocjena
    {
        public int Id { get; set; }
        public int KlijentId { get; set; }
        public int UslugaId { get; set; }
        public int Ocjena1 { get; set; }
    }
}
