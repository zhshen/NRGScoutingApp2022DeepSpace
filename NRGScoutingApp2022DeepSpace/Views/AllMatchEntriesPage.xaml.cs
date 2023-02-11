using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

namespace NRGScoutingApp2022DeepSpace.Views;

public partial class AllMatchEntriesPage : ContentPage
{
    private MatchEntryDatabase database;

    public AllMatchEntriesPage()
    {
        InitializeComponent();

        this.database = new MatchEntryDatabase();
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

    private void matchEntryCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}