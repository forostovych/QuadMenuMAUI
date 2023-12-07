using CommunityToolkit.Mvvm.ComponentModel;
using Interrio.Models.ViewModels;
using QuadMenuMAUI.Views.Menu;

namespace QuadMenuMAUI.Models.ViewModels.MenuViewModels;

public partial class MenuSearchPageViewModel : ObservableObject
{
    [ObservableProperty]
    ContentView menu;

    public MenuSearchPageViewModel(string menuName)
    {
        var menuViewModel = new MenuBlurViewViewModel(menuName);
        menu = new MenuBlurView(menuViewModel);
    }
}