using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Interrio.Models.ViewModels;

public partial class MenuBlurViewViewModel : ObservableObject
{
    public bool IsHomeSelected { get; private set; }
    public bool IsGallerySelected { get; private set; }
    public bool IsSearchSelected { get; private set; }
    public bool IsPropertiesSelected { get; private set; }

    public event Action<string> ButtonClickedEvent;
    public MenuBlurViewViewModel(string menuName)
    {
        SelectButton(menuName);
    }

    public void SelectButton(string buttonName)
    {
        IsHomeSelected = buttonName == "BTN_Home";
        IsGallerySelected = buttonName == "BTN_Gallery";
        IsSearchSelected = buttonName == "BTN_Search";
        IsPropertiesSelected = buttonName == "BTN_Properties";
    }

    [RelayCommand]
    void ButtonClicked(string buttonName)
    {
        SelectButton(buttonName);
        ButtonClickedEvent?.Invoke(buttonName);
    }
}