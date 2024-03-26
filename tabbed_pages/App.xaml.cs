using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.AppleSignInAuthenticator;

namespace tabbed_pages
{
    public partial class App : Application
    {
        List<string> options;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            TabbedPage Talv = new Talv();
            TabbedPage Kevad = new Kevad();
            TabbedPage Suvi = new Suvi();
            TabbedPage Sugis = new Sugis();
            List<TabbedPage> list = new List<TabbedPage> { Talv,  Kevad, Suvi, Sugis};
            options = new List<string>();
            foreach (var tabbedPage in list)
            {
                options.Add(tabbedPage.Title);
            }
        }

        protected override async void OnStart()
        {
            base.OnStart();
            
            string selected = await MainPage.DisplayActionSheet("Choose", "", "", options.ToArray());
            ButtonClicked(selected);

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        private void ButtonClicked(string selected)
        {
            if(selected == "Talv")
            {
                ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[0];
            }
            else if (selected == "Kevad")
            {
                ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[1];
            }
            else if (selected == "Suvi")
            {
                ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[2];
            }
            else if (selected == "Sugis")
            {
                ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[3];
            }
        }
    }
}
