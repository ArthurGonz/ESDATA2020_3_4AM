using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003c_PilaDesordenadaLista
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
        // Método para comparar dos nodos de la Pila-Desordenada-Lista
        public int CompareTo(ClaseDatosNodoPilaLista x)
        {
            return
            (this.Dato.ToString().CompareTo(x.Dato.ToString()));
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
