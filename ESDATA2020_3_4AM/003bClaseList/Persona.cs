using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003bClaseList
{
    class Persona: IComparable<Persona>, IEquality<Persona>
    {

        public string nombre { get; set; }

        public string Apellido{ get; set; }

        public int Edad { get; set; }

        public int CompareTo(Persona other)
        {
            return this.nombre.CompareTo(other.nombre);
        }

        public bool Equals(Persona other)
        {
            if (this.nombre == other.nombre)
                return true;
            else
                return false;
        }
    }
}
