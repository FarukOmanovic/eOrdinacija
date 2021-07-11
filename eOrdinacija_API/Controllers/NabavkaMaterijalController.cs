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
    public class NabavkaMaterijalController : ControllerBase
    {
        private readonly INabavkaMaterijalService _service;
        public NabavkaMaterijalController(INabavkaMaterijalService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.NabavkaMaterijal> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public eOrdinacija.Model.NabavkaMaterijal Insert(NabavkaMaterijalInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
