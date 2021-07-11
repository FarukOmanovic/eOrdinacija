using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class NabavkaMaterijalInsertRequest
    {
        [Required]
        public int NabavkaId { get; set; }
        [Required]
        public int MaterijalId { get; set; }
        [Required]
        public decimal Kolicina { get; set; }

    }
}
