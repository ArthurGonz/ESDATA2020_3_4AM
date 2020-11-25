using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Practica9_6_7_6_2
{
    class ClaseDatosLibro<Tipo> : ClaseBaseAbstracta<Tipo>, IComparable<ClaseDatosLibro<Tipo>>,
    IEquatable<ClaseDatosLibro<Tipo>>
    {
        private string titulo; // Título del libro
        private string autor; // Autor
                              // Propiedad pública para controlar la clave del libro(ISBN)
        public Tipo ISBN
        {
            get { return base.Clave; }
            set { base.Clave = value; }
        }
        // Propiedad pública para controlar el título  del libro
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        // Propiedad pública para controlar el Autor del libro
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        // Método para comparar objetos de libros por  medio de su ISBN
        // y determinar el criterio de ordenamiento
        public int CompareTo(ClaseDatosLibro<Tipo> x)
        {
            return (this.ISBN.ToString().CompareTo(x.ISBN.ToString()));
        }
        // Método para comparar objetos de libros por medio de su ISBN
        // y determinar si son iguales
        public bool Equals(ClaseDatosLibro<Tipo> x)
        {
            if (this.ISBN.ToString() == x.ISBN.ToString())
                return (true);
            else
                return (false);
        }
    }
}
