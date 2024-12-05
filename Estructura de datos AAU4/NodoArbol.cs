using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_AAU4
{
    internal class NodoArbol
    {
        public int Valor;
        public NodoArbol Izquierdo;
        public NodoArbol Derecho;

        public NodoArbol(int valor)
        {
            Valor = valor;
            Izquierdo = null!;
            Derecho = null!;
        }
    }
}
