using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_AAU4
{
    internal class AristaGrafo
    {
        public NodoGrafo NodoDestino { get; set; }
        public int Peso { get; set; }

        public AristaGrafo(NodoGrafo destino, int peso)
        {
            NodoDestino = destino;
            Peso = peso;
        }
    }
}
