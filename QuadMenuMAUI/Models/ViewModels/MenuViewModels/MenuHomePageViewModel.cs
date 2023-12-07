using CommunityToolkit.Mvvm.ComponentModel;
using Interrio.Models.ViewModels;
using QuadMenuMAUI.Views.Menu;

namespace QuadMenuMAUI.Models.ViewModels.MenuViewModels;

public partial class MenuHomePageViewModel : ObservableObject
{

    public MenuHomePageViewModel(string muneName)
    {
        var menuViewModel = new MenuBlurViewViewModel(muneName);
        //menu = new MenuBlurView(menuViewModel);
    }
}