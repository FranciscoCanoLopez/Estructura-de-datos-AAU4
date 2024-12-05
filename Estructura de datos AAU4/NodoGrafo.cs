using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_AAU4
{
    internal class NodoGrafo
    {
        public string Nombre { get; set; }
        public List<AristaGrafo> Aristas { get; set; }

        public NodoGrafo(string nombre)
        {
            Nombre = nombre;
            Aristas = new List<AristaGrafo>();
        }
    }
}
