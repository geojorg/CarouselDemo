using CarouselDemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarouselDemo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WelcomeViewModel();
        }
    }
}
