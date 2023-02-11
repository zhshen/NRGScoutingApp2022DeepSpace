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

        public bool CrossBaseline { get; set; }

        public int AutoLvl { get; set; }

        public bool AutoOTele { get; set; } //False is auto, true is tele

        public DeathType DeathType { get; set; } //0 is no death, 1 is partial death, 2 full death

        public bool Climb { get; set; }

        public int ClimbLvl { get; set; }

        public bool GiveAstClimb { get; set; }

        public int GiveAstClimbLvl { get; set; }

        public bool NeedAstClimb { get; set; }

        public int Fouls { get; set; }

        public bool YellowCard { get; set; }

        public bool RedCard { get; set; }

        public String Comments { get; set; } = string.Empty;

        public List<MatchEvent>? Events
        {
            get;
            set;
        }
    }
}
