using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Practica10_6_9_2
{
    class ClasePilaOrdenadaLista<Tipo> where Tipo :
IComparable<Tipo>, IEquatable<Tipo>
    {
        // Apuntador al primer nodo lógico de la Pila
        private ClaseNodo top;
        // Propiedad privada para acceder al top
        private ClaseNodo Top
        {
            get { return top; }
            set { top = value; }
        }
        // Declaración de la clase del nodo
        private class ClaseNodo
        {
            private Tipo objetocondatos; // Datos del nodo
            private ClaseNodo siguiente; // Apuntador al Siguiente nodo lógico
                                         // Propiedad pública para controlar los datos del nodo
            public Tipo ObjetoConDatos
            {
                get { return objetocondatos; }
                set { objetocondatos = value; }
            }
            // Propiedad pública para controlar el apuntador al Siguiente nodo
            public ClaseNodo Siguiente
            {
                get { return siguiente; }
                set { siguiente = value; }
            }
        }
        // Constructor
        public ClasePilaOrdenadaLista()
        {
            Top = null; // Inicializa la Pila vacía
        }
        // Método público para detectar si la Pila está vacía
        public bool EstaVacia()
        {
            if (Top == null)
                return (true);
            else
                return (false);
        }
        // Método público para detectar si un nodo está almacenado en la Pila
        // Devuelve el nodo en caso de encontrarlo
        public Tipo Buscar(Tipo Nodo)
        {
            ClaseNodo NodoActual = new ClaseNodo(); // Declaración del nodo local
                                                    // Inicia la búsqueda en el nodo apuntado por Top
            NodoActual = Top;
            while (NodoActual != null)
            {
                if (Nodo.Equals(NodoActual.ObjetoConDatos))
                    return (NodoActual.ObjetoConDatos); // Devuelve el NodoActual
                NodoActual = NodoActual.Siguiente; //Cambia de NodoActual
            }
            return (default(Tipo)); // Termina la búsqueda(no existe)
        }
        // Método público para insertar un nodo en la pila
        public void Push(Tipo Nodo)
        {
            // Declaración local del nodo que se desea insertar
            ClaseNodo NuevoNodo, NodoActual, NodoAnterior;
            if (EstaVacia())
            {
                NuevoNodo = new ClaseNodo();
                NuevoNodo.ObjetoConDatos = Nodo;
                NuevoNodo.Siguiente = null;
                Top = NuevoNodo;
                return;
            }
            NodoActual = Top;
            NodoAnterior = NodoActual;
            while (NodoActual != null)
            {
                // Para evitar duplicados, habilite las siguientes dos líneas de código
                //if (Nodo.Equals(NodoActual.ObjetoConDatos))
                    //throw new Exception("Duplicado ...");
                if (Nodo.CompareTo(NodoActual.ObjetoConDatos) < 0)
                    if (Nodo.CompareTo(Top.ObjetoConDatos)
                    < 0)
                    {
                        NuevoNodo = new ClaseNodo();
                        NuevoNodo.ObjetoConDatos = Nodo;
                        NuevoNodo.Siguiente = Top;
                        Top = NuevoNodo;
                        return;
                    }
                    else
                    {
                        // Alta intermedia
                        NuevoNodo = new ClaseNodo(); //Creación del nuevo nodo
                        NuevoNodo.ObjetoConDatos = Nodo;
                        // Asigna los datos
                        NuevoNodo.Siguiente = NodoActual;
                        // El NuevoNodo apunta al NodoActual
                        NodoAnterior.Siguiente = NuevoNodo;
                        // El NodoAnterior apunta al NuevoNodo
                        return;
                    }
                NodoAnterior = NodoActual; // Guarda el NodoAnterior
                NodoActual = NodoActual.Siguiente; // Cambio del NodoActual
            }
            // Alta al final de la lista
            NuevoNodo = new ClaseNodo(); // Creación del  NuevoNodo
            NuevoNodo.ObjetoConDatos = Nodo; // Asignación de los datos
            NuevoNodo.Siguiente = null; // El NuevoNodo apunta a nulo
            NodoAnterior.Siguiente = NuevoNodo; // El NodoAnterior apunta al NuevoNodo
            return;
        }
        // Método público para eliminar el primer nodo lógico de la Pila
        // Devuelve el nodo eliminado
        public Tipo Pop()
        {
            if (EstaVacia()) // Si está vacía ...
                throw new Exception("Vacía...");
            ClaseNodo NodoEliminado;
            ClaseNodo Nodo = new ClaseNodo();
            Nodo = Top;
            Top = Nodo.Siguiente; // Ahora el Top apunta al nodo apuntado por el Nodo eliminado
            NodoEliminado = Nodo;
            Nodo = null; // Se elimina el Nodo
            return (NodoEliminado.ObjetoConDatos); // Devuelve el nodo eliminado
        }
        public Tipo Eliminar(Tipo Nodo)
        {
            ClaseNodo NodoActual, NodoAnterior,
            NodoEliminado; // Declaración del nodo local
            if (EstaVacia()) // Si está vacía ...
                return (default(Tipo));
            else
            {
                // Inicia la búsqueda en el nodo apuntado por Top
                NodoActual = Top;
                NodoAnterior = NodoActual;
                while (NodoActual != null)
                {
                    if
                    (Nodo.Equals(NodoActual.ObjetoConDatos))
                    {
                        NodoEliminado = new ClaseNodo();
                        NodoEliminado = NodoActual;
                        if (NodoActual == Top)
                        {
                            Top = NodoActual.Siguiente;
                            NodoActual = null;
                        }
                        else
                        {
                            NodoAnterior.Siguiente =
                            NodoActual.Siguiente;
                            NodoActual = null;
                        }
                        return
                        (NodoEliminado.ObjetoConDatos); // Devuelve el NodoActual
                    }
                    NodoAnterior = NodoActual;
                    NodoActual = NodoActual.Siguiente; // Cambia de NodoActual
                }
                return (default(Tipo)); // Termina la búsqueda(no existe)
            }
        }
        // Método público para eliminar todos los nodos de la pila
        public void Vaciar()
        {
            if (EstaVacia()) // Si está vacía
                throw new Exception("Vacía ...");
            // Declaraciones locales de los nodos
            ClaseNodo NodoActual, NodoAnterior;
            // Inicia el recorrido de los nodos en el Top
            NodoActual = Top;
            NodoAnterior = NodoActual;
            // Mientras haya nodos en la pila ...
            while (NodoActual != null)
            {
                Top = NodoActual.Siguiente; // Ahora el Top  apunta al nodo apuntado por el NodoActual
                NodoAnterior = NodoActual; // Guarda el NodoAnterior
                NodoActual = NodoActual.Siguiente; // Cambia de NodoActual
                NodoAnterior = null; // Elimina el NodoAnterior
            }
        }
        // Iterador de la lista
        public IEnumerator<Tipo> GetEnumerator()
        {
            if (EstaVacia()) // Si está vacía ...
                yield break;
            // Declaración local del NodoActual
            ClaseNodo NodoActual = new ClaseNodo();
            // Inicia el recorrido de la Pila en el Top
            NodoActual = Top;
            while (NodoActual != null) // Mientras haya nodos...
            {
                yield return
                (Tipo)NodoActual.ObjetoConDatos; // Devuelve el NodoActual
                NodoActual = NodoActual.Siguiente; //Cambia de NodoActual
            }
        }
    }
}
