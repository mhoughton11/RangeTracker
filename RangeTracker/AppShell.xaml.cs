using System;
using System.Collections.Generic;
using RangeTracker.ViewModels;
using RangeTracker.Views;
using Xamarin.Forms;

namespace RangeTracker
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
