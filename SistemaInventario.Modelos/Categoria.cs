using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es Rquerido")]
        [MaxLength(60, ErrorMessage = "Nombre debe ser Maximo 60 Caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripción es Rquerido")]
        [MaxLength(60, ErrorMessage = "Descripción debe ser Maximo 60 Caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es Rquerido")]
        public bool Estado { get; set; }
    }
}
