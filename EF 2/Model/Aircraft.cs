using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Aircraft
    {
        public int Id { get;set; }

        public string Model { get; set; }

        public int Capacity { get;set; }

        public Airline AirCraftAirline { get; set; } = null;

        [ForeignKey(nameof(AirCraftAirline))]
        public int AirlineId { get; set; }

        public Crew AircraftCrew { get; set; } = null!;

        public ICollection<Route> Routes { get; set; } = new HashSet<Route>();
    }
}
