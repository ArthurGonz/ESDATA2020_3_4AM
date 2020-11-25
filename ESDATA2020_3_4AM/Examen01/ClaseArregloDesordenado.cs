using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class ClaseArregloDesordenado
    {
        private readonly int max;
        private int top;
        private int[] arreglo;


        public ClaseArregloDesordenado(int m)
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

        public int Insertar(int dato)
        {
            for (int y = top; y > 0; y--)
            {
                arreglo[y] = arreglo[y - 1];
            }
            arreglo[0] = dato;
            top++;
            return dato;
        }

        public bool Eliminar(int dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < top - 1; i++)
                    if (arreglo[i] == dato)
                    {
                        for (int y = i; y <= top - 2; y++)
                            arreglo[y] = arreglo[y + 1];
                        top = top - 1;
                        return true; //Se elimino el dato
                    }    //Fin de Condicion
                return false;
            }
            return false;
        }

        public String Mostrar(int num)
        {
            string resultado = "arreglo"+num +":{";    
            for (int i = 0; i < top; i++)
            {
                if (arreglo[i].Equals(0))
                    resultado += " ";
                else
                    resultado += arreglo[i];

                if (i < 3)
                    resultado += ",";
            }
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
