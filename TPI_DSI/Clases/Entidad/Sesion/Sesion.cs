using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class Sesion
    {
        public bool activa { get; set; }
        public Usuario usuario { get; set; }

        public string sosActiva() 
        {
            if(activa)
            {
                return usuario.nombre;
            }
            return "";
        }
    }
}
