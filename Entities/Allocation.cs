using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Entities
{
    [Table("Allocations")]
    public class Allocation
    {
        public Int64 Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Completion { get; set; }
        public Byte WeeklyHours { get; set; }
        public Decimal Payment { get; set; }
        public Developer Developer { get; set; }
        public Project Project { get; set; }

        public Allocation()
        {

        }
    }
}