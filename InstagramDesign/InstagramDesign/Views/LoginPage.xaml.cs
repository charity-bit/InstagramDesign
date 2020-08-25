﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


         
namespace InstagramDesign.Views
{    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
         
            InitializeComponent();
           
        }

       async private void SignUp_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignUpPage());
        }
    }
}