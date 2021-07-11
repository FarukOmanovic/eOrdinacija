using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class NabavkaService : INabavkaService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public NabavkaService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Nabavka> Get()
        {
            var list = _context.Nabavka.ToList();
            return Mapper.Map<List<eOrdinacija.Model.Nabavka>>(list);
        }

        public eOrdinacija.Model.Nabavka GetById(int id)
        {
            var entity = _context.Nabavka.Find(id);
            return Mapper.Map<eOrdinacija.Model.Nabavka>(entity);
        }

        public eOrdinacija.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Nabavka>(request);
            _context.Nabavka.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.Nabavka>(entity);
        }

        public eOrdinacija.Model.Nabavka Update(int id, NabavkaUpdateRequest request)
        {
            var entity = _context.Nabavka.Find(id);
            entity.UkupanIznos += request.Cijena;
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Nabavka>(entity);
        }

    }
}
