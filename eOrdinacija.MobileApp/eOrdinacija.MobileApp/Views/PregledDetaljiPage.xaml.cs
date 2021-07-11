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
    public partial class PregledDetaljiPage : ContentPage
    {
        private PregledDetaljiViewModel model;

        public PregledDetaljiPage(int id)
        {
            InitializeComponent();
            BindingContext = model = new PregledDetaljiViewModel()
            {
                PregledID = id
            };
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            model.Ocijeni((int)value);

        }

    }
}