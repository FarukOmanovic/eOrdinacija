using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eOrdinacija_API.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class PregledController : ControllerBase
    {
        private readonly IPregledService _service;
        public PregledController(IPregledService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpGet]
        public List<eOrdinacija.Model.Pregled> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Pregled GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("GetByKlijent/{id}")]
        public List<eOrdinacija.Model.Pregled> GetByKlijent(int id)
        {
            return _service.GetByKlijent(id);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Stomatolog")]
        public eOrdinacija.Model.Pregled Insert(PregledInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
