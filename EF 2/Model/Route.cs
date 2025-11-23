using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    internal class Route
    {
        public int Id { get; set; }

        public int Distance { get; set; }

        public string Destionation { get; set; }

        public string Origin {  get; set; }

        public string Classification { get; set; }

        public ICollection<Aircraft> Aircrafts { get; set; } = new HashSet<Aircraft>();
    }
}
