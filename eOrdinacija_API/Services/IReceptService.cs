using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IReceptService
    {
        // List<eOrdinacija.Model.Recept> Get();
        eOrdinacija.Model.Recept GetById(int id);
        eOrdinacija.Model.Recept Insert(ReceptInsertRequest request);
    }
}
