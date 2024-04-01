using MisministrosCR_VERSION1.Models;

namespace MisministrosCR_VERSION1.Servicios
{
    public interface IServicioExperiencialaboral
    {
        public Task<bool> Insertar(Experiencia_trabajo exptrabajo);
        public Task<Oferente> Buscar(String  id);
        public Task<Oferente> Actualizar();
    }
}
