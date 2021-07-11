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
    public class ProfilViewModel: BaseViewModel
    {

        private readonly APIService service = new APIService("Klijent");
        public ICommand InitCommand { get; set; }
        public ICommand PotvrdiCommand { get; set; }
        public ProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());
            PotvrdiCommand = new Command(async () => await AzurirajProfil());
        }
       
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

        public async Task Init()
        {
            var user = await service.GetById<Klijent>(Global.loggedClient.Id);
            Ime = user.Ime;
            Prezime = user.Prezime;
            Email = user.Email;
            Telefon = user.BrojTelefona;
            DatumRodjenja = user.DatumRodjenja;
            Username = user.Username;
        }

        async Task AzurirajProfil()
        {
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
                    return;
                }

                var response = await service.Update<Klijent>(Global.loggedClient.Id, request);
                if (response != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Status", "Uspješno ažuriran profil!", "OK");
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
