
using QuadMenuMAUI.Models.ViewModels.MenuViewModels;
using System.Collections.ObjectModel;

namespace QuadMenuMAUI.Views.Menu.MenuGallery;

public partial class MenuGalleryPage : ContentPage
{
    MenuGalleryPageViewModel viewModel;
    public MenuGalleryPage(MenuGalleryPageViewModel viewModel)
    {
        this.viewModel = viewModel;
        this.viewModel.ImageSource = InitializerImages();
        InitializeComponent();
        BindingContext = this.viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RECT_Blur.Opacity = 0.7;
    }

    private ObservableCollection<ImageSource> InitializerImages()
    {
        ObservableCollection<ImageSource> images = new ObservableCollection<ImageSource>();
        images.Add(ImageSource.FromFile("frameimage.png"));
        images.Add(ImageSource.FromFile("frameimage121.png"));
        images.Add(ImageSource.FromFile("frameimage.png"));
        images.Add(ImageSource.FromFile("frameimage121.png"));
        images.Add(ImageSource.FromFile("frameimage.png"));
        images.Add(ImageSource.FromFile("frameimage121.png"));

        return images;
    }
}