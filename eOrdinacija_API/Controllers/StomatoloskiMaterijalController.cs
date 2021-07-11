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
    public class StomatoloskiMaterijalController : ControllerBase
    {
        private readonly IStomatoloskiMaterijalService _service;
        public StomatoloskiMaterijalController(IStomatoloskiMaterijalService service)
        {
            _service = service;
        }

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

        [HttpPost]
        public eOrdinacija.Model.StomatoloskiMaterijal Insert(MaterijalInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{id}")]
        public eOrdinacija.Model.StomatoloskiMaterijal Update(int id, MaterijalUpdateRequest request)
        {
            return _service.Update(id, request);
        }


    }
}
