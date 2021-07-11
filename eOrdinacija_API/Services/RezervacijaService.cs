using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class RezervacijaService: IRezervacijaService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public RezervacijaService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Rezervacija> Get()
        {
            var list = _context.Rezervacija.Where(x=>x.Datum==DateTime.Now).ToList();
            return Mapper.Map<List<eOrdinacija.Model.Rezervacija>>(list);
        }

        public eOrdinacija.Model.Rezervacija GetById(int id)
        {
            var entity = _context.Rezervacija.Where(x => x.Id == id).FirstOrDefault();
            return Mapper.Map<eOrdinacija.Model.Rezervacija>(entity);
        }
        public List<eOrdinacija.Model.Rezervacija> GetByKlijent(int id)
        {
            var list = _context.Rezervacija.Where(x => x.KlijentId == id).ToList();
            return Mapper.Map<List<eOrdinacija.Model.Rezervacija>>(list);
        }

        public List<eOrdinacija.Model.Rezervacija> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            var list = _context.Rezervacija.Where(x=>x.Datum>=dateFrom && x.Datum<=dateTo).ToList();
            return Mapper.Map<List<eOrdinacija.Model.Rezervacija>>(list);
        }

        public eOrdinacija.Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Rezervacija>(request);
            entity.NaCekanju = true;
            _context.Rezervacija.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Rezervacija>(entity);
        }

        public eOrdinacija.Model.Rezervacija Update(int id, RezervacijaUpdateRequest request)
        {
            var entity = _context.Rezervacija.Find(id);
            if (request.Otkazano != null)
            {
                entity.Otkazano = request.Otkazano;
            }
            if (request.Prihvaceno != null)
            {
                entity.Prihvaceno = request.Prihvaceno;
            }
            if (request.Izvrseno != null)
            {
                entity.Izvrseno = request.Izvrseno;
            }
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Rezervacija>(entity);
        }

    }
}

