﻿using WaterPolo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaterPolo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new sp();
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
