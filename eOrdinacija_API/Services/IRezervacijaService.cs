using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public interface IRezervacijaService
    {
        List<eOrdinacija.Model.Rezervacija> Get();

        eOrdinacija.Model.Rezervacija GetById(int id);
        List<eOrdinacija.Model.Rezervacija> GetByKlijent(int id);

        List<eOrdinacija.Model.Rezervacija> GetByDates(DateTime dateFrom, DateTime dateTo);
        eOrdinacija.Model.Rezervacija Insert(RezervacijaInsertRequest request);
        eOrdinacija.Model.Rezervacija Update(int id, RezervacijaUpdateRequest request);
    }
}
