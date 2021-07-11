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
    public partial class UslugaDetaljiPage : ContentPage
    {
        private UslugaDetaljiViewModel model;
        private int uslugaId;
        public UslugaDetaljiPage(int id)
        {
            InitializeComponent();
            uslugaId = id;
            BindingContext = model = new UslugaDetaljiViewModel()
            {
                UslugaID = id
            };
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Zakazi_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NoviTerminPage(uslugaId));
        }
        private void RecommendedList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new UslugaDetaljiPage((e.Item as Usluga).Id));
            }
        }
    }
}