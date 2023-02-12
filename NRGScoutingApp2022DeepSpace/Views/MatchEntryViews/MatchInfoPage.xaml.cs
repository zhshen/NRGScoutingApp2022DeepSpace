using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeepSpace.Properties;

namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews;

public partial class MatchInfoPage : MatchEntryBasePage
{
    public MatchInfoPage(MatchEntryDatabase database)
        : base(database)
    {
        InitializeComponent();
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        if (this.CurrentEntry != null)
        {
            await this.Database.SaveMatchEntry(this.CurrentEntry);

            await this.DisplayAlert("Notice", AppResource.MatchEntrySaved, "OK");
        }
    }
}