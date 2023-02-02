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
        public List<ProjectTasks> Tasks { get; set; }

        public Allocation()
        {
            Tasks = new List<ProjectTasks>();
        }

        public Allocation(DateTime start, DateTime completion, Byte hours, Decimal pay, Developer dev, Project proj)
        {
            Tasks = new List<ProjectTasks>();
            Start = start;
            Completion = completion;
            WeeklyHours = hours;
            Payment = pay;
            Developer = dev;
            Project = proj;
        }

        public override String ToString()
        {
            return String.Format("Desenvolvedor: {0} / Projeto: {1}", Developer, Project);
        }
    }
}