using System;
using System.Collections.Generic;

namespace eOrdinacija_API.Database
{
    public partial class Nabavka
    {
        public Nabavka()
        {
            NabavkaMaterijal = new HashSet<NabavkaMaterijal>();
        }

        public decimal UkupanIznos { get; set; }
        public DateTime DatumNabavke { get; set; }
        public int ZaposlenikId { get; set; }
        public int Id { get; set; }

        public Zaposlenik Zaposlenik { get; set; }
        public ICollection<NabavkaMaterijal> NabavkaMaterijal { get; set; }
    }
}
