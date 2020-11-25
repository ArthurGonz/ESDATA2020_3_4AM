using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Practica9_6_7_6_2
{
    abstract class ClaseBaseAbstracta<Tipo>
    {
        private Tipo clave; // Declaración de la clave del objeto
                            // Propiedad protegida de la clave
        protected Tipo Clave
        {
            get { return clave; }
            set { clave = value; }
        }
    }
}
