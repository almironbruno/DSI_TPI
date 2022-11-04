using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_DSI.Clases
{
    internal class Marca
    {
        public string nombre { get; set; }
        public List<Modelo> modelos = new List<Modelo>();

        public bool esTuModelo(Modelo modelo)
        {  // Metodo 23: esTuModelo verifica que el modelo pertenece a la marca
            return modelos.Any(x => x.nombre == modelo.nombre);
        }
    }
}
