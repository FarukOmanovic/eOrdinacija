using eOrdinacija.MobileApp.Views;
using eOrdinacija.Model;
using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp.ViewModels
{
    public class NoviTerminViewModel : BaseViewModel
    {
        private readonly APIService uslugaService = new APIService("Usluga");
        private readonly APIService rezervacijaService = new APIService("Rezervacija");

        public NoviTerminViewModel()
        {
            InitCommand = new Command(async () => await Init(null));
            PotvrdiCommand = new Command(async () => await DodajNoviTermin());
        }

        public NoviTerminViewModel(int? UslugaID)
        {
            InitCommand = new Command(async () => await Init(UslugaID));
            PotvrdiCommand = new Command(async () => await DodajNoviTermin());
        }
        public ObservableCollection<Usluga> UslugaLista { get; set; } = new ObservableCollection<Usluga>();
        public ICommand InitCommand { get; set; }
        public ICommand PotvrdiCommand { get; set; }

        public async Task Init(int? UslugaID)
        {

            var list = await uslugaService.Get<List<Usluga>>(null);

            UslugaLista.Clear();

            foreach (var usluga in list)
            {
                UslugaLista.Add(usluga);
            }
            if(UslugaID != null)
            {
                SelectedUsluga = list.Where(x => x.Id == UslugaID).FirstOrDefault();
            }
        }

        DateTime datum = DateTime.Now;
        public DateTime Datum
        {
            get { return datum; }
            set { SetProperty(ref datum, value); }
        }

        DateTime min_datum = DateTime.Now;
        public DateTime MinDate
        {
            get { return min_datum; }
            set { SetProperty(ref min_datum, value); }
        }

        TimeSpan vrijeme = new TimeSpan(12, 00, 00);
        public TimeSpan Vrijeme
        {
            get { return vrijeme; }
            set { SetProperty(ref vrijeme, value); }
        }

        Usluga selectedUsluga = null;
        public Usluga SelectedUsluga
        {
            get { return selectedUsluga; }
            set { SetProperty(ref selectedUsluga, value); }
        }

        async Task DodajNoviTermin()
        {
            if (SelectedUsluga == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Usluga je obavezna", "OK");
                return;
            }

            RezervacijaInsertRequest request = new RezervacijaInsertRequest()
            {
                KlijentId = Global.loggedClient.Id,
                UslugaId = SelectedUsluga.Id,
                Datum = Datum.Date,
                Vrijeme = Vrijeme.ToString()
            };

            try
            {
                var response = await rezervacijaService.Insert<RezervacijaInsertRequest>(request);
                if (response != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Status", "Termin uspješno zakazan!", "OK");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }

    }
}
