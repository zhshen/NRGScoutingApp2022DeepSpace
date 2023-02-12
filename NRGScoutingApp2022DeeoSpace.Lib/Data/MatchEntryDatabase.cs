using NRGScoutingApp2022DeeoSpace.Lib.Entities;
using NRGScoutingApp2022DeeoSpace.Lib.Helpers;
using NRGScoutingApp2022DeeoSpace.Lib.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace NRGScoutingApp2022DeeoSpace.Lib.Data
{
    public class MatchEntryDatabase
    {
        private SQLiteAsyncConnection? conection;

        public MatchEntryDatabase(string path)
        {
            this.conection = new SQLiteAsyncConnection(path);
        }

        public MatchEntryDatabase()
        {

        }

        public SQLiteAsyncConnection Connection
        {
            get
            {
                if (this.conection == null)
                    throw new NullReferenceException("Conection has not been initialized");

                return this.conection;
            }
        }

        private async Task Init()
        {
            if (this.conection == null)
            {
                this.conection = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(SpecialFolder.LocalApplicationData), MatchConstants.LocalDatabaseFileName));
                await CreateAllTablesAsync();
                await this.InitTeamsFromResourceAsync();
                await this.InitEntriesFromResourceAsync(); //  This is for mock data
            }
        }

        public async Task<List<MatchEntry>> GetAllMatchEntriesAsync()
        {
            await this.Init();

            List<MatchEntryEntity> entities = await this.Connection.Table<MatchEntryEntity>().ToListAsync();

            return entities.ToEntries();
        }

        public async Task<MatchEntry?> GetMatchEntryByIdAsync(int id)
        {
            await this.Init();

            MatchEntryEntity entity = await this.Connection.Table<MatchEntryEntity>()
                            .Where(e => e.Id == id)
                            .FirstOrDefaultAsync();

            MatchEntry? result = null;

            if (entity != null)
                result = entity.ToMatchEntry();

            return result;
        }

        public async Task<List<Team>> GetTeamsAsync(string criteria = "")
        {
            await this.Init();

            return await this.Connection.Table<Team>().ToListAsync();
        }

        public async Task<Team> GetTeamByNumAsync(int teamNum)
        {
            await this.Init();

            return await this.Connection.Table<Team>()
                            .Where(t => t.TeamNum == teamNum)
                            .FirstOrDefaultAsync();
        }

        public async Task<T?> GetAppTempData<T>(string key)
        {
            await this.Init();

            AppTempData tempData = await this.Connection.Table<AppTempData>()
                                    .Where(t => t.Key == key)
                                    .FirstOrDefaultAsync();

            T? result = default(T);

            if (tempData != null && string.IsNullOrEmpty(tempData.Data) == false)
                result = JsonHelper.Deserialize<T>(tempData.Data);

            return result;
        }

        public async Task SaveAppTempData<T>(string key, T data)
        {
            AppTempData tempData = new AppTempData()
            {
                Key = key,
                Data = JsonHelper.Serialize(data)
            };

            await this.Connection.InsertOrReplaceAsync(tempData);
        }

        public async Task<MatchEntryDatabase> CreateAllTablesAsync()
        {
            await this.Connection.CreateTableAsync<Team>();
            await this.Connection.CreateTableAsync<AppTempData>();
            await this.Connection.CreateTableAsync<MatchEntryEntity>();
            await this.Connection.CreateIndexAsync("MatchEntryEntity", new string[] { "TeamNum", "MatchNum", "Side" }, true);

            return this;
        }
    }
}
