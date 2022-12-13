using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP
{
    [Table("Desenvolvedores")]
    internal class Desenvolvedor
    {
        public Int64 Id { get; set; }

        [Required]
        [StringLength(45)]
        public String Nome { get; set; }

        public DateTime Nascimento { get; set; }

        [NotMapped]
        public Char NivelMemoria { get; set; }

        //gets the level assigned in memory and puts it into the database
        [Column(TypeName = "char")]
        [StringLength(1)]
        public String NivelBD
        {
            get
            {
                return NivelMemoria.ToString();
            }
            set
            {
                NivelMemoria = value[0];
            }
        }

        public Credencial Credencial { get; set; }

        public Desenvolvedor()
        {

        }
    }
}
