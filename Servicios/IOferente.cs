using Microsoft.AspNetCore.Mvc;
using MisministrosCR_VERSION1.Models;

namespace MisministrosCR_VERSION1.Servicios
{
    public interface IOferente
    {
        public Task<bool> Insertar(Oferente oferente);


        public Task<Oferente> Buscar(string id);
        
    
    public  Task<bool>  Actualizar(Oferente oferente);
        public  Task<List<Oferente>> VerOferentes();

       public void  asignarId(Oferente oferente);
        public void asignarId_(Oferente oferente);
    }

  
}
