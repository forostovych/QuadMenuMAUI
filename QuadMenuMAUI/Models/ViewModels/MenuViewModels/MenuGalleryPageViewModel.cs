using CommunityToolkit.Mvvm.ComponentModel;
using Interrio.Models.ViewModels;
using QuadMenuMAUI.Views.Menu;
using System.Collections.ObjectModel;

namespace QuadMenuMAUI.Models.ViewModels.MenuViewModels;

public partial class MenuGalleryPageViewModel : ObservableObject
{
    [ObservableProperty]
    ContentView menu;

    [ObservableProperty]
    ObservableCollection<ImageSource> imageSource;

    public MenuGalleryPageViewModel(string menuName)
    {
        var menuViewModel = new MenuBlurViewViewModel(menuName);
        menu = new MenuBlurView(menuViewModel);
    }
}