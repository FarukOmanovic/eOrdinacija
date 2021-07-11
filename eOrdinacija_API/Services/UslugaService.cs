using AutoMapper;
using eOrdinacija.Model.Requests;
using eOrdinacija_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Services
{
    public class UslugaService: IUslugaService
    {
        private readonly eOrdinacijaContext _context;
        private readonly IMapper _mapper;

        public UslugaService(eOrdinacijaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<eOrdinacija.Model.Usluga> Get(UslugaSearchRequest request)
        {
            var query = _context.Usluga.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            var list = _mapper.Map<List<eOrdinacija.Model.Usluga>>(query.ToList());
            foreach (var item in list)
            {
                var rateList = _context.Ocjena.Where(x => x.UslugaId == item.Id).ToList();
                if(rateList.Count > 0)
                {
                    double counter = 0;
                    foreach (var rate in rateList)
                    {
                        counter += rate.Ocjena1;
                    }
                    item.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
                }
            }
            return list;
        }
        public eOrdinacija.Model.Usluga GetById(int id)
        {
            var entity = _context.Usluga.Find(id);
            var mappedUsluga = Mapper.Map<eOrdinacija.Model.Usluga>(entity);
            var rateList = _context.Ocjena.Where(x => x.UslugaId == mappedUsluga.Id).ToList();
            if (rateList.Count > 0)
            {
                double counter = 0;
                foreach (var rate in rateList)
                {
                    counter += rate.Ocjena1;
                }
                mappedUsluga.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
            }
            return mappedUsluga;

        }
        public eOrdinacija.Model.Usluga GetByName(string name)
        {
            var entity = _context.Usluga.Where(x => x.Naziv == name).SingleOrDefault();
            var mappedUsluga = Mapper.Map<eOrdinacija.Model.Usluga>(entity);
            var rateList = _context.Ocjena.Where(x => x.UslugaId == mappedUsluga.Id).ToList();
            if (rateList.Count > 0)
            {
                double counter = 0;
                foreach (var rate in rateList)
                {
                    counter += rate.Ocjena1;
                }
                mappedUsluga.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
            }
            return mappedUsluga;

        }

        public eOrdinacija.Model.Usluga Insert(UslugaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Usluga>(request);

            _context.Usluga.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<eOrdinacija.Model.Usluga>(entity);
        }

        public eOrdinacija.Model.Usluga Update(int id, UslugaInsertRequest request)
        {
            var entity = _context.Usluga.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eOrdinacija.Model.Usluga>(entity);
        }


        Dictionary<int, List<Ocjena>> usluge = new Dictionary<int, List<Ocjena>>();


        private double GetSimilarity(List<Ocjena> ratings1, List<Ocjena> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double numerator = 0, denominator1 = 0, denominator2 = 0;

            for (int i = 0; i < ratings1.Count; i++)
            {
                numerator = ratings1[i].Ocjena1 * ratings2[i].Ocjena1;

                denominator1 = ratings1[i].Ocjena1 * ratings1[i].Ocjena1 * 1.0;
                denominator2 = ratings2[i].Ocjena1 * ratings2[i].Ocjena1 * 1.0;

            }
            denominator1 = Math.Sqrt(denominator1);
            denominator2 = Math.Sqrt(denominator2);

            double denominator = denominator1 * denominator2;
            if (denominator == 0)
            {
                return 0;
            }
            else
            {
                return numerator / denominator;
            }

        }



        private void GetProductsData(int uslugaId)
        {
            List<Usluga> aktivneUsluge = _context.Usluga.Where(x => x.Id != uslugaId).ToList();
            List<Ocjena> ocjene;

            foreach (Usluga item in aktivneUsluge)
            {
                ocjene = _context.Ocjena.Where(x => x.UslugaId == item.Id).OrderBy(x => x.KlijentId).ToList();

                if (ocjene.Count > 0)
                {
                    usluge.Add(item.Id, ocjene);
                }
            }


        }

        public List<eOrdinacija.Model.Usluga> GetRecommendedUsluge(int uslugaId)
        {
            GetProductsData(uslugaId);

            List<Ocjena> ratingsOfThisUsluga = _context.Ocjena.Where(x => x.UslugaId == uslugaId).OrderBy(x => x.KlijentId).ToList();

            List<Ocjena> ratings1 = new List<Ocjena>();
            List<Ocjena> ratings2 = new List<Ocjena>();

            List<Usluga> recommendedUsluge = new List<Usluga>();

            foreach (var item in usluge)
            {
                foreach (Ocjena r in ratingsOfThisUsluga)
                {
                    if (item.Value.Where(x => x.KlijentId == r.KlijentId).Count() > 0)
                    {
                        ratings1.Add(r);
                        ratings2.Add(item.Value.Where(x => x.KlijentId == r.KlijentId).First());
                    }
                }

                double similarity = 0;
                similarity = GetSimilarity(ratings1, ratings2);

                if (similarity > 0.6)
                {
                    recommendedUsluge.Add(_context.Usluga.Where(p => p.Id == item.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }

            var mappedUslugeList =  _mapper.Map<List<eOrdinacija.Model.Usluga>>(recommendedUsluge);
            foreach (var item in mappedUslugeList)
            {
                var rateList = _context.Ocjena.Where(x => x.UslugaId == item.Id).ToList();
                if (rateList.Count > 0)
                {
                    double counter = 0;
                    foreach (var rate in rateList)
                    {
                        counter += rate.Ocjena1;
                    }
                    item.ProsjecnaOcjena = Math.Round(counter / rateList.Count(), 1).ToString();
                }
            }
            return mappedUslugeList;

        }
    }
}
