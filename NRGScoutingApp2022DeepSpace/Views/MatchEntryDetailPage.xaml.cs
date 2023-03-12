using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeeoSpace.Lib.Helpers;
using NRGScoutingApp2022DeeoSpace.Lib.Models;

namespace NRGScoutingApp2022DeepSpace.Views;

[QueryProperty(nameof(MatchEntryId), nameof(MatchEntryId))]
public partial class MatchEntryDetailPage : ContentPage
{
    private MatchEntryDatabase database;

    public MatchEntryDetailPage(MatchEntryDatabase database)
    {
        InitializeComponent();

        this.database = database;
    }

    public int MatchEntryId
    {
        get;
        set;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        MatchEntry entry = await this.database.GetMatchEntryByIdAsync(this.MatchEntryId);

        if (entry != null)
            this.entryData.Text = JsonHelper.Serialize(entry);
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");

    }
    private async void Delete_Clicked(object sender, EventArgs e)
    {
        if (await this.DisplayAlert("Confirm","Do you want to delete this entry ? Data CANNOT be recovered.", "YES", "NO"))
        {
            await this.database.DeleteMatchEntriesAsync(this.MatchEntryId);
            await Shell.Current.GoToAsync("..");
        }
    }
}