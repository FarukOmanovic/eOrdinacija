using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using eOrdinacija_API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class KlijentService: IKlijentService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public KlijentService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Klijent> Get(KlijentSearchRequest request)
        {
            var query = _context.Klijent.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            var list = query.ToList();

            return _mapper.Map<List<eOrdinacija.Model.Klijent>>(list);
        }
        public eOrdinacija.Model.Klijent GetById(int id)
        {
            var entity = _context.Klijent.Find(id);
            return Mapper.Map<eOrdinacija.Model.Klijent>(entity);

        }

        public eOrdinacija.Model.Klijent GetByName(string name)
        {
            var entity = _context.Klijent.Where(x => x.Ime+" "+x.Prezime == name).SingleOrDefault();
            return Mapper.Map<eOrdinacija.Model.Klijent>(entity);

        }

        public eOrdinacija.Model.Klijent Insert(KlijentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne podudaraju!");
            }

            if (_context.Klijent.Where(x=>x.Username == request.Username).SingleOrDefault() != null)
            {
                throw new Exception("Korisničko ime zauzeto!");
            }

            entity.PasswordSalt = Util.GenerateSalt();
            entity.PasswordHash = Util.GenerateHash(entity.PasswordSalt, request.Password);
            _context.Klijent.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.Klijent>(entity);
        }

        public eOrdinacija.Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            var entity = _context.Klijent.Find(id);
            _mapper.Map(request, entity);

            if (_context.Klijent.Where(x => x.Id != id && x.Username == request.Username).SingleOrDefault() != null)
            {
                throw new Exception("Korisničko ime zauzeto!");
            }

            if (request.Password.Length > 0 && request.PasswordConfirmation.Length > 0)
            {
                entity.PasswordSalt = Util.GenerateSalt();
                entity.PasswordHash = Util.GenerateHash(entity.PasswordSalt, request.Password);
            }

            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Klijent>(entity);
        }

        public eOrdinacija.Model.Klijent Authenticiraj(string username, string password)
        {
            var user = _context.Klijent.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = Util.GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<eOrdinacija.Model.Klijent>(user);
                }
            }
            return null;
        }
    }
}
