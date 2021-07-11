using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IZaposlenikService
    {
        List<eOrdinacija.Model.Zaposlenik> Get(ZaposlenikSearchRequest request);
        eOrdinacija.Model.Zaposlenik GetById(int id);
        eOrdinacija.Model.Zaposlenik Insert(ZaposlenikInsertRequest request);
        eOrdinacija.Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request);
        eOrdinacija.Model.Zaposlenik Authenticiraj(string username, string password);

    }
}
