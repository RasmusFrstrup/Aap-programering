using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        public NavigationPage About_Me { get; set; }
        public NavigationPage Skills { get; set; }
        public NavigationPage Education { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            About_Me = new NavigationPage(new About_Me());
            Skills = new NavigationPage(new Skills());
            Education = new NavigationPage(new Education());
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
