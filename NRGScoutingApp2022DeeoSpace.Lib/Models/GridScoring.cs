using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Models
{
    public class GridScoring
    {
        public GridPosition Position { get; set; }

        public String TimePeriod { get; set; } = string.Empty;

        public String GamePieceType { get; set; } = string.Empty;
    }
}
