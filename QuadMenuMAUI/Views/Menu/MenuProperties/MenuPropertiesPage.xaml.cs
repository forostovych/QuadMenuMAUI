using QuadMenuMAUI.Models.ViewModels.MenuViewModels;

namespace QuadMenuMAUI.Views.Menu.MenuProperties;

public partial class MenuPropertiesPage : ContentPage
{
	MenuPropertiesPageViewModel viewModel;
    public MenuPropertiesPage(MenuPropertiesPageViewModel viewModel)
	{
        this.viewModel = viewModel;
        InitializeComponent();
        //BindingContext = this.viewModel;
    }
}