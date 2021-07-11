using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace eOrdinacija.MobileApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("zdjVVZVU2XeNQH7LdUwo~0zluECoqY20N2ClMgHDT6A~Ak2z4uzLdSfPpAidKrgBQM6ijh7cuK_qBfEQGdArpTS10nQlCnb9CIW9LaNM9NJj");
            LoadApplication(new eOrdinacija.MobileApp.App());
        }
    }
}
