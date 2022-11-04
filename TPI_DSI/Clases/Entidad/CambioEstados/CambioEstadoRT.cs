using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class CambioEstadoRT
    {
        public DateTime fechaHoraDesde { get; set; }
        public DateTime fechaHoraHasta { get; set; }
        public Estado estado { get; set; }




        public bool esActual()
        { // Metodo 14: consulta en los cambio de estado del recurso tecnologico que sea actual
            if (fechaHoraHasta == default(DateTime))
            {
                return true;
            }
            return false;
        }

        public bool esTecnicaODefinitiva()
        { // Metodo 15: consulta si el estado es Baja Tecnica o Definitiva
            if (estado.SosTecnicaDefinitiva())
            {
                return true;
            }
            return false;
        }




    }
}
