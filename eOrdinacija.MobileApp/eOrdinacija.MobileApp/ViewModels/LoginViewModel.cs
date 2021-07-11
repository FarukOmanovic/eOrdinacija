using eOrdinacija.MobileApp.Views;
using eOrdinacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService service = new APIService("Klijent");

        string _username = string.Empty;
        public string Username
        {
            get { return _username;  }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegistracijaCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegistracijaCommand = new Command(OnRegistracijaClicked);
        }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {

                var list = await service.Get<List<Klijent>>(null);
                var user = list.Where(x => x.Username == Username).FirstOrDefault();
                if (user != null)
                {
                    var newHash = GenerateHash(user.PasswordSalt, Password);
                    if (newHash == user.PasswordHash)
                    {
                        Global.loggedClient = user;
                        Application.Current.MainPage = new AppShell();
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešna lozinka", "OK");
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Korisnik ne postoji!", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
            IsBusy = false;
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }


        private void OnRegistracijaClicked(object obj)
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
    }
}
