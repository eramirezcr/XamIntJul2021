using System;
using Xamarin.Forms;
using XamIntJul2021.AppBase;

namespace XamIntJul2021.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            Title = "Iniciar sesion";

            OnAppearingCommnad = new Command(() => App.Current.MainPage.DisplayAlert("Hola", "Aparecio la pantalla", "Aceptar"));

            #if DEBUG
                UserName = "Alejandro";
                Password = "1234";
            #endif
        }

        private string userName;

        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        private string password;

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }
    }
}
