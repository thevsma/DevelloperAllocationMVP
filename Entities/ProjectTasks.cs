using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Entities
{
    [Table("Tasks")]
    public class ProjectTasks
    {
        public Int64 Id { get; set; }
        public Int64 AllocId { get; set; }
        
        [MaxLength(200)]
        public String Description { get; set; }

        public ProjectTasks()
        {

        }

        public ProjectTasks(String description, Int64 allocId)
        {
            Description = description;
            AllocId = allocId;
        }

        public override String ToString()
        {
            return Description;
        }
    }
}
