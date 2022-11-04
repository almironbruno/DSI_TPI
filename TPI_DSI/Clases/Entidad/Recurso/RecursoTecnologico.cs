using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class RecursoTecnologico
    {
        

        /// <summary>
        /// Atributos de la clase RecursoTecnologico
        /// </summary>
        public int numeroRT { set; get; }
        public Modelo modelo { set; get; }
        public List<Turno> turnos = new List<Turno>();
        public List<CambioEstadoRT> cambioEstadoRT = new  List<CambioEstadoRT>();
        public TipoRecurso tipoRecursoTecnologico { set; get; }
        
        public RecursoTecnologico() 
        {
            numeroRT = 1;
        }

        public bool esTipoSeleccionado(string seleccionTipoRecurso)
        { // Metodo 10: funcion que verifica que sea de tipo de recurso seleccionado
            if (seleccionTipoRecurso == tipoRecursoTecnologico.getNombre())
            {
                return true;
            }
            return false;
        }

        public bool sosTecnicaODefinitiva()
        { // Metodo 12: consulta el estado del recurso tecnologico y verifica que sea Baja Tecnica o Baja Definitiva
            foreach (CambioEstadoRT CambioEstado in cambioEstadoRT)
            {
                if (CambioEstado.esActual())
                {
                    if(CambioEstado.esTecnicaODefinitiva())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool sosMiCentro(CentroInvestigacion centro)
        { //metodo 32: obtiene el centro al que pertenece el recurso tecnologico
            return centro.esTuRecurso(this);
        }

        public string getEstadoActual()
        {
            foreach (CambioEstadoRT CambioEstado in cambioEstadoRT)
            {
                if (CambioEstado.esActual())
                {
                   return CambioEstado.estado.nombre;
                }
            }
            return "";
        }

        public List<Turno> MisTurnosDisponibles(DateTime fecha)
        { //Metodo 44: obtiene todos los turnos disponibles del recurso tecnologico seleccionado desde la fecha
            List<Turno> Turnos = new List<Turno>();
            foreach(Turno unTurno in turnos)
            {
                if (unTurno.esFechaValida(fecha)) 
                {
                    foreach (var unCambioEstado in unTurno.cambioEstadoTurno) //Metodo 46: esEstadoActual consulta en todos los cambios de estado que sea el actual. 
                    { 
                        if (unCambioEstado.esActual())
                        {
                            //if (unCambioEstado.estado.nombre!="Reservado") 
                            //{
                                Turnos.Add(unTurno); //Metodo 48: getTurno obtiene y guarda el puntero al turno}
                            //}
                        }
                    }
                 }
             }
            
              
            return Turnos;
        }

        public void cambiarANoDisponible()
        {
            foreach(CambioEstadoRT unCambio in cambioEstadoRT) 
            {
                if (unCambio.esActual()) 
                {
                    unCambio.fechaHoraHasta = DateTime.Now;
                    break;
                }

            
            }

            Estado NoDisponible = new Estado();
            NoDisponible.nombre = "No Disponible";

            CambioEstadoRT nuevoCambio = new CambioEstadoRT();
            nuevoCambio.fechaHoraDesde = DateTime.Now;
            nuevoCambio.estado = NoDisponible;
            cambioEstadoRT.Add(nuevoCambio);
            
        }



    }
}
