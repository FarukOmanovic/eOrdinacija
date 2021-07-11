using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IStomatoloskiMaterijalService
    {
        List<eOrdinacija.Model.StomatoloskiMaterijal> Get(SkladisteSearchRequest request);
        eOrdinacija.Model.StomatoloskiMaterijal GetById(int id);

        eOrdinacija.Model.StomatoloskiMaterijal Insert(MaterijalInsertRequest request);
        eOrdinacija.Model.StomatoloskiMaterijal Update(int id, MaterijalUpdateRequest request);


    }
}
