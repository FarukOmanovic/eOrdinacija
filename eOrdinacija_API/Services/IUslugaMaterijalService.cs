using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IUslugaMaterijalService
    {
        List<eOrdinacija.Model.UslugaMaterijal> GetByUsluga(int id);
        void Remove(int id);
        eOrdinacija.Model.UslugaMaterijal Insert(UslugaMaterijalInsertRequest request);
    }
}
