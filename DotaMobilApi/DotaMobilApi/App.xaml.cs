using DotaMobilApi.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DotaMobilApi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<IHeroesService, HeroesService>();
            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new LoginUI());
            MainPage = new HeroesPage();

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
