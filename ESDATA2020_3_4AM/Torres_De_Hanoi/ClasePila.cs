using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_De_Hanoi
{
    class ClasePila
    {
        private readonly int Max; // Tamaño de la pila
        private int Top; // Cantidad de datos almacenados
        private int[] Discos; // Arreglo de la pila

        public ClasePila(int Tamaño)
        {
            Top = 0; // Inicializa la pila vacía
            Max = Tamaño; // Define el tamaño de la pila
            Discos = new int[Tamaño]; // Crea el arreglo
        }

        public bool EstaLlena()
        {
            if (Top == Max)
                return true;
            else
                return false;
        }

        public bool EstaVacia()
        {
            if (Top == 0)
                return true;
            else
                return false;
        }

        public bool Push(int dato)
        {
            if (!EstaLlena()) // Si no está llena ...
            {
                for (int i = Max - 1; i >= Top; i--)
                {
                    if (i == Max - 1)
                        Discos[i] = dato;
                    else
                    {
                        Discos[i] = dato;
                        Discos[i + 1] = int.MinValue;//solo de prueba
                    }
                }
                Discos[Top] = dato; // Inserta el dato
                Top++; // Incrementa la cantidad de   datos almacenados
                return true; // Dato insertado con   
            }
            else
                return (false); // No se insertó el dato
        }

        public int Pop()
        {
            if (!EstaVacia())
            {
                Top--;
                for (int i = Top; i < Max - 1; i++)
                {
                    Discos[i + 1] = Discos[i];
                    Discos[i] = int.MinValue;

                }
                int salida = Discos[Max - 1];
                Discos[Max - 1] = int.MinValue;
                return salida;
            }
            else
                return int.MinValue;
        }
    }
}
