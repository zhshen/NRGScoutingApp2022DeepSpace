using NRGScoutingApp2022DeeoSpace.Lib.Helpers;
using NRGScoutingApp2022DeeoSpace.Lib.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Entities
{
    public class MatchEntryEntity
    {
        public MatchEntryEntity()
        {

        }

        public MatchEntryEntity(MatchEntry entry)
        {
            this.Id = entry.Id;
            this.TeamNum = entry.TeamNum;
            this.MatchNum = entry.MatchNum;
            this.Side = entry.Side;
            this.TeamName = entry.TeamName;

            this.Data = JsonHelper.Serialize(entry);
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int TeamNum { get; set; }

        public int MatchNum { get; set; }

        public MatchSidesType Side { get; set; }

        public string TeamName { get; set; } = string.Empty;

        public string Data { get; set; } = string.Empty;
    }
}
