﻿using InstagramDesign.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] {"Shapes_Experimental"});

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
