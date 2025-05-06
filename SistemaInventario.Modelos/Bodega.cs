using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre Obligatorio")]
        [MaxLength(60, ErrorMessage = "Nombre debe ser Maximo 60 Caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripción Obligatorio")]
        [MaxLength(100, ErrorMessage = "Descripción debe ser Maximo 100 Caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado Obligatorio")]
        public bool Estado { get; set; }

    }
}
