using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{

    public class UslugaMaterijalService : IUslugaMaterijalService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public UslugaMaterijalService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public List<eOrdinacija.Model.UslugaMaterijal> GetByUsluga(int id)
        {
            var entity = _context.UslugaMaterijal.Where(x => x.UslugaId == id).ToList();
            return Mapper.Map<List<eOrdinacija.Model.UslugaMaterijal>>(entity);
        }

        public void Remove(int id)
        {
            var entity = _context.UslugaMaterijal.Where(x => x.Id == id).FirstOrDefault();
            _context.Remove(entity);
            _context.SaveChanges();
        }
        public eOrdinacija.Model.UslugaMaterijal Insert(UslugaMaterijalInsertRequest request)
        {
            var entity = _mapper.Map<Database.UslugaMaterijal>(request);
            _context.UslugaMaterijal.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.UslugaMaterijal>(entity);
        }
    }

}
