using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface INabavkaService
    {
        List<eOrdinacija.Model.Nabavka> Get();
        eOrdinacija.Model.Nabavka GetById(int id);
        eOrdinacija.Model.Nabavka Insert(NabavkaInsertRequest request);
        eOrdinacija.Model.Nabavka Update(int id, NabavkaUpdateRequest request);

    }
}
