using Interrio.Models.ViewModels;
using QuadMenuMAUI.Models.ViewModels.MenuViewModels;
using QuadMenuMAUI.Views.Menu.MenuGallery;
using QuadMenuMAUI.Views.Menu.MenuHome;
using QuadMenuMAUI.Views.Menu.MenuProperties;
using QuadMenuMAUI.Views.Menu.MenuSearch;

namespace QuadMenuMAUI.Views.Menu;

public partial class MenuBlurView : ContentView
{
    MenuBlurViewViewModel viewModel;
    public MenuBlurView(MenuBlurViewViewModel viewModel)
    {
        this.viewModel = viewModel;
        InitializeComponent();
        BindingContext = this.viewModel;

        viewModel.ButtonClickedEvent += OnButtonClicked;
    }
    private async void OnButtonClicked(string buttonName)
    {
        Action<string> action = buttonName switch
        {
            "BTN_Home" => ActivateMenuHome,
            "BTN_Gallery" => ActivateMenuGallery,
            "BTN_Search" => ActivateMenuSearch,
            "BTN_Properties" => ActivateMenuProperties,
            _ => null,
        };
        action?.Invoke(buttonName);
    }

    private async void ActivateMenuHome(string menuName)
    {
        var menuHomePageViewModel = new MenuHomePageViewModel(menuName);
        await Navigation.PushAsync(new MenuHomePage(menuHomePageViewModel), false);
    }
    private async void ActivateMenuGallery(string menuName)
    {
        var menuGalleryPageViewModel = new MenuGalleryPageViewModel(menuName);
        await Navigation.PushAsync(new MenuGalleryPage(menuGalleryPageViewModel), false);
    }
    private async void ActivateMenuSearch(string menuName)
    {
        var menuSearchPageViewModel = new MenuSearchPageViewModel(menuName);
        await Navigation.PushAsync(new MenuSearchPage(menuSearchPageViewModel), false);
    }
    private async void ActivateMenuProperties(string menuName)
    {
        var menuPropertiesPageViewModel = new MenuPropertiesPageViewModel(menuName);
        await Navigation.PushAsync(new MenuPropertiesPage(menuPropertiesPageViewModel), false);
    }
}