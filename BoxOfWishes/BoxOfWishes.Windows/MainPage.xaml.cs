﻿namespace BoxOfWishes.Windows
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new BoxOfWishes.App());
        }
    }
}
