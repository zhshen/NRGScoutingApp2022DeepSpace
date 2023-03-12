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
         *GRIDS
         *l = low grids, m = mid grids, h = high grids
         *0 = none, 1 = auto + Cube, 2 = teleop + Cube, 3 = auto + Cone, 4 = auto + Cube
         */

        public int L1 { get; set; }

        public int L2 { get; set; }

        public int L3 { get; set; }

        public int L4 { get; set; }

        public int L5 { get; set; }

        public int L6 { get; set; }

        public int L7 { get; set; }

        public int L8 { get; set; }

        public int L9 { get; set; }

        public int M1 { get; set; }

        public int M2 { get; set; }

        public int M3 { get; set; }

        public int M4 { get; set; }

        public int M5 { get; set; }

        public int M6 { get; set; }

        public int M7 { get; set; }

        public int M8 { get; set; }

        public int M9 { get; set; }

        public int H1 { get; set; }

        public int H2 { get; set; }

        public int H3 { get; set; }

        public int H4 { get; set; }

        public int H5 { get; set; }

        public int H6 { get; set; }

        public int H7 { get; set; }

        public int H8 { get; set; }

        public int H9 { get; set; }

        /*
         * CHARGESTATION
         * 0 = none, 1 = docked, 2 = engaged
         */
        public int ChargeStationAuto { get; set; }

        public int ChargeStationTeleop { get; set; }

        public DeathType DeathType { get; set; } //0 is no death, 1 is partial death, 2 full death

        public int Fouls { get; set; }

        // 0 = offense, 1 = defense
        public int Style { get; set; }

        public String Substation { get; set; } = string.Empty;

        public String Comments { get; set; } = string.Empty;

        public List<MatchEvent>? Events
        {
            get;
            set;
        } = new List<MatchEvent>();
    }
}
