using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3er_Corte
{
    class ClasePilaDesordenadaLista<Tipo> where Tipo :
 IComparable<Tipo>, IEquatable<Tipo>
    {
        // Apuntador al primer nodo lógico de la Pila- Lista
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
            private Tipo objetocondatos; // Objeto con los datos del nodo
            private ClaseNodo siguientenodo; // Apuntador al siguiente nodo lógico
                                             // Propiedad pública para controlar los datos del nodo
            public Tipo ObjetoConDatos
            {
                get { return objetocondatos; }
                set { objetocondatos = value; }
            }
            // Propiedad pública para controlar el apuntador al siguiente nodo
            public ClaseNodo SiguienteNodo
            {
                get { return siguientenodo; }
                set { siguientenodo = value; }
            }
        }
        // Constructor
        public ClasePilaDesordenadaLista()
        {
            Top = null; // Inicializa la Pila-Lista vacía
        }
        // Método público para detectar si la Pila- Lista está vacía
        public bool EstaVacia()
        {
            if (Top == null)
                return (true);
            else
                return (false);
        }

        //metodo publico para detectar si la Pila-Lista esta llena
        //public bool EstaLlena()
        //{
        //    if (Top.Equals(4))
        //        return true;
        //    else
        //        return false;
        //}

        // Método público para detectar si un nodo está almacenado en la Pila-Lista
        // Devuelve el nodo en caso de encontrarlo
        public Tipo Buscar(Tipo Nodo)
        {
            ClaseNodo NodoActual = new ClaseNodo(); // Declaración del nodo local
                                                    // Inicia la búsqueda en el nodo apuntado por Top
            NodoActual = Top;
            while (NodoActual != null)
            {
                // Comparación para detectar si el Nodo es igual al NodoActual
                if (Nodo.Equals(NodoActual.ObjetoConDatos))
                    return (NodoActual.ObjetoConDatos);
                // Devuelve el NodoActual
                NodoActual = NodoActual.SiguienteNodo;
                // Cambia de NodoActual
            }
            return (default(Tipo)); // Termina la búsqueda(no existe)
        }
        // Método público para insertar un nodo en la Pila-Lista
        public void Push(Tipo Nodo)
        {
            //if (!EstaLlena())
            //{
                // Declaración local del nodo que se desea insertar
                ClaseNodo NuevoNodo;
                // Búsqueda del Nodo que se desea insertar
                if (Buscar(Nodo) != null)
                    throw new Exception("Duplicado ...");
                // No se permiten duplicados
                else
                {
                    NuevoNodo = new ClaseNodo(); // Creación del NuevoNodo
                    NuevoNodo.ObjetoConDatos = Nodo; // Asignación de los datos
                    NuevoNodo.SiguienteNodo = Top; // El NuevoNodo apunta a Top
                    Top = NuevoNodo; // El NuevoNodo se convierte en el primer nodo de la Pila-Lista
                }
            //}
            //else
            //{
            //    Console.WriteLine("La pila esta llena"); //Error al insertar dato, pila-Lista esta llena 
            //}
        }
        // Método público para eliminar el primer nodo  lógico de la Pila-Lista
        // Devuelve el nodo eliminado
        public Tipo Pop()
        {
            if (EstaVacia()) // Si está vacía ...
               return default;
            else
            {
                ClaseNodo NodoEliminado;
                //ClaseNodo Nodo;
                NodoEliminado = Top;
                Top = NodoEliminado.SiguienteNodo; // Ahora el  Top apunta al nodo apuntado por el Nodo eliminado
                //NodoEliminado = Nodo;
                NodoEliminado.SiguienteNodo = null;
                //Nodo = null; // Se elimina el Nodo
                return (NodoEliminado.ObjetoConDatos);
                // Devuelve los datos del nodo eliminado
            }
        }
        // Método público para eliminar todos los nodos de la Pila-Lista
        public void Vaciar()
        {
            if (EstaVacia()) // Si está vacía
                throw new Exception("Vacía ...");
            else
            {
                // Declaraciones locales de los nodos
                ClaseNodo NodoActual, NodoAnterior;
                // Inicia el recorrido de los nodos en el Top
                NodoActual = Top;
                NodoAnterior = NodoActual;
                // Mientras haya nodos en la Pila-Lista ...
                while (NodoActual != null)
                {
                    Top = NodoActual.SiguienteNodo; // Ahora el Top apunta al nodo apuntado por el NodoActual
                    NodoAnterior = NodoActual; // Guarda el NodoAnterior
                    NodoActual = NodoActual.SiguienteNodo; // Cambia de NodoActual
                    NodoAnterior = null; // Elimina el NodoAnterior
                }
            }
        }
        // Iterador de la Pila-Lista
        public IEnumerator<Tipo> GetEnumerator()
        {
            if (EstaVacia()) // Si está vacía ...
                yield break;
            // Declaración local del NodoActual
            ClaseNodo NodoActual = new ClaseNodo();
            // Inicia el recorrido de la Pila-Lista en el Top
            NodoActual = Top;
            while (NodoActual != null) // Mientras haya nodos ...
            {
                yield return
                (Tipo)NodoActual.ObjetoConDatos; // Devuelve el NodoActual
                NodoActual = NodoActual.SiguienteNodo;
                // Cambia de NodoActual
            }
        }
    }
}
