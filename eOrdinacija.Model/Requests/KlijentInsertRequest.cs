using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOrdinacija.Model.Requests
{
    public class KlijentInsertRequest
    {

        [Required]
        [MinLength(3)]
        public string Ime { get; set; }

        [Required]
        [MinLength(3)]
        public string Prezime { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string BrojTelefona { get; set; }

        [Required]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        [MinLength(3)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }

    }
}
