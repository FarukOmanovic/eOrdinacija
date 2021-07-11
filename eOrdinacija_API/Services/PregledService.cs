using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class PregledService: IPregledService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public PregledService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Pregled> Get()
        {
            var list = _context.Pregled.ToList();
            
            var mappedList = Mapper.Map<List<eOrdinacija.Model.Pregled>>(list);
            foreach (var item in mappedList)
            {
                item.Usluga = _context.Usluga.Where(x => x.Id == item.UslugaId).FirstOrDefault().Naziv;
            }
            return mappedList;
        }

        public eOrdinacija.Model.Pregled GetById(int id)
        {
            var entity = _context.Pregled.Find(id);
            return Mapper.Map<eOrdinacija.Model.Pregled>(entity);
        }

        public List<eOrdinacija.Model.Pregled> GetByKlijent(int id)
        {
            var list = _context.Pregled.Where(x => x.KlijentId == id).ToList();
            var mappedList = Mapper.Map<List<eOrdinacija.Model.Pregled>>(list);
            foreach (var item in mappedList)
            {
                item.Usluga = _context.Usluga.Where(x => x.Id == item.UslugaId).FirstOrDefault().Naziv;
            }
            return mappedList;
        }

        public eOrdinacija.Model.Pregled Insert(PregledInsertRequest request)
        {
            if (request.ReceptId == null)
                request.ReceptId = null;
            var entity = _mapper.Map<Database.Pregled>(request);
            _context.Pregled.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Pregled>(entity);
        }
    }
}
