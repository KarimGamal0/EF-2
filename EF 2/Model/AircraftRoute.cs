using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    [PrimaryKey(nameof(AircraftId), nameof(RouteId))]
    internal class AircraftRoute
    {

        [ForeignKey(nameof(Aircraft))]
        public int AircraftId { get; set; }
        [InverseProperty(nameof(Aircraft.AircraftRoutes))]
        public Aircraft Aircraft { get; set; } = null!;

        [ForeignKey(nameof(Route))]
        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int price { get; set; }

        public int NumberOfPassangers { get; set; }

        public int Duration { get; set; }

        public TimeOnly Departure { get; set; }

        public TimeOnly Arrival { get; set; }


    }
}
