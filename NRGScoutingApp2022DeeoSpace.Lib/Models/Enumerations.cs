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
        /// PickupCube
        /// </summary>
        PickupCube,

        /// <summary>
        /// PickupCone
        /// </summary>
        PickupCone,

        /// <summary>
        /// ScoreHigh
        /// </summary>
        ScoreHigh,

        /// <summary>
        /// ScoreMid
        /// </summary>
        ScoreMid,

        /// <summary>
        /// ScoreLow
        /// </summary>
        ScoreLow,

        /// <summary>
        /// Docked
        /// </summary>
        Docked,

        /// <summary>
        /// Engaged
        /// </summary>
        Engaged,
    }

    /*
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
    */

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
