using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using eOrdinacija_API.Exceptions;
using eOrdinacija_API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;

namespace eOrdinacija_API.Services
{
    public class ZaposlenikService : IZaposlenikService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public ZaposlenikService(eOrdinacijaContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eOrdinacija.Model.Zaposlenik Authenticiraj(string username, string password)
        {
            var user = _context.Zaposlenik.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = Util.GenerateHash(user.PasswordHash, password);

                if (newHash == user.PasswordSalt)
                {
                    return _mapper.Map<eOrdinacija.Model.Zaposlenik>(user);
                }
            }
            return null;
        }


        public List<eOrdinacija.Model.Zaposlenik> Get(ZaposlenikSearchRequest request)
        {
            var query = _context.Zaposlenik.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            var list = query.ToList();
            var list2=Mapper.Map<List<eOrdinacija.Model.Zaposlenik>>(list);
            foreach (var item in list2)
            {
                item.Uloga = _context.Uloga.Find(item.UlogaId).Naziv;
            }
            return list2;
        }

        public eOrdinacija.Model.Zaposlenik GetById(int id)
        {
            var entity = _context.Zaposlenik.Find(id);
            return Mapper.Map<eOrdinacija.Model.Zaposlenik>(entity);

        }

        public eOrdinacija.Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Zaposlenik>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne podudaraju!");
            }

            entity.PasswordSalt = Util.GenerateSalt();
            entity.PasswordHash = Util.GenerateHash(entity.PasswordSalt, request.Password);
            _context.Zaposlenik.Add(entity);
            _context.SaveChanges();
            
            return _mapper.Map<eOrdinacija.Model.Zaposlenik>(entity);
        }

        public eOrdinacija.Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request)
        {
            var entity = _context.Zaposlenik.Find(id);
            _mapper.Map(request, entity);

            //if (request.Password != request.PasswordConfirmation)
            //{
            //  return 
            //}
            
            //if (_context.Zaposlenik.Where(x=>x.Username == request.Username).SingleOrDefault() != null)
            //{
            //    throw new Exception("Korisničko ime zauzeto!");
            //}

            if (request.Password.Length > 0 && request.PasswordConfirmation.Length > 0)
            {
                entity.PasswordSalt = Util.GenerateSalt();
                entity.PasswordHash = Util.GenerateHash(entity.PasswordSalt, request.Password);
            }

            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Zaposlenik>(entity);
        }
    }
}
