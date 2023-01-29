using Assessment_Project.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Assessment_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=1f4eb5a2-1908-406c-bca2-f64cebecdc0c;" +
                  "uwp=b779d799-a721-48c3-b127-e2aead613d06;" +
                  "ios=e06cfd22-14a5-49b0-8b18-8062c82c90dc;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
