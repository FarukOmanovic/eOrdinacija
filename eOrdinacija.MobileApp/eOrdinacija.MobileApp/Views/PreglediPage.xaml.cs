using eOrdinacija.MobileApp.ViewModels;
using eOrdinacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrdinacija.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreglediPage : ContentPage
    {
        private PreglediViewModel model = null;

        public PreglediPage()
        {
            InitializeComponent();
            BindingContext = model = new PreglediViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
        private void PreglediList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
               this.Navigation.PushAsync(new PregledDetaljiPage((e.Item as Pregled).Id));
            }
        }

        private void Button_Termini_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TerminiPage());
        }
        private void Button_Novi_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NoviTerminPage(null));
        }
    }
}