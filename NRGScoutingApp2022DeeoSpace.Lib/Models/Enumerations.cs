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

    
    public enum GridPosition
    {
        L1,
        L2,
        L3,
        L4,
        L5,
        L6,
        L7,
        L8,
        L9,
        M1,
        M2,
        M3,
        M4,
        M5,
        M6,
        M7,
        M8,
        M9,
        H1,
        H2,
        H3,
        H4,
        H5,
        H6,
        H7,
        H8,
        H9,
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
