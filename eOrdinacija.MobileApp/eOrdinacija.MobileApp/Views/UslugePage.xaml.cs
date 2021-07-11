using eOrdinacija.MobileApp.ViewModels;
using eOrdinacija.Model;
using eOrdinacija.Model.Requests;
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
    public partial class UslugePage : ContentPage
    {
        private UslugaViewModel model = null;
        public UslugePage()
        {
            InitializeComponent();
            BindingContext = model = new UslugaViewModel();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private void UslugeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new UslugaDetaljiPage((e.Item as Usluga).Id));
            }
        }
    }
}