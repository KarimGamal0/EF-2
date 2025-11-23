using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Transaction
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public Airline TransactionAirline { get; set; } = null;

        [ForeignKey(nameof(TransactionAirline))]
        public int AirlineId { get; set; }
    }
}
