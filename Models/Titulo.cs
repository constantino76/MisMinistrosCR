using System.ComponentModel.DataAnnotations;
namespace MisministrosCR_VERSION1.Models
{
    public class Titulo
    {
        [Key]
        public int TituloId { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(150, ErrorMessage = "maximo 150 caracteres"), MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
        public string GradoAcademico { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60, ErrorMessage = "maximo 60 caracteres"), MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
        public string CentroUniversitario { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1900,2024)]
        public int Anio_titulo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public String OferenteId { get; set; }
    }
    }

    
