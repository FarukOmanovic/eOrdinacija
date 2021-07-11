using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IUlogaService
    {
        List<eOrdinacija.Model.Uloga> Get();

        eOrdinacija.Model.Uloga GetById(int id);
        eOrdinacija.Model.Uloga GetByName(string name);


    }
}
