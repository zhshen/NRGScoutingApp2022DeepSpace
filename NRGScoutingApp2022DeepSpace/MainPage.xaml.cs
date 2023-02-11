using NRGScoutingApp2022DeepSpace.Helpers;

namespace NRGScoutingApp2022DeepSpace;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();

        Registers.RegisterRoutes();
    }
}