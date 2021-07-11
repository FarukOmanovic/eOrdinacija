using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class ReceptInsertRequest
    {
        [Required]
        public int ZaposlenikId { get; set; }

        [Required]
        public int LijekId { get; set; }

        [Required]
        public int KlijentId { get; set; }

        [Required]
        public decimal KolicinaLijeka { get; set; }

        public string Napomena { get; set; }

    }
}
