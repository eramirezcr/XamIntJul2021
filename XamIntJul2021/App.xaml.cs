using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamIntJul2021.Views;

namespace XamIntJul2021
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
