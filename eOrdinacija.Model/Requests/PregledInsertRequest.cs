using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class PregledInsertRequest
    {
        [Required]
        public int ZaposlenikId { get; set; }

        [Required]
        public int UslugaId { get; set; }

        [Required]
        public int KlijentId { get; set; }

        [Required]
        public DateTime DatumPregleda { get; set; }

        [Required]
        public string VrijemePregleda { get; set; }

        public int? ReceptId { get; set; }


    }
}
