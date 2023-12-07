

using QuadMenuMAUI.Models.ViewModels.MenuViewModels;

namespace QuadMenuMAUI.Views.Menu.MenuHome;

public partial class MenuHomePage : ContentPage
{
	MenuHomePageViewModel viewModel;
    public MenuHomePage(MenuHomePageViewModel viewModel)
	{
        this.viewModel = viewModel;
        InitializeComponent();
        BindingContext = this.viewModel;
    }
}