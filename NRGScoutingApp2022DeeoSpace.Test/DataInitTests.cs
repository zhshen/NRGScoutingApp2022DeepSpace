using Microsoft.Data.Sqlite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLite;
using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeeoSpace.Lib.Entities;
using NRGScoutingApp2022DeeoSpace.Lib.Models;

namespace NRGScoutingApp2022DeeoSpace.Test
{
    [TestClass]
    public class DataInitTests
    {
        [TestMethod]
        public async Task TableCreationTest()
        {
            MatchEntryDatabase database = TestDataHelper.GetTestDb();

            await database.CreateAllTablesAsync();

            List<SQLiteConnection.ColumnInfo> teamColumns = await database.Connection.GetTableInfoAsync("Team");
            Assert.AreEqual(2, teamColumns.Count);

            List<SQLiteConnection.ColumnInfo> matchEntryColumns = await database.Connection.GetTableInfoAsync("MatchEntryEntity");

            Assert.AreEqual(6, matchEntryColumns.Count);
        }

        [TestMethod]
        public async Task TeamsInitTest()
        {
            MatchEntryDatabase database = TestDataHelper.GetTestDb();

            await database.CreateAllTablesAsync();
            await database.InitTeamsFromResourceAsync();

            int teamCount = await database.Connection.Table<Team>().CountAsync();

            Assert.IsTrue(teamCount > 0);
        }

        [TestMethod]
        public async Task MatchEntriesInitTest()
        {
            MatchEntryDatabase database = TestDataHelper.GetTestDb();

            await database.CreateAllTablesAsync();
            await database.InitEntriesFromResourceAsync();

            int matchEntryCount = await database.Connection.Table<MatchEntryEntity>().CountAsync();

            List<MatchEntryEntity> entities = await database.GetAllMatchEntriesAsync();

            List<MatchEntry> entries = entities.ToEntries();

            Assert.IsTrue(entries.Count > 0);
        }
    }
}