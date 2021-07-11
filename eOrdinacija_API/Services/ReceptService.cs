using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class ReceptService : IReceptService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public ReceptService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eOrdinacija.Model.Recept GetById(int id)
        {
            var entity = _context.Recept.Find(id);
            return Mapper.Map<eOrdinacija.Model.Recept>(entity);

        }

        public eOrdinacija.Model.Recept Insert(ReceptInsertRequest request)
        {
            var entity = _mapper.Map<Database.Recept>(request);
            _context.Recept.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Recept>(entity);
        }

    }
}
