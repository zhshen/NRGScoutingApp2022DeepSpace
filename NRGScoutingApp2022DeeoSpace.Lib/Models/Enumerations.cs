using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Models
{
    public enum DeathType
    {
        NoDeath,
        HalfDeath,
        FullDeath
    }

    public enum ActionType
    {
        /// <summary>
        /// Drop None
        /// </summary>
        DropNone,

        /// <summary>
        /// Rocket lvl 1
        /// </summary>
        Drop1,

        /// <summary>
        /// Rocket lvl 2
        /// </summary>
        Drop2,

        /// <summary>
        /// Rocket lvl 3
        /// </summary>
        Drop3,

        /// <summary>
        /// Cargo Ship
        /// </summary>
        Drop4,

        /// <summary>
        /// Picked Hatch Panel
        /// </summary>
        Pick1,

        /// <summary>
        /// Picked Cargo
        /// </summary>
        Pick2,

        /// <summary>
        /// Start Climb
        /// </summary>
        StartClimb
    }

    public enum ChooseRankType
    {
        /// <summary>
        /// Overall Team Rank
        /// </summary>
        OverallRank,

        /// <summary>
        /// Lvl1
        /// </summary>
        Drop1,

        /// <summary>
        /// Lvl2
        /// </summary>
        Drop2,

        /// <summary>
        /// Lvl3
        /// </summary>
        Drop3,

        /// <summary>
        /// Ship
        /// </summary>
        Drop4,

        /// <summary>
        /// Hatch
        /// </summary>
        Pick1,

        /// <summary>
        /// Cargo
        /// </summary>
        Pick2,

        /// <summary>
        /// Climb
        /// </summary>
        Climb
    }

    public enum MatchSidesType
    {
        Red1,
        Red2,
        Red3,
        Blue1,
        Blue2,
        Blue3
    }
}
