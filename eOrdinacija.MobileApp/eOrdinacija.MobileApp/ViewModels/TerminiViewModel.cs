using eOrdinacija.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp.ViewModels
{
    public class TerminiViewModel
    {
        private readonly APIService service = new APIService("Rezervacija/GetByKlijent");
        private readonly APIService uslugeService = new APIService("Usluga");

        public TerminiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Rezervacija> AktivniTerminiLista { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> StariTerminiLista { get; set; } = new ObservableCollection<Rezervacija>();
        public ICommand InitCommand { get; set; }


        public async Task Init()
        {

            var list = await service.GetByKlijent<List<Rezervacija>>(Global.loggedClient.Id);

            StariTerminiLista.Clear();
            AktivniTerminiLista.Clear();

            foreach (var rezervacija in list)
            {
                if (rezervacija.NaCekanju == true)
                {
                    rezervacija.Status = "Na čekanju";
                }
                if (rezervacija.Prihvaceno == true && rezervacija.Datum >= DateTime.Today)
                {
                    rezervacija.Status = "Prihvaćeno";
                }
                if (rezervacija.Prihvaceno == true && rezervacija.Datum <= DateTime.Today)
                {
                    rezervacija.Status = "Izvršeno";
                }
                if (rezervacija.Otkazano == true)
                {
                    rezervacija.Status = "Otkazano";
                }
                var usluga = await uslugeService.GetById<Usluga>(rezervacija.UslugaId);
                rezervacija.Usluga = usluga.Naziv;
                if (rezervacija.Datum >= DateTime.Today && rezervacija.Status != "Izvršeno")
                {
                    AktivniTerminiLista.Add(rezervacija);
                }
                else
                {
                    StariTerminiLista.Add(rezervacija);
                }
            }
        }
    }
}
