using OrderingApp.Services;
using OrderingApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderingApp
{
    public partial class App : Application
    {
        //public static CapturingDatabase  CapturingDatabase {get;set;} 
        public App()
        {
            InitializeComponent();

            //CapturingDatabase = new CapturingDatabase();
            MainPage = new NavigationPage(new TShirtPage());
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
