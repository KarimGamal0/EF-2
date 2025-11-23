using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Crew
    {
        public int AircraftId { get; set; }

        public string MajPilot { get; set; }

        public string AssistPilot { get; set; }

        public string Host1 { get; set; }

        public string Host2 { get; set; }

        public Aircraft Aircraft { get; set; } = null;
    }
}
