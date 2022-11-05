using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_DSI.Interfaces;

namespace TPI_DSI.Clases.Estados
{
    internal class Cancelado : EstadoTurno
    {
        public override EstadoTurno crearProximoEstado()
        {
            return null;
        }
    }
}
