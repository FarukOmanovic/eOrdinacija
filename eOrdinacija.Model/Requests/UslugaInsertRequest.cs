using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class UslugaInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
    }
}
