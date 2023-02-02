using DeveloperAllocationMVP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP
{
    [Table("Developers")]
    public class Developer
    {
        public Int64 Id { get; set; }

        [Required]
        [StringLength(45)]
        public String Name { get; set; }

        public DateTime Birthday { get; set; }

        [NotMapped]
        public Char LvlInMemory { get; set; }

        //gets the level assigned in memory and puts it into the database
        [Column(TypeName = "char")]
        [StringLength(1)]
        public String Level
        {
            get
            {
                return LvlInMemory.ToString();
            }
            set
            {
                LvlInMemory = value[0];
            }
        }

        public Credential Credential { get; set; }

        [NotMapped]
        public List<Allocation> Allocations { get; set; }

        public Developer()
        {

        }

        public Developer(String name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public override String ToString()
        {
            return Name;
        }
    }
}
