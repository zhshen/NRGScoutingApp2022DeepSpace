using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Entities
{
    public class Team
    {
        [PrimaryKey]
        public int TeamNum { get; set; }

        public string TeamName { get; set; } = string.Empty;
    }
}
