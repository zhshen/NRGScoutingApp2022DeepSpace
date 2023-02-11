using NRGScoutingApp2022DeeoSpace.Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Test
{
    internal static class TestDataHelper
    {
        public static MatchEntryDatabase GetTestDb()
        {
            return new MatchEntryDatabase("test.db");
        }
    }
}
