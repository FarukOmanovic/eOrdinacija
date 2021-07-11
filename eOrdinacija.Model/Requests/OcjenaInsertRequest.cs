using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class OcjenaInsertRequest
    {
        [Required]
        public int KlijentId { get; set; }
        [Required]
        public int UslugaId { get; set; }
        [Required]
        public int Ocjena1 { get; set; }
    }
}
