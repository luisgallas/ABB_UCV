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
        
        public List<Nodo> ObtenerRecorridoEnOrden()//Obtiene la lista de nodos en recorrido en orden.
        {
            List<Nodo> recorrido = new List<Nodo>();
            RecorridoEnOrden(Raiz, recorrido);
            return recorrido;
        }
        //metodo para recorrido en orden 
        private void RecorridoEnOrden(Nodo nodo, List<Nodo> recorrido)
        {
            if (nodo == null) return;
            RecorridoEnOrden(nodo.Izquierdo, recorrido);
            recorrido.Add(nodo);
            RecorridoEnOrden(nodo.Derecho, recorrido);
         
        }

        public List<Nodo> ObtenerRecorridoPreOrden()//Obtiene la lista de nodos en recorrido en Preorden.
        {
            List<Nodo> recorrido = new List<Nodo>();
            RecorridoPreOrden(Raiz, recorrido);
            return recorrido;
        }
        //metodo para el recorrido en preorden
        private void RecorridoPreOrden(Nodo nodo, List<Nodo> recorrido)
        {
            if (nodo == null) return;
            recorrido.Add(nodo);
            RecorridoPreOrden(nodo.Izquierdo, recorrido);
            RecorridoPreOrden(nodo.Derecho, recorrido);
            
        }

        public List<Nodo> ObtenerRecorridoPostOrden()////Obtiene la lista de nodos en recorrido en Postorden.
        {
            List<Nodo> recorrido = new List<Nodo>();
            RecorridoPostOrden(Raiz, recorrido);
            return recorrido;
        }
        //metodo para el recorrido es postorden
        private void RecorridoPostOrden(Nodo nodo, List<Nodo> recorrido)
        {
            if (nodo == null) return;
            RecorridoPostOrden(nodo.Izquierdo, recorrido);
            RecorridoPostOrden(nodo.Derecho, recorrido);
            recorrido.Add(nodo);
        }

        
        // Método para insertar un valor en el árbol
        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }
        //metodo para para verificar si insertar el valor hacia el nodo izquierdo o hacia el nodo derecho
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
       
        public bool Contiene(int valor)
        {
            return ContieneRecursivo(Raiz, valor);
        }
        //metodo que verifica que si el valor ya ha sido ingresado 
        private bool ContieneRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                return false;
            }
            if (nodo.Valor == valor)
            {
                return true;
            }
            if (valor < nodo.Valor)
            {
                return ContieneRecursivo(nodo.Izquierdo, valor);
            }
            else
            {
                return ContieneRecursivo(nodo.Derecho, valor);
            }
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
        
         public Nodo Rai { get; set; }

    // 

        public int ContarNodos(Nodo nodo)
         {
             if (nodo == null)
             return 0;

             return 1 + ContarNodos(nodo.Izquierdo) + ContarNodos(nodo.Derecho);
         }

         public int ObtenerCantidadNodos()
        {
            return ContarNodos(Raiz);
        }
         
        
         public int ContarNodosHojas(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            if (nodo.Izquierdo == null && nodo.Derecho == null)
                return 1;

            return ContarNodosHojas(nodo.Izquierdo) + ContarNodosHojas(nodo.Derecho);
        }

        public int ObtenerCantidadNodosHojas()
        {
            return ContarNodosHojas(Raiz);
        }
        //
        public Nodo EliminarMinimo(Nodo nodo)
        {
            if (nodo == null)
                return null;

            if (nodo.Izquierdo == null)
                return nodo.Derecho; // Si no tiene hijo izquierdo, su hijo derecho lo reemplaza

            nodo.Izquierdo = EliminarMinimo(nodo.Izquierdo); // Continuar buscando el mínimo
            return nodo;
        }

        public void EliminarNodoMinimo()
        {
            Raiz = EliminarMinimo(Raiz);
        }
    }
}
