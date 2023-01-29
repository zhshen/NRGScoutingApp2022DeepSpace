using NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

namespace NRGScoutingApp2022DeepSpace.Views;

public partial class AllMatchEntriesPage : ContentPage
{
    public AllMatchEntriesPage()
    {
        InitializeComponent();
    }

    private void Add_Clicked(object sender, EventArgs e)
    {

        // await Shell.Current.GoToAsync($"{nameof(Views.MatchEntryViews.MatchTimerPage)}");
        App.Current.MainPage = new MatchEntryShell();
;        // await Navigation.PushAsync(new MatchEntryPage());
    }
}