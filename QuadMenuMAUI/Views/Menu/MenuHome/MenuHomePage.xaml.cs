

using QuadMenuMAUI.Models.ViewModels.MenuViewModels;

namespace QuadMenuMAUI.Views.Menu.MenuHome;

public partial class MenuHomePage : ContentPage
{
	MenuHomePageViewModel viewModel;
    public MenuHomePage(MenuHomePageViewModel viewModel)
	{
        this.viewModel = viewModel;
        InitializeComponent();

        var menuBlurView = new MenuBlurView(new Interrio.Models.ViewModels.MenuBlurViewViewModel("BTN_Home"));
        FRAME_CONTEINER.Content = menuBlurView;
    }
}