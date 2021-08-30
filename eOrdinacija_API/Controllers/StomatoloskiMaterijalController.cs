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
    public class StomatoloskiMaterijalController : ControllerBase
    {
        private readonly IStomatoloskiMaterijalService _service;
        public StomatoloskiMaterijalController(IStomatoloskiMaterijalService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpGet]
        public List<eOrdinacija.Model.StomatoloskiMaterijal> Get([FromQuery] SkladisteSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.StomatoloskiMaterijal GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpPost]
        public eOrdinacija.Model.StomatoloskiMaterijal Insert(MaterijalInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpPut("{id}")]
        public eOrdinacija.Model.StomatoloskiMaterijal Update(int id, MaterijalUpdateRequest request)
        {
            return _service.Update(id, request);
        }


    }
}
