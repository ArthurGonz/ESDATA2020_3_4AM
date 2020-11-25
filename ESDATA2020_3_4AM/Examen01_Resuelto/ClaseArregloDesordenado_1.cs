using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01_Resuelto
{
    class ClaseArregloDesordenado_1
    {
        private readonly int max;
        private int top;
        private int[] arreglo;

        //Metodo Constructor
        public ClaseArregloDesordenado_1(int m)
        {
            max = m;
            top = 0;
            arreglo = new int[max];
        }

        public bool EstaLleno()
        {
            if (top == max)
                return true;
            return false;
        }

        public bool EstaVacio()
        {
            if (top == 0)
                return true;
            return false;
        }

        public bool Insertar(int dato)
        {
            if (!EstaLleno())
            {
                for (int i = top; i > 0; i--)
                {
                    arreglo[i] = arreglo[i - 1];
                }

                arreglo[0] = dato;
                top ++; //Top++;
                return true;
            }
            else
            {
                return false;
            }

        }
        public int Eliminar()
        {
            if (!EstaVacio())
            {
                top--;
                return arreglo[max - 1];
            }
            return int.MinValue; //Valor de error
        }

        public String Mostrar()
        {
            string resultado = "{";
            if (!EstaVacio())
                for (int i = 0; i < max; i++)
                {
                    if (i < top)
                        resultado += " " + arreglo[i];
                    else
                        resultado += " ";
                    if (i < max)
                        resultado += ",";
                }
            else
                return "{ , , }";
            return resultado + "}";
        }

        public Boolean Ordenar()
        {
            if (!EstaVacio())
            {
                for (int p = 0; p <= top - 2; p++)
                    for (int i = p + 1; i <= top - 1; i++)
                        if (arreglo[i] < arreglo[p])
                            swap(i, p);
                return true;
            }
            return false;
        }

        private void swap(int index1, int index2)
        {
            int temporal = arreglo[index2];
            arreglo[index2] = arreglo[index1];
            arreglo[index1] = temporal;
        }
        public int ObtenerMayor()
        {

            int Mayor = arreglo[0];
            for (int i = 0; i <= top - 1; i++)
                if (arreglo[i] > Mayor)
                    Mayor = arreglo[i];
            return Mayor;
        }
    }
}
