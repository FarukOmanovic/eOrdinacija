﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using eOrdinacija_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eOrdinacija_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZaposlenikController : ControllerBase
    {
        private readonly IZaposlenikService _service;
        public ZaposlenikController(IZaposlenikService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eOrdinacija.Model.Zaposlenik> Get([FromQuery] ZaposlenikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public eOrdinacija.Model.Zaposlenik GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public eOrdinacija.Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eOrdinacija.Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
