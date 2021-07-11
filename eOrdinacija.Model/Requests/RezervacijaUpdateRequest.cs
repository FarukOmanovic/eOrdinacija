using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class RezervacijaUpdateRequest
    {
        public bool? Prihvaceno { get; set; }
        public bool? NaCekanju { get; set; }

        public bool? Izvrseno { get; set; }
        public bool? Otkazano { get; set; }

    }
}
