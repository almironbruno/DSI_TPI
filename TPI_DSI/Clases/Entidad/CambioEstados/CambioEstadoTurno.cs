using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class CambioEstadoTurno
    {
        public DateTime fechaHoraDesde { get; set; }
        public DateTime fechaHorahasta { get; set; }
        public Estado estado { get; set; }

        public bool esActual()
        { // Metodo 47: consulta si el cambio de estado es el actual
            if (fechaHorahasta == default(DateTime))
            {
                return true;
            }
            return false;
        }
    }
}
