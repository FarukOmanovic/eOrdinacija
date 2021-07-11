using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{

    public class StomatoloskiMaterijalService : IStomatoloskiMaterijalService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public StomatoloskiMaterijalService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.StomatoloskiMaterijal> Get(SkladisteSearchRequest request)
        {
            var query = _context.StomatoloskiMaterijal.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<eOrdinacija.Model.StomatoloskiMaterijal>>(list);
        }

        public eOrdinacija.Model.StomatoloskiMaterijal GetById(int id)
        {
            var entity = _context.StomatoloskiMaterijal.Find(id);
            return Mapper.Map<eOrdinacija.Model.StomatoloskiMaterijal>(entity);
        }

        public eOrdinacija.Model.StomatoloskiMaterijal Insert(MaterijalInsertRequest request)
        {
            var entity = _mapper.Map<Database.StomatoloskiMaterijal>(request);

            _context.StomatoloskiMaterijal.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.StomatoloskiMaterijal>(entity);
        }
        public eOrdinacija.Model.StomatoloskiMaterijal Update(int id, MaterijalUpdateRequest request)
        {
            var entity = _context.StomatoloskiMaterijal.Find(id);
            if (request.Operation == "Dodavanje")
            {
                entity.StanjeUskladistu += request.StanjeUSkladistu;
            }
            else
            {
                entity.StanjeUskladistu -= request.StanjeUSkladistu;
            }
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.StomatoloskiMaterijal>(entity);
        }
    }

}
