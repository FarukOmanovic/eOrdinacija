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
    public class KlijentController : ControllerBase
    {
        private readonly IKlijentService _service;
        public KlijentController(IKlijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Klijent> Get([FromQuery] KlijentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Klijent GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("name={name}")]
        public eOrdinacija.Model.Klijent GetByName(string name)
        {
            return _service.GetByName(name);
        }

        [HttpPost]
        public eOrdinacija.Model.Klijent Insert(KlijentInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eOrdinacija.Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
