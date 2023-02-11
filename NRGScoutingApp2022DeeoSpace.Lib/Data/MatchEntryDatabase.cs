﻿using NRGScoutingApp2022DeeoSpace.Lib.Entities;
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
                this.conection = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(SpecialFolder.LocalApplicationData), "MatchEntry.db3"));
                await CreateAllTablesAsync();
                await this.InitTeamsFromResourceAsync();
                await this.InitEntriesFromResourceAsync(); //  This is for mock data
            }
        }

        public async Task<List<MatchEntryEntity>> GetAllMatchEntriesAsync()
        {
            await this.Init();

            return await this.Connection.Table<MatchEntryEntity>().ToListAsync();
        }

        public async Task<MatchEntryDatabase> CreateAllTablesAsync()
        {
            await this.Connection.CreateTableAsync<Team>();
            await this.Connection.CreateTableAsync<MatchEntryEntity>();
            await this.Connection.CreateIndexAsync("MatchEntryEntity", new string[] { "TeamNum", "MatchNum", "Side" }, true);

            return this;
        }
    }
}
