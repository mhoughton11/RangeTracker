using System.ComponentModel;
using Xamarin.Forms;
using RangeTracker.ViewModels;

namespace RangeTracker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
