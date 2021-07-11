using eOrdinacija.MobileApp.ViewModels;
using eOrdinacija.MobileApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eOrdinacija.MobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
            Global.loggedClient = null;
        }
    }
}
