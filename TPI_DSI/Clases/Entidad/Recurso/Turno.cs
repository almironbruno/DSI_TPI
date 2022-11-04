using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class Turno
    {
        public string diaSemana { set; get; }
        public DateTime fechaGeneracion { set; get; }
        public DateTime fechaHoraInicio { set; get; }
        public DateTime fechaHoraFin { set; get; }
        public List<CambioEstadoTurno> cambioEstadoTurno = new List<CambioEstadoTurno>();

        public bool esFechaValida(DateTime fecha)
        { //Metodo 45: consulta que la fecha de inicio del turno sea mayor a la fecha hora actual 
            return fechaHoraInicio >= fecha;
        }


        public void registrarNuevaReserva(Estado reservado,DateTime fechaDesde)
        {//Metodo 62: registrar una nueva reserva del turno
            foreach (var unCambioEstado in cambioEstadoTurno)
            {
                if (unCambioEstado.esActual())
                {
                    unCambioEstado.fechaHorahasta = fechaDesde;//Metodo 64: setFechaHasta
                    break;
                }
            }
            
            CambioEstadoTurno nuevo = new CambioEstadoTurno();
            nuevo.estado = reservado;
            nuevo.fechaHoraDesde = fechaDesde;
            cambioEstadoTurno.Add(nuevo);
        }
    }

    
}
