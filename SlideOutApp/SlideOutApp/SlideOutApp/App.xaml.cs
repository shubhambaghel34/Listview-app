using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SlideOutApp
{
    public partial class App : Application
    {
     //  public static MasterDetailPage MasterDetailPage;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ViewcellPage());
            //MasterDetailPage = new MasterDetailPage
            //{
            //    Master = new MenuPage(),
            //    Detail = new NavigationPage(new LinkPage("A")),
            //};
            //MainPage = MasterDetailPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
