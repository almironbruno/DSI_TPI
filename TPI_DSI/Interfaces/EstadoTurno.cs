using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_DSI.Clases;

namespace TPI_DSI.Interfaces
{
    public abstract class EstadoTurno
    {
        public string descripcion;
        public string nombre;

        public void anular()
        {

        }
        public void cancelar()
        {

        }
        public virtual void crearCambioEstadoTurno(EstadoTurno proxEstado, DateTime fechaDesde)
        {

        }
        public abstract EstadoTurno crearProximoEstado();
       
        public EstadoTurno getEstado()
        {
            return this;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public virtual void reservar(List<CambioEstadoTurno> cambiosEstados, DateTime fechaDesde)
        {

        }
    }
}
