using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IUslugaService
    {
        List<eOrdinacija.Model.Usluga> Get(UslugaSearchRequest request);
        List<eOrdinacija.Model.Usluga> GetRecommendedUsluge(int id);
        eOrdinacija.Model.Usluga GetById(int id);
        eOrdinacija.Model.Usluga GetByName(string name);
        eOrdinacija.Model.Usluga Insert(UslugaInsertRequest request);
        eOrdinacija.Model.Usluga Update(int id, UslugaInsertRequest request);

    }
}
