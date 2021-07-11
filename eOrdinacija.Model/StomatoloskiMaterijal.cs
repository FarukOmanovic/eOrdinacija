using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model
{
    public class StomatoloskiMaterijal
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public int StanjeUskladistu { get; set; }
    }
}
