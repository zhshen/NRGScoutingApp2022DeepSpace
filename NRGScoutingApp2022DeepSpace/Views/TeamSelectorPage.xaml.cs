using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeeoSpace.Lib.Entities;
using NRGScoutingApp2022DeeoSpace.Lib.Models;

namespace NRGScoutingApp2022DeepSpace.Views;

[QueryProperty(nameof(Target), nameof(Target))]
public partial class TeamSelectorPage : ContentPage
{
    private MatchEntryDatabase database;

    public TeamSelectorPage(MatchEntryDatabase database)
    {
        InitializeComponent();

        this.database = database;
    }

    public string Target
    {
        get;
        set;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        this.teamCollection.ItemsSource = await this.database.GetTeamsAsync();
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void teamCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Team team = (Team)e.CurrentSelection[0];

        if (string.IsNullOrEmpty(this.Target) == false)
            await Shell.Current.GoToAsync($"..?TeamNum={team.TeamNum}");
    }
}