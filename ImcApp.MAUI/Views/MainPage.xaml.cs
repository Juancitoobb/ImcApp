using ImcApp.MAUI.ViewModels;

namespace ImcApp.MAUI.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
		BindingContext = new MainViewModels();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}