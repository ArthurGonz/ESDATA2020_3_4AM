using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003e_ListasDobles
{
    class ClaseNodoListaDoble :
 IComparable<ClaseNodoListaDoble>,
 IEquatable<ClaseNodoListaDoble>
    {
        private int dato; // Dato del nodo
                          //Propiedad pública para controlar el dato del nodo
        public int Dato
        {
            get { return (dato); }
            set { dato = value; }
        }
        // Método para comparar dos nodos
        public int CompareTo(ClaseNodoListaDoble x)
        {
            return
            (this.Dato.ToString().CompareTo(x.Dato.ToString()));
        }
        // Método para comparar dos nodos y determinar si  son iguales
        public bool Equals(ClaseNodoListaDoble x)
        {
            if (this.Dato == x.Dato) // Si las matrículas son iguales ...
                return (true);
            else
                return (false);
        }
    }
}
