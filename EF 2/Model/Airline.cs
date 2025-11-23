using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Airline
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactPerson { get; set; }

        public ICollection<Phone> Phones { get; set; } = new HashSet<Phone>();

        public ICollection<Empolyee> Empolyees { get; set; } = new HashSet<Empolyee>();

        public ICollection<Transaction> Transaction { get; set; } = new HashSet<Transaction>();

        public ICollection<Aircraft> Aircraft { get; set; } = new HashSet<Aircraft>();

    }
}
