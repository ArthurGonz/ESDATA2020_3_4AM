using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Practica9_6_7_6_2
{

    class ClaseDatosEstudiante<Tipo> : ClaseBaseAbstracta<Tipo>,IComparable<ClaseDatosEstudiante<Tipo>>,
    IEquatable<ClaseDatosEstudiante<Tipo>>
    {
        private string nombre; // Nombre del  estudiante
        private double promedio; // Promedio del estudiante
                                 // Propiedad pública para controlar la clave  del estudiante(número de matrícula)
        public Tipo NumeroMatricula
        {
            get { return base.Clave; }
            set { base.Clave = value; }
        }
        // Propiedad pública para controlar el Nombre del estudiante
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        // Propiedad pública para controlar el Promedio del estudiante
        public double Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
        // Método para comparar objetos de estudiantes  por medio de su número de matrícula
        // y determinar el criterio de ordenamiento
        public int CompareTo(ClaseDatosEstudiante<Tipo> x)
        {
            return(this.NumeroMatricula.ToString().CompareTo(x.NumeroMatricula.ToString()));
        }
        // Método para comparar objetos de estudiantes por medio de su número de matrícula
        // y determinar si son iguales
        public bool Equals(ClaseDatosEstudiante<Tipo> x)
        {
            if (this.NumeroMatricula.ToString() == x.NumeroMatricula.ToString())
                return (true);
            else
                return (false);
        }
    }
}

