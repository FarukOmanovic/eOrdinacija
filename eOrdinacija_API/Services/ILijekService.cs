using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface ILijekService
    {
        List<eOrdinacija.Model.Lijek> Get(LijekoviSearchRequest request);
        eOrdinacija.Model.Lijek GetById(int id);
        eOrdinacija.Model.Lijek GetByName(string name);
        eOrdinacija.Model.Lijek Insert(LijekInsertRequest request);

    }
}
