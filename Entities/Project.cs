using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Entities
{
    [Table("Projects")]
    internal class Project
    {
        public Int64 Id { get; set; }

        [Required]
        [StringLength(35)]
        public String Name { get; set; }

        public DateTime Start { get; set; }
        public DateTime PlannedCompletion { get; set; }
        public DateTime Completion { get; set; }
    }
}
