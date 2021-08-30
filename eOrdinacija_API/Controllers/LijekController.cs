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
    public class LijekController : ControllerBase
    {
        private readonly ILijekService _service;
        public LijekController(ILijekService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpGet]
        public List<eOrdinacija.Model.Lijek> Get([FromQuery] LijekoviSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Lijek GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("name={name}")]
        public eOrdinacija.Model.Lijek GetByName(string name)
        {
            return _service.GetByName(name);
        }

        [Authorize(Roles = "Administrator,Stomatolog")]
        [HttpPost]
        public eOrdinacija.Model.Lijek Insert(LijekInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
