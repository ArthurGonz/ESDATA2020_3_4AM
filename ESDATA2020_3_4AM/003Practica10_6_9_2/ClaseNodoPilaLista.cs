using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Practica10_6_9_2
{
    class ClaseDatosNodoPilaLista : IComparable<ClaseDatosNodoPilaLista>, IEquatable<ClaseDatosNodoPilaLista>
    {
        private int dato; // Dato del nodo de la Pila-Desordenada-Lista
                          // Propiedad pública para controlar el dato de cadanodo de la Pila-Desordenada-Lista
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        // Método para comparar dos nodos de la Pila-Ordenada-Lista
        public int CompareTo(ClaseDatosNodoPilaLista x)
        {
            if (this.Dato < x.Dato)
                return -1;
            if (this.Dato == x.Dato)
                return 0;
            if (this.Dato > x.Dato)
                return 1;

            return 0;
        }
        // Método para comparar dos nodos de la Pila-Desordenada-Lista y determinar si son iguales
        public bool Equals(ClaseDatosNodoPilaLista x)
        {
            if (this.Dato == x.Dato)
                return (true);
            else
                return (false);
        }
    }
}
