using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeepSpace.Helpers;

namespace NRGScoutingApp2022DeepSpace;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        Registers.RegisterRoutes();
    }
}
