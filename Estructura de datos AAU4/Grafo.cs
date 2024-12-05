using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_AAU4
{
    internal class Grafo
    {
        public List<NodoGrafo> Nodos { get; set; }

        public Grafo()
        {
            Nodos = new List<NodoGrafo>();
        }

        public void AgregarNodo(string nombre)
        {
            if (Nodos.Any(n => n.Nombre == nombre))
                throw new Exception("El nodo ya existe.");
            Nodos.Add(new NodoGrafo(nombre));
        }

        public void AgregarArista(string origen, string destino, int peso)
        {
            NodoGrafo nodoOrigen = Nodos.FirstOrDefault(n => n.Nombre == origen)!;
            NodoGrafo nodoDestino = Nodos.FirstOrDefault(n => n.Nombre == destino)!;

            if (nodoOrigen == null || nodoDestino == null)
                throw new Exception("Nodos de origen o destino no encontrados.");

            nodoOrigen.Aristas.Add(new AristaGrafo(nodoDestino, peso));
        }

        public NodoGrafo BuscarNodo(string nombre)
        {
            return Nodos.FirstOrDefault(n => n.Nombre == nombre)!;
        }

        public List<string> RecorridoDFS(string inicio)
        {
            NodoGrafo nodoInicio = BuscarNodo(inicio);
            if (nodoInicio == null)
                throw new Exception("Nodo inicial no encontrado.");

            var visitados = new HashSet<NodoGrafo>();
            var resultado = new List<string>();
            DFS(nodoInicio, visitados, resultado);
            return resultado;
        }

        private void DFS(NodoGrafo nodo, HashSet<NodoGrafo> visitados, List<string> resultado)
        {
            if (visitados.Contains(nodo))
                return;

            visitados.Add(nodo);
            resultado.Add(nodo.Nombre);

            foreach (var arista in nodo.Aristas)
            {
                DFS(arista.NodoDestino, visitados, resultado);
            }
        }
    }
}
