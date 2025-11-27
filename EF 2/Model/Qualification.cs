using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Model
{
    [PrimaryKey(nameof(EmployeeId), nameof(Name))]
    internal class Qualification
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Empolyee))]
        public int EmployeeId { get; set; }
        public Empolyee Empolyee { get; set; } = null!;
    }
}
