using eOrdinacija.MobileApp.ViewModels;
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
    public partial class NoviTerminPage : ContentPage
    {
        private NoviTerminViewModel model = null;
        private int? uslugaID = null;

        public NoviTerminPage(int? UslugaID)
        {
            InitializeComponent();
            if(UslugaID != null)
            {
               uslugaID = (int)UslugaID;
            }
            BindingContext = model = new NoviTerminViewModel(uslugaID);
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(uslugaID);
        }
    }
}