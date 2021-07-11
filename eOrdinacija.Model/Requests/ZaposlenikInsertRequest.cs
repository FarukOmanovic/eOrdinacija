using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class ZaposlenikInsertRequest
    {
        [Required]
        public int UlogaId { get; set; }

        [Required]
        [MinLength(3)]
        public string Ime { get; set; }

        [Required]
        [MinLength(3)]
        public string Prezime { get; set; }

        [MinLength(9)]
        public string BrojTelefona { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        public DateTime DatumZaposlenja { get; set; }

        [Required]
        [MinLength(3)]
        public string Username { get; set; }
        public bool isAdministrator { get; set; }

        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }

    }
}
