using eOrdinacija.Model;
using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp.ViewModels
{
    public class PregledDetaljiViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("Pregled");
        private readonly APIService zaposlenikService = new APIService("Zaposlenik");
        private readonly APIService uslugaService = new APIService("Usluga");
        private readonly APIService receptService = new APIService("Recept");
        private readonly APIService lijekService = new APIService("Lijek");
        private readonly APIService ocjenaService = new APIService("Ocjena");

        public int PregledID { get; set; }
        public PregledDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OcijeniCommand = new Command(async () => await OcijeniUslugu());
        }
        public ICommand InitCommand { get; set; }
        public ICommand OcijeniCommand { get; set; }

        string _zaposlenik = string.Empty;
        public string Evidentirao
        {
            get { return _zaposlenik; }
            set { SetProperty(ref _zaposlenik, value); }
        }
        string datum = string.Empty;
        public string Datum
        {
            get { return datum; }
            set { SetProperty(ref datum, value); }
        }
        string vrijeme = string.Empty;
        public string Vrijeme
        {
            get { return vrijeme; }
            set { SetProperty(ref vrijeme, value); }
        }
        string usluga = string.Empty;
        public string UslugaNaziv
        {
            get { return usluga; }
            set { SetProperty(ref usluga, value); }
        }
        string lijek = string.Empty;
        public string Lijek
        {
            get { return lijek; }
            set { SetProperty(ref lijek, value); }
        }
        string kolicina = string.Empty;
        public string Kolicina
        {
            get { return kolicina; }
            set { SetProperty(ref kolicina, value); }
        }
        string napomena = string.Empty;
        public string Napomena
        {
            get { return napomena; }
            set { SetProperty(ref napomena, value); }
        }

        int uslugaId = 0;
        public int UslugaId
        {
            get { return uslugaId; }
            set { SetProperty(ref uslugaId, value); }
        }

        int ocjena = 0;
        public int Ocjena
        {
            get { return ocjena; }
            set { SetProperty(ref ocjena, value); }
        }

        public void Ocijeni(int ocjenaNew)
        {
           Ocjena = ocjenaNew;
        }

        public async Task OcijeniUslugu()
        {
            var ocjenaInsertRequest = new OcjenaInsertRequest()
            {
                KlijentId = Global.loggedClient.Id,
                UslugaId = UslugaId,
                Ocjena1 = Ocjena
            };

            try
            {
                var response = await ocjenaService.Insert<OcjenaInsertRequest>(ocjenaInsertRequest);
                if (response != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Status", "Usluga uspješno ocijenjena s ocjenom: " + Ocjena.ToString(), "OK");
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }

        }

        public async Task Init()
        {
            var pregled = await service.GetById<Pregled>(PregledID);
            Datum = pregled.DatumPregleda.ToShortDateString();
            Vrijeme = pregled.VrijemePregleda;
            var zaposlenik = await zaposlenikService.GetById<Zaposlenik>(pregled.ZaposlenikId);
            Evidentirao = zaposlenik.Ime + " " + zaposlenik.Prezime;
            var usluga = await uslugaService.GetById<Usluga>(pregled.UslugaId);
            UslugaId = usluga.Id;
            UslugaNaziv = usluga.Naziv;
            if (pregled.ReceptId != null)
            {
                var recept = await receptService.GetById<Recept>(pregled.ReceptId);
                var lijek = await lijekService.GetById<Lijek>(recept.LijekId);
                Lijek = lijek.Naziv;
                Napomena = recept.Napomena;
                Kolicina = recept.KolicinaLijeka.ToString();
            }
            else
            {
                Lijek = "/";
                Napomena = "/";
                Kolicina = "/";
            }
        }
      
    }
}
