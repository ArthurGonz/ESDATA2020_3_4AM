using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003eListasDoblesEjercicioFerrocarril
{
    class ClaseNodoListaDoble :
 IComparable<ClaseNodoListaDoble>,
 IEquatable<ClaseNodoListaDoble>
    {
        private string matricula; // Datos de los vagones
        private string propietario;
        private string tipo;
        private string archivoimagen;
        // Propiedad pública para controlar la matrícula
        public string Matricula
        {
            get { return (matricula); }
            set { matricula = value; }
        }
        // Propiedad pública para controlar el propietario
        public string Propietario
        {
            get { return (propietario); }
            set { propietario = value; }
        }
        // Propiedad pública para controlar el tipo de vagón
        public string Tipo
        {
            get { return (tipo); }
            set { tipo = value; }
        }
        // Propiedad pública para controlar el nombre del archivo
        // con la imagen del vagón
        public string ArchivoImagen
        {
            get { return (archivoimagen); }
            set { archivoimagen = value; }
        }
        // Método para comparar vagones
        public int CompareTo(ClaseNodoListaDoble x)
        {
            return (this.Matricula.CompareTo(x.Matricula));
        }
        // Implementación del método Equals de la interfaz
        // IEquatable para comparar nodos (vagones) por medio
        // de su Matrícula
        public bool Equals(ClaseNodoListaDoble x)
        {
            if (this.Matricula == x.Matricula) // Si las  matrículas son iguales...
                return (true);
            else
                return (false);
        }
    }
}
