using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_UCV
{
    internal class ArbolBinario
    {
        public Nodo Raiz { get; private set; } // Raíz del árbol

        public ArbolBinario()
        {
            Raiz = null;
        }

        // Método para insertar un valor en el árbol
        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                nodo = new Nodo(valor);
            }
            else if (valor < nodo.Valor)
            {
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
            }
            else
            {
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);
            }
            return nodo;
        }

        // Método para calcular la suma de los elementos del árbol
        public int SumaElementos(Nodo nodo)
        {
            if (nodo == null) return 0;
            return nodo.Valor + SumaElementos(nodo.Izquierdo) + SumaElementos(nodo.Derecho);
        }

        // Método para calcular la suma de los múltiplos de un número
        public int SumaMultiplos(Nodo nodo, int multiplo)
        {
            if (nodo == null) return 0;
            int suma = 0;
            if (nodo.Valor % multiplo == 0)
            {
                suma += nodo.Valor;
            }
            return suma + SumaMultiplos(nodo.Izquierdo, multiplo) + SumaMultiplos(nodo.Derecho, multiplo);
        }

        // Método para encontrar el elemento máximo
        public int Maximo(Nodo nodo)
        {
            if (nodo == null) throw new InvalidOperationException("El árbol está vacío");
            while (nodo.Derecho != null) nodo = nodo.Derecho;
            return nodo.Valor;
        }

        // Método para encontrar el elemento mínimo
        public int Minimo(Nodo nodo)
        {
            if (nodo == null) throw new InvalidOperationException("El árbol está vacío");
            while (nodo.Izquierdo != null) nodo = nodo.Izquierdo;
            return nodo.Valor;
        }

        // Método para determinar la altura del árbol
        public int Altura(Nodo nodo)
        {
            if (nodo == null) return 0;
            return 1 + Math.Max(Altura(nodo.Izquierdo), Altura(nodo.Derecho));
        }

        // Método para el recorrido InOrden
        public void InOrden(Nodo nodo, Action<int> accion)
        {
            if (nodo == null) return;
            InOrden(nodo.Izquierdo, accion);
            accion(nodo.Valor);
            InOrden(nodo.Derecho, accion);
        }

        // Método para el recorrido PreOrden
        public void PreOrden(Nodo nodo, Action<int> accion)
        {
            if (nodo == null) return;
            accion(nodo.Valor);
            PreOrden(nodo.Izquierdo, accion);
            PreOrden(nodo.Derecho, accion);
        }

        // Método para el recorrido PosOrden
        public void PosOrden(Nodo nodo, Action<int> accion)
        {
            if (nodo == null) return;
            PosOrden(nodo.Izquierdo, accion);
            PosOrden(nodo.Derecho, accion);
            accion(nodo.Valor);
        }
    }
}
