using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eOrdinacija_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace eOrdinacija_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogaController : ControllerBase
    {
        private readonly IUlogaService _service;
        public UlogaController(IUlogaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Uloga> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Uloga GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("name={name}")]
        public eOrdinacija.Model.Uloga GetByName(string name)
        {
            return _service.GetByName(name);
        }
    }
}
