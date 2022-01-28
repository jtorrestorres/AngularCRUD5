using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ML
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }
        [Column(TypeName ="varchar(100")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(100")]
        public string Descripcion { get; set; }
        [Column(TypeName = "byte")]
        public byte Creditos { get; set; }
    }
}
