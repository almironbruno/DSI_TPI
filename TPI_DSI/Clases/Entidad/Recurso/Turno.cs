using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_DSI.Interfaces;
namespace TPI_DSI.Clases
{
    internal class Turno
    {
        public string diaSemana { set; get; }
        public DateTime fechaGeneracion { set; get; }
        public DateTime fechaHoraInicio { set; get; }
        public DateTime fechaHoraFin { set; get; }

        public List<CambioEstadoTurno> cambioEstadoTurno = new List<CambioEstadoTurno>();

        public EstadoTurno estado;

        public bool esFechaValida(DateTime fecha)
        { //Metodo 45: consulta que la fecha de inicio del turno sea mayor a la fecha hora actual 
            return fechaHoraInicio >= fecha;
        }


        public void registrarNuevaReserva()
        {//Metodo 62: registrar una nueva reserva del turno
            foreach (var unCambioEstado in cambioEstadoTurno)
            {
                //Metodo 64: sosActual()
                if (unCambioEstado.esActual())
                {
                    //Metodo 65: setFechaHasta
                    unCambioEstado.fechaHorahasta = DateTime.Now;
                    break;
                }
            }
            
            //CambioEstadoTurno nuevo = new CambioEstadoTurno();
            //nuevo.estado = reservado;
            //nuevo.fechaHoraDesde = fechaDesde;
            //cambioEstadoTurno.Add(nuevo);
        }

        public void añadirCambioEstado(CambioEstadoTurno cambioEstado)
        {
            cambioEstadoTurno.Add(cambioEstado);
        
        }

        public void setEstadoActual(EstadoTurno estado)
        {
            this.estado = estado;
        }
    }

    
}
