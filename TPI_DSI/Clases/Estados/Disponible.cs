using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_DSI.Interfaces;
namespace TPI_DSI.Clases.Estados
{
    public class Disponible : EstadoTurno
    {
        
        public Disponible()
        {
            nombre = "Disponible";
        }
        public void reservar(List<CambioEstadoTurno> cambiosEstados, DateTime fechaDesde) 
        {
            foreach (var unCambioEstado in cambiosEstados)
            {
                //Metodo 64: sosActual()
                if (unCambioEstado.esActual())
                {
                    //Metodo 65: setFechaHasta
                    unCambioEstado.fechaHorahasta = DateTime.Now;
                    break;
                }
            }

            //Metodo 66: crearProximoEstado()
            EstadoTurno reservado = crearProximoEstado();

            //Metodo 68: crearCambioEstadoTurno()
            crearCambioEstadoTurno(reservado,fechaDesde);
        }

        public override EstadoTurno crearProximoEstado()
        {
            EstadoTurno reservado = new Reservado();
            return reservado;
        }

        public override void crearCambioEstadoTurno(EstadoTurno proxEstado,DateTime fechaDesde) 
        {
            //Metodo 68--Repetido Numero
            CambioEstadoTurno nuevoCambioEstadoTurno = new CambioEstadoTurno(proxEstado,fechaDesde);
        
        }


    }
}
