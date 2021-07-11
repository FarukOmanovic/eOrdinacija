using eOrdinacija.MobileApp.Views;
using eOrdinacija.Model;
using eOrdinacija.Model.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp.ViewModels
{
    public class RegistracijaViewModel: BaseViewModel
    {
        private readonly APIService service = new APIService("Klijent");
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        DateTime _datum_rodjenja = DateTime.Now;
        public DateTime DatumRodjenja
        {
            get { return _datum_rodjenja; }
            set { SetProperty(ref _datum_rodjenja, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _password_potvrda = string.Empty;
        public string PasswordPotvrda
        {
            get { return _password_potvrda; }
            set { SetProperty(ref _password_potvrda, value); }
        }

        public ICommand RegistracijaPotvrdiCommand { get; set; }

        public RegistracijaViewModel()
        {
            RegistracijaPotvrdiCommand = new Command(async () => await Registracija());
        }


        async Task Registracija()
        {
            IsBusy = true;
            KlijentInsertRequest request = new KlijentInsertRequest()
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                DatumRodjenja = DatumRodjenja,
                BrojTelefona = Telefon,
                Username = Username,
                Password = Password,
                PasswordConfirmation = PasswordPotvrda
            };

            try
            {
                if (Password != PasswordPotvrda)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Passwordi se ne podudaraju", "OK");
                    IsBusy = false;
                    return;
                }
                if (Ime.Length == 0 || Prezime.Length == 0 || Email.Length == 0 || Telefon.Length == 0 || Username.Length == 0 || Password.Length == 0 || PasswordPotvrda.Length == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Popunite sva polja!", "OK");
                    IsBusy = false;
                    return;
                }
                var klijenti = await service.Get<List<Klijent>>(null);
             
                if (klijenti.Where(x=>x.Username == Username).Count() > 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime zauzeto", "OK");
                    IsBusy = false;
                    return;
                }

                var response = await service.Insert<KlijentInsertRequest>(request);
                if (response != null)
                {
                   await Application.Current.MainPage.DisplayAlert("Status", "Uspješna registracija", "OK");
                   Application.Current.MainPage = new LoginPage();
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
            IsBusy = false;

        }


    }
}
