using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Models
{
    public class MatchEntry
    {
        public int Id { get; set; }

        public int TeamNum { get; set; }

        public int MatchNum { get; set; }

        public MatchSidesType Side { get; set; }

        public string TeamName { get; set; } = string.Empty;

        public bool Leavecomm { get; set; }

        /*
         *Grid
         *String TimePeriod
         *String GamePieceType
         */

        public List<GridScoring>? Grids
        {
            get;
            set;
        } = new List<GridScoring>();

        /*
         * CHARGESTATION
         * 0 = none, 1 = docked, 2 = engaged
         */
        public int ChargeStationAuto { get; set; }

        public int ChargeStationTeleop { get; set; }

        public DeathType DeathType { get; set; } //0 is no death, 1 is partial death, 2 full death

        public int Fouls { get; set; }

        // 0 = offense, 1 = defense
        public String Style { get; set; } = string.Empty;

        public String Substation { get; set; } = string.Empty;

        public String Comments { get; set; } = string.Empty;

        /*
         *MatchEvent
         *TimeSpan Time
         *ActionType Action
         */
        public List<MatchEvent>? Events
        {
            get;
            set;
        } = new List<MatchEvent>();
    }
}
