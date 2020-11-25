using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003a_ColaLista
{
    class ClaseNodoColaLista : IComparable<ClaseNodoColaLista>,
 IEquatable<ClaseNodoColaLista>
    {
        // Dato del nodo de la Cola-Lista
        private int dato;
        // Propiedad pública para controlar el dato
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        // Método para comparar dos nodos de la Cola-Lista
        public int CompareTo(ClaseNodoColaLista x)
        {
            return
            (this.Dato.ToString().CompareTo(x.Dato.ToString()));
        }
        // Método para comparar dos nodos de la Cola-Lista  para determinar si son iguales
        public bool Equals(ClaseNodoColaLista x)
        {
            if (this.Dato == x.Dato)
                return (true);
            else
                return (false);
        }
    }
}
