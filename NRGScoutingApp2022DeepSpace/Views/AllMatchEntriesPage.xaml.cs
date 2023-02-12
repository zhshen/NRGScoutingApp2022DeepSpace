using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeeoSpace.Lib.Entities;
using NRGScoutingApp2022DeeoSpace.Lib.Helpers;
using NRGScoutingApp2022DeeoSpace.Lib.Models;

namespace NRGScoutingApp2022DeepSpace.Views;

[QueryProperty(nameof(TeamNum), nameof(TeamNum))]
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

    public int TeamNum
    {
        get;
        set;
    } = -1;

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        if (this.TeamNum >= 0)
            await this.SaveTempMatchEntrAndSwitchMainPageAsync(this.TeamNum);
        else
            this.matchEntryCollection.ItemsSource = await this.database.GetAllMatchEntriesAsync();
    }

    private async Task SaveTempMatchEntrAndSwitchMainPageAsync(int teamNum)
    {
        Team team = await this.database.GetTeamByNumAsync(teamNum);

        if (team != null)
        {
            MatchEntry entry = new MatchEntry()
            {
                TeamNum = teamNum,
                TeamName = team.TeamName
            };

            await this.database.SaveAppTempData(MatchConstants.TempMatchEntryKey, entry);

            App.Current.MainPage = new MatchEntryShell();
        }
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TeamSelectorPage)}?Target=..");
        //App.Current.MainPage = new MatchEntryShell();
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