using QuadMenuMAUI.Models.ViewModels.MenuViewModels;
using QuadMenuMAUI.Views.Menu.MenuHome;

namespace QuadMenuMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var menuHomePageViewModel = new MenuHomePageViewModel("BTN_Home");
            Navigation.PushAsync(new MenuHomePage(menuHomePageViewModel));
        }
    }
}