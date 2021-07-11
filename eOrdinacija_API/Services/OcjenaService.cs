using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class OcjenaService : IOcjenaService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public OcjenaService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Ocjena> Get(OcjenaSearchRequest request)
        {
            var query = _context.Ocjena.AsQueryable();

            query = query.Where(x => x.KlijentId == request.KlijentId && x.UslugaId == request.UslugaId);

            var list = query.ToList();

            return _mapper.Map<List<eOrdinacija.Model.Ocjena>>(list);

        }
        public eOrdinacija.Model.Ocjena GetById(int id)
        {
            var entity = _context.Ocjena.Find(id);
            return Mapper.Map<eOrdinacija.Model.Ocjena>(entity);

        }

        public eOrdinacija.Model.Ocjena Insert(OcjenaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Ocjena>(request);
            _context.Ocjena.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.Ocjena>(entity);
        }
    }
}
