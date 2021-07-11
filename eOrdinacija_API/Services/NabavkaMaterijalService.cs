using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class NabavkaMaterijalService: INabavkaMaterijalService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public NabavkaMaterijalService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.NabavkaMaterijal> Get(int id)
        {
            var list = _context.NabavkaMaterijal.Where(x=>x.NabavkaId==id).ToList();
            return Mapper.Map<List<eOrdinacija.Model.NabavkaMaterijal>>(list);
        }

        public eOrdinacija.Model.NabavkaMaterijal Insert(NabavkaMaterijalInsertRequest request)
        {
            var nabavkaMaterijali = _context.NabavkaMaterijal.Where(x=>x.NabavkaId==request.NabavkaId).ToList();
            foreach (var item in nabavkaMaterijali)
            {
                if(item.MaterijalId==request.MaterijalId)
                {
                    item.Kolicina += request.Kolicina;
                    _context.SaveChanges();
                    return _mapper.Map<eOrdinacija.Model.NabavkaMaterijal>(item);
                }
            }
            var entity = _mapper.Map<Database.NabavkaMaterijal>(request);
            _context.NabavkaMaterijal.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.NabavkaMaterijal>(entity);
        }
    }
}
