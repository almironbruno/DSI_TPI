using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class Estado
    {
        public string nombre { get; set; }

        public bool SosTecnicaDefinitiva()
        { //  Metodo 16: consulta si el nombre del estado es Baja Tecnica o  Baja Definitiva
            if ((nombre == "Baja Definitiva") | (nombre == "Baja Tecnica"))
            {
                return true;
            }
            return false;
        }
        public bool sosReservado()
        {
            if (nombre == "Reservado")
            {
                return true;
            }
            return false;
        }


    }
}
