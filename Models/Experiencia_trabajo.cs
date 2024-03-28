
using System.ComponentModel.DataAnnotations;
namespace MisministrosCR_VERSION1.Models
{
    public class Experiencia_trabajo
    {
        [Key]
        public int Idtrabajo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(150, ErrorMessage = "maximo 150 caracteres"), MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
          public String Nombre_Empresa { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Range(1900,2024)]
        public int Anio_inicio { get; set; }
        [Range(1900, 2024)]
        [Required(ErrorMessage = "Campo requerido")]
        public int Anio_fin { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public String OferenteId { get; set; }

    }
}
