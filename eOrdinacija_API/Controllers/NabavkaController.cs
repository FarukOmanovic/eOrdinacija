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
    [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
    [Route("api/[controller]")]
    [ApiController]
    public class NabavkaController : ControllerBase
    {
        private readonly INabavkaService _service;
        public NabavkaController(INabavkaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Nabavka> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Nabavka GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eOrdinacija.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eOrdinacija.Model.Nabavka Update(int id, NabavkaUpdateRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
