using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace eOrdinacija_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijaController : ControllerBase
    {
        private readonly IRezervacijaService _service;
        public RezervacijaController(IRezervacijaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Rezervacija> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        [Route("GetByKlijent/{id}")]
        public List<eOrdinacija.Model.Rezervacija> GetByKlijent(int id)
        {
            return _service.GetByKlijent(id);
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Rezervacija GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("GetByDates/{dateFrom}/{dateTo}")]
        public List<eOrdinacija.Model.Rezervacija> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            return _service.GetByDates(dateFrom,dateTo);
        }

        [HttpPost]
        public eOrdinacija.Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eOrdinacija.Model.Rezervacija Update(int id, RezervacijaUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
