using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ChiropracticClinic.Models
{
    public class Producto
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [Range(0,100, ErrorMessage = "Debe ser mayor a cero")]
        public double Price { get; set; }
    }
}
