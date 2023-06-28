using CommunityToolkit.Maui.Core;
using MAUISpec.Controllers;

namespace MAUISpec;

public partial class MainPage : ContentPage
{
	private MainPageController _controller;

	public MainPage()
	{
		InitializeComponent();

		_controller = new MainPageController();
		BindingContext = _controller;
	}

    private void OnCalculateClicked(object sender, EventArgs e)
    {
		_controller.Calculate();
    }
}

