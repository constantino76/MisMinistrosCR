
using System.ComponentModel.DataAnnotations;
namespace MisministrosCR_VERSION1.Models
{
    public class Experiencia_trabajo
    {
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(150, ErrorMessage = "maximo 150 caracteres"), MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
          public String Nombre_Empresa { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Range(1900,2022)]
        public int Anio_inicio { get; set; }
        [Range(1900, 2022)]
        [Required(ErrorMessage = "Campo requerido")]
        public int Anio_fin { get; set; }

    }
}
