using NRGScoutingApp2022DeeoSpace.Lib.Data;

namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

public partial class MatchEventsPage : ContentPage
{
    private MatchEntryDatabase database;

    public MatchEventsPage(MatchEntryDatabase database)
    {
        InitializeComponent();

        this.database = database;
    }
    
    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}