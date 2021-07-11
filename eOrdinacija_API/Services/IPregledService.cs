using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IPregledService
    {
        List<eOrdinacija.Model.Pregled> Get();
        eOrdinacija.Model.Pregled GetById(int id);
        List<eOrdinacija.Model.Pregled> GetByKlijent(int id);

        eOrdinacija.Model.Pregled Insert(PregledInsertRequest request);

    }
}
