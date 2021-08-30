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
    public class UslugaMaterijalController : ControllerBase
    {
        private readonly IUslugaMaterijalService _service;
        public UslugaMaterijalController(IUslugaMaterijalService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetByUsluga/{id}")]
        public List<eOrdinacija.Model.UslugaMaterijal> GetByUsluga(int id)
        {
            return _service.GetByUsluga(id);
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            _service.Remove(id);
        }

        [Authorize(Roles = "Administrator,Stomatolog,Sestra")]
        [HttpPost]
        public eOrdinacija.Model.UslugaMaterijal Insert(UslugaMaterijalInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
