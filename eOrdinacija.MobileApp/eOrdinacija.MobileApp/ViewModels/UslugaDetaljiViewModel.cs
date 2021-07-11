using eOrdinacija.Model;
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
    public class UslugaDetaljiViewModel : BaseViewModel
    {
        private readonly APIService uslugaService = new APIService("Usluga");
        private readonly APIService uslugaServiceRecommended = new APIService("Usluga/getRecommendedUsluge");

        public int UslugaID { get; set; }
        public UslugaDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Usluga> RecommendedUslugeList { get; set; } = new ObservableCollection<Usluga>();

        public ICommand InitCommand { get; set; }
        Usluga usluga = null;
        public Usluga Usluga
        {
            get { return usluga; }
            set { SetProperty(ref usluga, value); }
        }

        public async Task Init()
        {
            RecommendedUslugeList.Clear();
            var usluga = await uslugaService.GetById<Usluga>(UslugaID);
            if (usluga.ProsjecnaOcjena == null)
            {
                usluga.ProsjecnaOcjena = "Ocjena nije dostupna";
            }
            Usluga = usluga;
            try
            {
                var responseRecommendedUsluge = await uslugaServiceRecommended.GetRecommendedUsluge<List<Usluga>>(usluga.Id);

                foreach (var u in responseRecommendedUsluge)
                {
                    if (u.ProsjecnaOcjena == null)
                    {
                        u.ProsjecnaOcjena = "Ocjena nije dostupna";
                    }
                    RecommendedUslugeList.Add(u);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Error code: " + ex.Message, "OK");
            }


        }
    }
}
