using AutoMapper;
using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija_API.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Zaposlenik, eOrdinacija.Model.Zaposlenik>();
            CreateMap<Database.Zaposlenik, ZaposlenikInsertRequest>().ReverseMap();
            CreateMap<Database.Uloga, eOrdinacija.Model.Uloga>();
            CreateMap<Database.Klijent, eOrdinacija.Model.Klijent>();
            CreateMap<Database.Nabavka, eOrdinacija.Model.Nabavka>();
            CreateMap<Database.NabavkaMaterijal, eOrdinacija.Model.NabavkaMaterijal>();
            CreateMap<Database.StomatoloskiMaterijal, eOrdinacija.Model.StomatoloskiMaterijal>();
            CreateMap<Database.Lijek, eOrdinacija.Model.Lijek>();
            CreateMap<Database.Rezervacija, eOrdinacija.Model.Rezervacija>();
            CreateMap<Database.Rezervacija, RezervacijaUpdateRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database.Usluga, eOrdinacija.Model.Usluga>();
            CreateMap<Database.Pregled, eOrdinacija.Model.Pregled>();
            CreateMap<Database.Recept, eOrdinacija.Model.Recept>();
            CreateMap<Database.Recept, ReceptInsertRequest>().ReverseMap();
            CreateMap<Database.Pregled, PregledInsertRequest>().ReverseMap();
            CreateMap<Database.UslugaMaterijal, eOrdinacija.Model.UslugaMaterijal>();
            CreateMap<Database.UslugaMaterijal, UslugaMaterijalInsertRequest>().ReverseMap();
            CreateMap<Database.Usluga, UslugaInsertRequest>().ReverseMap();
            CreateMap<Database.Nabavka, NabavkaInsertRequest>().ReverseMap();
            CreateMap<Database.NabavkaMaterijal, NabavkaMaterijalInsertRequest>().ReverseMap();
            CreateMap<Database.StomatoloskiMaterijal, MaterijalInsertRequest>().ReverseMap();
            CreateMap<Database.Lijek, LijekInsertRequest>().ReverseMap();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, OcjenaInsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, eOrdinacija.Model.Ocjena>().ReverseMap();
        }
    }
}
