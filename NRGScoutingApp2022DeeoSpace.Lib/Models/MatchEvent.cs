using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Models
{
    public class MatchEvent
    {
        public TimeSpan Time { get; set; } = TimeSpan.Zero;

        public ActionType Action { get; set; }
    }
}
