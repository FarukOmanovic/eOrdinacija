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
    public partial class TerminiPage : ContentPage
    {
        private TerminiViewModel model = null;

        public TerminiPage()
        {
            InitializeComponent();
            BindingContext = model = new TerminiViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}