using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IKlijentService
    {
        List<eOrdinacija.Model.Klijent> Get(KlijentSearchRequest request);
        eOrdinacija.Model.Klijent GetById(int id);
        eOrdinacija.Model.Klijent GetByName(string name);
        eOrdinacija.Model.Klijent Insert(KlijentInsertRequest request);
        eOrdinacija.Model.Klijent Update(int id, KlijentInsertRequest request);
        eOrdinacija.Model.Klijent Authenticiraj(string username, string password);


    }
}
