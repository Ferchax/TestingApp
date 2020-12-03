using System;
using TestingApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UsuariosPage();
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
