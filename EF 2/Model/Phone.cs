using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Phone
    {
        public string Number { get; set; }

        public Airline AirlinePhones { get; set; } = null;

        [ForeignKey(nameof(AirlinePhones))]
        public int AirlineId { get; set; }
    }
}
