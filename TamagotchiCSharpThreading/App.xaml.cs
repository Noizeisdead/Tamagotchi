﻿using TamagotchiCSharpThreading.Screens;

namespace TamagotchiCSharpThreading
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
