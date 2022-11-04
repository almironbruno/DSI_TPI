using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class CentroInvestigacion
    {
        public string nombre { get; set; }
        public List<RecursoTecnologico> recursosTecnologicos = new List<RecursoTecnologico>();
        public List<AsignacionCientifico> asignacionCientificos = new List<AsignacionCientifico>();
        public int tiempoAntelacionRecurso { get; set; }
        public bool esTuRecurso(RecursoTecnologico recurso)
        { // Metodo 25: consulta si el recurso tecnologico pertenece al centro
            return recursosTecnologicos.Any(x => x.numeroRT == recurso.numeroRT);
        }

       public bool esCientificoDelCI(string usuario) 
        { //Metodo 34: consulta si el cientifico pretenece al centro de investigacion 
            foreach (AsignacionCientifico unaAsignacion in asignacionCientificos) 
            {
                if (unaAsignacion.esCientificoActivo(usuario))
                {
                    return true;
                }
            }
            return false;
        }

        public string getMail(string nombreUsuario)
        { //Metodo 37: obtiene el mail del cientifico del centro de investigacion
            foreach (AsignacionCientifico unaAsignacion in asignacionCientificos)
            {
                if (unaAsignacion.esCientificoActivo(nombreUsuario))
                {
                    return unaAsignacion.personalCientifico.correoElectronicoInstitucional; // Metodo 39: getMail obtiene el mail del cientifico

                }
            }
            return "";
        }
        public AsignacionCientifico GetAsignacionCientifico(string usuario) 
        { // Metodo 40: obtiene el puntero a la asignacion actual del cientifico
            AsignacionCientifico asignacionGenerica =new AsignacionCientifico();
            foreach (AsignacionCientifico unaAsignacion in asignacionCientificos)
            {
                if (unaAsignacion.esCientificoActivo(usuario))
                {
                    return unaAsignacion;

                }
            }
            return asignacionGenerica;
        }

    }
    
}
