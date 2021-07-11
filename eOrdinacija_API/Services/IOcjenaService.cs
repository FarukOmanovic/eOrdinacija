using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IOcjenaService
    {
        List<eOrdinacija.Model.Ocjena> Get(OcjenaSearchRequest request);
        eOrdinacija.Model.Ocjena GetById(int id);
        eOrdinacija.Model.Ocjena Insert(OcjenaInsertRequest request);

    }
}
