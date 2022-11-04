using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class AsignacionCientifico
    {
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public PersonalCientifico personalCientifico { get; set; }
        public List<Turno> turnos = new List<Turno>();

        public bool esCientificoActivo(string usuario)
        { //Metodo 35: consulta que el cientifico sea activo
                if (personalCientifico.usuario.nombre == usuario) //Metodo 36: GetNombre, obtiene el nombre del nombre del cientifico
                {
                    return true;
                }
            return false;
        }
        public string getUsuario() 
        {
            return personalCientifico.usuario.nombre;
        }
        public string getMail()  
        {
            return personalCientifico.correoElectronicoInstitucional;
        }

        public void setearTurno(Turno unTurno)
        {   //metodo 66: setearTurno agrega un turno dentro de la asignacion
            turnos.Add(unTurno);
        
        }

    }

}
