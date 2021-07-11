using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface INabavkaMaterijalService
    {
        List<eOrdinacija.Model.NabavkaMaterijal> Get(int id);
        eOrdinacija.Model.NabavkaMaterijal Insert(NabavkaMaterijalInsertRequest request);

    }
}
