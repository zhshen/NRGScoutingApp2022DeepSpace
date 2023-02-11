using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeeoSpace.Lib.Models;
using NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

namespace NRGScoutingApp2022DeepSpace.Views;

public partial class AllMatchEntriesPage : ContentPage
{
    private MatchEntryDatabase database;

    public AllMatchEntriesPage()
    {
        InitializeComponent();
    }

    public AllMatchEntriesPage(MatchEntryDatabase database)
    {
        InitializeComponent();

        this.database = database;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        this.matchEntryCollection.ItemsSource = await this.database.GetAllMatchEntriesAsync();
    }

    private void Add_Clicked(object sender, EventArgs e)
    {

        // await Shell.Current.GoToAsync($"{nameof(Views.MatchEntryViews.MatchTimerPage)}");
        App.Current.MainPage = new MatchEntryShell();
;        // await Navigation.PushAsync(new MatchEntryPage());
    }

    private async void matchEntryCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            MatchEntry entry = (MatchEntry)e.CurrentSelection[0];

            // Should navigate to "MatchEntryDetail?MatchId=0"
            await Shell.Current.GoToAsync($"{nameof(MatchEntryDetailPage)}?MatchEntryId={entry.Id}");

            // Unselect the UI
            this.matchEntryCollection.SelectedItem = null;
        }
    }
}