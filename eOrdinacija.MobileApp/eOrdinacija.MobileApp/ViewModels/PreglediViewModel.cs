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
    public class PreglediViewModel
    {
        private readonly APIService service = new APIService("Pregled/GetByKlijent");

        public PreglediViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Pregled> PreglediLista { get; set; } = new ObservableCollection<Pregled>();
        public ICommand InitCommand { get; set; }


        public async Task Init()
        {

            var list = await service.GetByKlijent<List<Pregled>>(Global.loggedClient.Id);

            PreglediLista.Clear();

            foreach (var rezervacija in list)
            {
                PreglediLista.Add(rezervacija);

            }
        }
    }
}
