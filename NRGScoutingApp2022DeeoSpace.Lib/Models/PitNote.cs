using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Models
{
    public class PitNote
    {
        public int TeamNum { get; set; }

        public int QuestionNum { get; set; }

        public string Answer { get; set; } = String.Empty;
    }
}
