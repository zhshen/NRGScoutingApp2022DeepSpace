namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

public partial class MatchEventsPage : ContentPage
{
	public MatchEventsPage()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}