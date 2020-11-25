using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Practica5_3_5_3
{
    class ClaseDatos
    {
        private UInt16 numeromatricula;
        private string nombre;
        private double calificacion;

        public UInt16 NumeroMatricula
        {
            get{
                return (numeromatricula);
            }
            set{
                numeromatricula = value;
            }
        }

        public string Nombre
        {
            get{
                return (nombre);
            }
            set{
                nombre = value;
            }
        }

        public double Calificacion
        {
            get{
                return (calificacion);
            }
            set{
                calificacion = value;
            }
        }
    }
}
