using NRGScoutingApp2022DeeoSpace.Lib.Entities;
using NRGScoutingApp2022DeeoSpace.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Data
{
    public static class DataConvertionExtensions
    {
        public static List<MatchEntry> ToEntries(this List<MatchEntryEntity> entities)
        {
            List<MatchEntry> result = new List<MatchEntry>();

            if (entities != null)
            {
                foreach (MatchEntryEntity entity in entities)
                {
                    MatchEntry? entry = entity.ToMatchEntry();

                    if (entry != null)
                        result.Add(entry);
                }
            }

            return result;
        }
    }
}
