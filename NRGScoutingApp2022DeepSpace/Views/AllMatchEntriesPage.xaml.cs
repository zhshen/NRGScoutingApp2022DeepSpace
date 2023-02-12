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
            await this.BindDataAsync();
    }

    private async Task BindDataAsync()
    {
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

    private void Upload_Clicked(object sender, EventArgs e)
    {

    }

    private void Download_Clicked(object sender, EventArgs e)
    {

    }

    private async void DeleteAll_Clicked(object sender, EventArgs e)
    {
        if (await this.DisplayAlert("Confirm", "Do you want to delete all matches ? Data CANNOT be recovered.", "YES", "NO"))
        {
            await this.database.DeleteAllMatchEntriesAsync();
            await this.BindDataAsync();
        }
    }
}