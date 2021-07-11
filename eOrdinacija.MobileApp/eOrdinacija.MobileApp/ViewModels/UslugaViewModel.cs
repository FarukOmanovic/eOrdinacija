using eOrdinacija.Model;
using eOrdinacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp.ViewModels
{
    public class UslugaViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("Usluga");

        public UslugaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
     
        public ObservableCollection<Usluga> UslugeList { get; set; } = new ObservableCollection<Usluga>();

        public async Task Init()
        {
            UslugeList.Clear();

            var uslugeLista = await service.Get<List<Usluga>>(null);

            foreach (var u in uslugeLista)
            {
                if(u.ProsjecnaOcjena == null)
                {
                    u.ProsjecnaOcjena = "Ocjena nije dostupna";
                }
                UslugeList.Add(u);
            }

        }


    }
}
