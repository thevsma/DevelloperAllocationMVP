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
    internal class Task
    {
        public Int64 Id { get; set; }
        
        [MaxLength(200)]
        public String Description { get; set; }

        public Task()
        {

        }
    }
}
