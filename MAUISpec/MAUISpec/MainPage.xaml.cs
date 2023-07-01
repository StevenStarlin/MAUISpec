using MAUISpec.Controllers;

namespace MAUISpec;

public partial class MainPage : Shell
{
	private MainPageController _controller;

	public MainPage()
	{
		InitializeComponent();

        RegisterRoutes();

		_controller = new MainPageController();
		BindingContext = _controller;
	}

    private void RegisterRoutes()
    {
        Routing.RegisterRoute(nameof(Pages.ResinCalculatorView), typeof(Pages.ResinCalculatorView));
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
		_controller.Calculate();
    }
}

