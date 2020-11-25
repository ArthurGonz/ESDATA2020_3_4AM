using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003a_ListasSimples
{
    class ClaseDatosNodoListaSimple :
    IComparable<ClaseDatosNodoListaSimple>,
    IEquatable<ClaseDatosNodoListaSimple>
    {
        private int dato; // Dato del nodo
                          //Propiedad pública para acceder al dato
        public int Dato
        {
            get { return (dato); }
            set { dato = value; }
        }
        // Método para comparar dos nodos y determinar  el criterio de ordenamiento
        // (Criterio de ordenamiento por Dato)
        public int CompareTo(ClaseDatosNodoListaSimple x)
        {
            if (this.Dato<x.Dato)
                return -1;
            if (this.Dato == x.Dato)
                return 0;
            if (this.Dato > x.Dato)
                return 1;
         
            return 0;
        }
        // Método para comparar dos nodos y determinar si son iguales
        // (Criterio de comparación por Dato)
        public bool Equals(ClaseDatosNodoListaSimple x)
        {
            if (this.Dato == x.Dato)
                return (true);
            else
                return (false);
        }
    }
}
