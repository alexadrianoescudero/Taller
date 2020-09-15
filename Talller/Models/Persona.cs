using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Talller.Models
{
    public class Persona
    {
        [Required]
        [StringLength(10)]
        public string Ceduela { get; set; }
        [Description("Demonstrates Nombre.")]
        [DisplayName("Nombre")]
        [Required]        
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Direccion { get; set; }
    }
}
