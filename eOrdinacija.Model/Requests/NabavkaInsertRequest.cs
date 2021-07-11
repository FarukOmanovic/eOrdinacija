using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class NabavkaInsertRequest
    {
        [Required]
        public int ZaposlenikId { get; set; }

        [Required]
        public DateTime DatumNabavke { get; set; }

        [Required]
        public decimal Kolicina { get; set; }

    }
}
