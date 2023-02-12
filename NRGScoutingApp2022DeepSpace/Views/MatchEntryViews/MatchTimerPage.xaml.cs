using NRGScoutingApp2022DeeoSpace.Lib.Data;

namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

public partial class MatchTimerPage : ContentPage
{
    private MatchEntryDatabase database;

    public MatchTimerPage(MatchEntryDatabase database)
    {
        InitializeComponent();

        this.database = database;
    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}