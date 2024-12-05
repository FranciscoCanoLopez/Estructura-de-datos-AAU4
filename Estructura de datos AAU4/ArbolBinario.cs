using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_AAU4
{
    internal class ArbolBinario
    {
        private NodoArbol Raiz;

        public ArbolBinario()
        {
            Raiz = null!;
        }

        // Inserción
        public void Insertar(int valor)
        {
            Raiz = InsertarNodo(Raiz, valor);
        }

        private NodoArbol InsertarNodo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
                return new NodoArbol(valor);

            if (valor < nodo.Valor)
                nodo.Izquierdo = InsertarNodo(nodo.Izquierdo, valor);
            else if (valor > nodo.Valor)
                nodo.Derecho = InsertarNodo(nodo.Derecho, valor);

            return nodo;
        }

        // Búsqueda
        public bool Buscar(int valor)
        {
            return BuscarNodo(Raiz, valor);
        }

        private bool BuscarNodo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
                return false;

            if (valor == nodo.Valor)
                return true;

            if (valor < nodo.Valor)
                return BuscarNodo(nodo.Izquierdo, valor);
            else
                return BuscarNodo(nodo.Derecho, valor);
        }

        // Eliminación
        public void Eliminar(int valor)
        {
            Raiz = EliminarNodo(Raiz, valor);
        }

        private NodoArbol EliminarNodo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
                return null!;

            if (valor < nodo.Valor)
            {
                nodo.Izquierdo = EliminarNodo(nodo.Izquierdo, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecho = EliminarNodo(nodo.Derecho, valor);
            }
            else
            {
                // Nodo con un solo hijo o sin hijos
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                // Nodo con dos hijos
                NodoArbol sucesor = MinimoValorNodo(nodo.Derecho);
                nodo.Valor = sucesor.Valor;
                nodo.Derecho = EliminarNodo(nodo.Derecho, sucesor.Valor);
            }

            return nodo;
        }

        private NodoArbol MinimoValorNodo(NodoArbol nodo)
        {
            NodoArbol actual = nodo;
            while (actual.Izquierdo != null)
            {
                actual = actual.Izquierdo;
            }
            return actual;
        }

        // Recorrido en InOrden (opcional, para mostrar el árbol)
        public List<int> InOrden()
        {
            List<int> valores = new List<int>();
            InOrdenRecorrido(Raiz, valores);
            return valores;
        }

        private void InOrdenRecorrido(NodoArbol nodo, List<int> valores)
        {
            if (nodo != null)
            {
                InOrdenRecorrido(nodo.Izquierdo, valores);
                valores.Add(nodo.Valor);
                InOrdenRecorrido(nodo.Derecho, valores);
            }
        }
    }
}
