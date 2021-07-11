using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class LijekService: ILijekService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public LijekService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Lijek> Get(LijekoviSearchRequest request)
        {
            var query = _context.Lijek.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            var list = query.ToList();
            return Mapper.Map<List<eOrdinacija.Model.Lijek>>(list);
        }
        public eOrdinacija.Model.Lijek GetById(int id)
        {
            var entity = _context.Lijek.Find(id);
            return Mapper.Map<eOrdinacija.Model.Lijek>(entity);

        }
        public eOrdinacija.Model.Lijek GetByName(string name)
        {
            var entity = _context.Lijek.Where(x => x.Naziv == name).SingleOrDefault();
            return Mapper.Map<eOrdinacija.Model.Lijek>(entity);

        }

        public eOrdinacija.Model.Lijek Insert(LijekInsertRequest request)
        {
            var entity = _mapper.Map<Database.Lijek>(request);
            _context.Lijek.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.Lijek>(entity);
        }
    }
}
