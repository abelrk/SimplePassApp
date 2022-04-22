using SimplePass.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimplePass.Views
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