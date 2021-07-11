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
    public class ReceptController : ControllerBase
    {
        private readonly IReceptService _service;
        public ReceptController(IReceptService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Recept GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eOrdinacija.Model.Recept Insert(ReceptInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
