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
    public class UslugaController : ControllerBase
    {
        private readonly IUslugaService _service;
        public UslugaController(IUslugaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Usluga> Get([FromQuery] UslugaSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpGet("{id}")]
        public eOrdinacija.Model.Usluga GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("getRecommendedUsluge/{id}")]
        public List<eOrdinacija.Model.Usluga> getRecommendedUsluge(int id)
        {
            return _service.GetRecommendedUsluge(id);
        }

        [HttpGet]
        [Route("name={name}")]
        public eOrdinacija.Model.Usluga GetByName(string name)
        {
            return _service.GetByName(name);
        }

        [HttpPost]
        public eOrdinacija.Model.Usluga Insert(UslugaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eOrdinacija.Model.Usluga Update(int id, UslugaInsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
