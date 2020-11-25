using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003a_ColaLista
{
    class ClaseColaLista<Tipo> where Tipo : IComparable<Tipo>,
IEquatable<Tipo>
    {
        // Apuntador al primer nodo lógico de la Cola-Lista
        private ClaseNodo frente;
        // Apuntador al último nodo lógico de la Cola-Lista
        private ClaseNodo final;
        // Propiedad privada para acceder al frente de la Cola-Lista
        private ClaseNodo Frente
        {
            get { return frente; }
            set { frente = value; }
        }
        // Propiedad privada para acceder al final de la Cola-Lista
        private ClaseNodo Final
        {
            get { return final; }
            set { final = value; }
        }
        // Declaración de la clase del nodo
        private class ClaseNodo
        {
            private Tipo objetocondatos; // Datos del nodo
            private ClaseNodo siguiente; // Apuntador al  siguiente nodo lógico
                                         // Propiedad pública para controlar los datos del nodo
            public Tipo ObjetoConDatos
            {
                get { return objetocondatos; }
                set { objetocondatos = value; }
            }
            // Propiedad pública para controlar el apuntador al siguiente nodo
            public ClaseNodo Siguiente
            {
                get { return siguiente; }
                set { siguiente = value; }
            }
        }
        // Constructor
        public ClaseColaLista()
        {
            Frente = null; // Inicializa la Cola-Lista vacía
            Final = null;
        }
        // Método público para detectar si la Cola-Lista está vacía
        public bool EstaVacia()
        {
            if (Frente == null)
                return (true);
            else
                return (false);
        }
        // Método público para detectar si un nodo está almacenado en la Cola-Lista
        // Devuelve los datos del nodo en caso de  encontrarlo
        public Tipo Buscar(Tipo Nodo)
        {
            ClaseNodo NodoActual = new ClaseNodo(); //Declaración del nodo local
                                                    // Inicia la búsqueda en el nodo apuntado porFrente
            NodoActual = Frente;
            while (NodoActual != null)
            {
                // Comparación para detectar si ya existe
                if (Nodo.Equals(NodoActual.ObjetoConDatos))
                    return (NodoActual.ObjetoConDatos); // Devuelve el NodoActual
                NodoActual = NodoActual.Siguiente; //Cambia de NodoActual
            }
            return (default(Tipo)); // Termina la búsqueda(no existe)
        }
        // Método público para insertar un nodo en la Cola-Lista
        public void Encolar(Tipo Nodo)
        {
            // Declaración local del nodo que se desea insertar
            ClaseNodo NuevoNodo;
            if (EstaVacia())
            {
                NuevoNodo = new ClaseNodo(); // Creación del NuevoNodo
                NuevoNodo.ObjetoConDatos = Nodo; // Asignación de los datos
                NuevoNodo.Siguiente = null; // El NuevoNodo apunta a nulo
                Frente = NuevoNodo; // El NuevoNodo se convierte en el primer nodo de la Cola-Lista
                Final = NuevoNodo; // El NuevoNodo se convierte en el último nodo de la Cola-Lista
                return;
            }
            // Búsqueda del Nodo que se desea insertar
            if (Buscar(Nodo) != null)
                throw new Exception("Duplicado ..."); //  No se permiten duplicados
            NuevoNodo = new ClaseNodo(); // Creación del  NuevoNodo
            NuevoNodo.ObjetoConDatos = Nodo; // Asignación de los datos
            NuevoNodo.Siguiente = null; // El NuevoNodo apunta a nulo
            Final.Siguiente = NuevoNodo;
            Final = NuevoNodo; // El NuevoNodo se convierte en el último nodo de la Cola-Lista
        }
        // Método público para eliminar el primer nodo lógico de la Cola-Lista
        // Devuelve el nodo eliminado
        public Tipo Desencolar()
        {
            ClaseNodo NodoEliminado;
            if (EstaVacia()) // Si está vacía ...
                throw new Exception("Vacía...");
            if (Frente == Final)
            {
                NodoEliminado = Frente;
                Frente = null;
                Final = null;
            }
            else
            {
               // ClaseNodo Nodo = new ClaseNodo();
                NodoEliminado = Frente;
                Frente = NodoEliminado.Siguiente; // Ahora el  Frente apunta al nodo apuntado por el Nodo eliminado
                //NodoEliminado = Nodo;
                //Nodo = null; // Se elimina el Nodo
            }
            return (NodoEliminado.ObjetoConDatos); // Devuelve los datos del nodo eliminado
        }
        // Método público para eliminar todos los nodos de la Cola-Lista
        public void Vaciar()
        {
            if (EstaVacia()) // Si está vacía
                throw new Exception("Vacía ...");
            // Declaraciones locales de los nodos
            ClaseNodo NodoActual, NodoAnterior;
            // Inicia el recorrido de los nodos en el Frente
            NodoActual = Frente;
            NodoAnterior = NodoActual;
            // Mientras haya nodos en la Cola-Lista ...
            while (NodoActual != null)
            {
                Frente = NodoActual.Siguiente; // Ahora el  Frente apunta al nodo apuntado por el NodoActual
                NodoAnterior = NodoActual; // Guarda el  NodoAnterior
                NodoActual = NodoActual.Siguiente; //  Cambia de NodoActual
                NodoAnterior = null; // Elimina el NodoAnterior
            }
            Frente = null; // Inicializa la Cola-Lista  vacía
            Final = null;
        }
        // Iterador para recorrer los nodos de la Cola- Lista
        public IEnumerator<Tipo> GetEnumerator()
        {
            if (EstaVacia()) // Si está vacía ...
                yield break;
            // Declaración local del NodoActual
            ClaseNodo NodoActual = new ClaseNodo();
            // Inicia el recorrido de la Cola-Lista en el Frente
            NodoActual = Frente;
            while (NodoActual != null) // Mientras hayanodos...
            {
                yield return
                (Tipo)NodoActual.ObjetoConDatos; // Devuelve los datos del  NodoActual
                NodoActual = NodoActual.Siguiente; // Cambia de NodoActual
            }
        }
    }
}
