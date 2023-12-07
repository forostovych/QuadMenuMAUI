using QuadMenuMAUI.Models.ViewModels.MenuViewModels;

namespace QuadMenuMAUI.Views.Menu.MenuSearch;

public partial class MenuSearchPage : ContentPage
{
	MenuSearchPageViewModel viewModel;
    public MenuSearchPage(MenuSearchPageViewModel viewModel)
	{
        this.viewModel = viewModel;
        InitializeComponent();
        BindingContext = this.viewModel;
    }
}