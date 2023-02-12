using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeeoSpace.Lib.Helpers;
using NRGScoutingApp2022DeeoSpace.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeepSpace.Views.MatchEntryViews
{
    public class MatchEntryBasePage : ContentPage
    {
        private MatchEntryDatabase database;

        public MatchEntryBasePage(MatchEntryDatabase database)
        {
             this.database = database;
        }

        protected MatchEntryDatabase Database
        {
            get
            {
                return this.database;
            }
        }

        protected MatchEntry CurrentEntry
        {
            get
            {
                return this.BindingContext as MatchEntry;
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            MatchEntry entry = await this.database.GetAppTempDataAsync<MatchEntry>(MatchConstants.TempMatchEntryKey);

            this.BindingContext = entry;
        }

        protected async override void OnDisappearing()
        {
            base.OnDisappearing();

            if (this.CurrentEntry != null)
                await this.database.SaveAppTempData(MatchConstants.TempMatchEntryKey, this.CurrentEntry);
        }

        protected void OnBackToMainPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
