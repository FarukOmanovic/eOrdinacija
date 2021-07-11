using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Lijek
    {
        public Lijek()
        {
            Recept = new HashSet<Recept>();
        }

        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int Id { get; set; }

        public ICollection<Recept> Recept { get; set; }
    }
}
