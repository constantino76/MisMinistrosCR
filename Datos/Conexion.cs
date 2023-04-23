

using MisministrosCR_VERSION1.Models;
using Microsoft.Extensions.Caching.Memory;

namespace MisministrosCR_VERSION1.Datos
{    
    public class Conexion
    {
        private readonly IMemoryCache cache; 
        public Conexion(IMemoryCache _cache) {

            cache = _cache;
        }

        public List<Oferente> obetenerOferentes() {

            List<Oferente> listado = null;
            if (cache.Get("listado") == null)
            {

                listado = new List<Oferente>();
                cache.Set("listado", listado);
            }
            else {

                listado = (List<Oferente>)cache.Get("listado");
            
            }

            return listado;
        
        }

    }
}
