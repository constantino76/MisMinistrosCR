using System.ComponentModel.DataAnnotations;
namespace MisministrosCR_VERSION1.Models
{
    public class Titulo
    {
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(150, ErrorMessage = "maximo 150 caracteres"), MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
        public string GradoAcademico { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60, ErrorMessage = "maximo 60 caracteres"), MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
        public string CentroUniversitario { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1900,2022)]
        public string Anio_titulo { get; set; }
    }
    }

    
