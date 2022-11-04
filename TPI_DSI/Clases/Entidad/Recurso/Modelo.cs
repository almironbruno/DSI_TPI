using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class Modelo
    {
        public string nombre { set; get; }

        public bool esTuMarca(Marca marca)
        { // Metodo 21: esTuMarca verifica que el modelo sea de la marca
                if (marca.esTuModelo(this))
                {
                    return true;
                }
            return false;
        }
    }
}
