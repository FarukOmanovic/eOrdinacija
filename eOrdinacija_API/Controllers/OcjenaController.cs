using eOrdinacija.Model.Requests;
using eOrdinacija_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcjenaController : ControllerBase
    {
        private readonly IOcjenaService _service;
        public OcjenaController(IOcjenaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Ocjena> Get([FromQuery] OcjenaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Ocjena GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eOrdinacija.Model.Ocjena Insert(OcjenaInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
