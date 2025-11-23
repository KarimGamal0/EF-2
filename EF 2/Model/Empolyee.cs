using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Empolyee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get;set; }

        public DateOnly BirthDate {  get; set; }

        [Range(1,2)]
        public int Gender { get; set; }

        public string Position { get;set; }

        public Airline EmployeeAirline { get; set; } = null;

        [ForeignKey(nameof(EmployeeAirline))]
        public int AirlineId { get; set; }

    }
}
