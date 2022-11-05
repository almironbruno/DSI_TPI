using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_DSI.Interfaces;

namespace TPI_DSI.Clases
{
    public class CambioEstadoTurno
    {
        public DateTime fechaHoraDesde { get; set; }
        public DateTime fechaHorahasta { get; set; }
        public EstadoTurno estado { get; set; }

        public CambioEstadoTurno(EstadoTurno estado, DateTime fechaDesde)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaDesde;
        }
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
