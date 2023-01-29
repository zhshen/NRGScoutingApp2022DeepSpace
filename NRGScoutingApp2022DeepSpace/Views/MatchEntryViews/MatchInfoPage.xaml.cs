namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

public partial class MatchInfoPage : ContentPage
{
	public MatchInfoPage()
	{
		InitializeComponent();
	}

    private void Back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}