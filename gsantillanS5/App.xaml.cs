﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gsantillanS5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Veterinarios();
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
