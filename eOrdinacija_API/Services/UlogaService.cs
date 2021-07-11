using AutoMapper;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class UlogaService : IUlogaService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public UlogaService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Uloga> Get()
        {
            var list = _context.Uloga.ToList();
            return Mapper.Map<List<eOrdinacija.Model.Uloga>>(list);
        }
        public eOrdinacija.Model.Uloga GetById(int id)
        {
            var entity = _context.Uloga.Find(id);
            return Mapper.Map<eOrdinacija.Model.Uloga>(entity);

        }
        public eOrdinacija.Model.Uloga GetByName(string name)
        {
            var entity = _context.Uloga.Where(x => x.Naziv == name).SingleOrDefault();
            return Mapper.Map<eOrdinacija.Model.Uloga>(entity);

        }
    }
}
