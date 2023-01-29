using NRGScoutingApp2022DeepSpace.Helpers;

namespace NRGScoutingApp2022DeepSpace;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
        // MainPage = new MainPage();

        RoutingHelper.RegisterRoutes();
    }
}
