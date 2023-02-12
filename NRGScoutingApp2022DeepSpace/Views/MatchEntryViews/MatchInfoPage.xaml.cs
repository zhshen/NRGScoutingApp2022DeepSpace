using NRGScoutingApp2022DeeoSpace.Lib.Data;

namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

public partial class MatchInfoPage : ContentPage
{
    private MatchEntryDatabase database;

    public MatchInfoPage(MatchEntryDatabase database)
    {
        InitializeComponent();

        this.database = database;
    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}