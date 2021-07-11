using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class StomatoloskiMaterijal
    {
        public StomatoloskiMaterijal()
        {
            NabavkaMaterijal = new HashSet<NabavkaMaterijal>();
            UslugaMaterijal = new HashSet<UslugaMaterijal>();
        }

        public string Naziv { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public int StanjeUskladistu { get; set; }
        public int Id { get; set; }

        public ICollection<NabavkaMaterijal> NabavkaMaterijal { get; set; }
        public ICollection<UslugaMaterijal> UslugaMaterijal { get; set; }
    }
}
