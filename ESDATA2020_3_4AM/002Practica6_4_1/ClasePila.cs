using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Practica6_4_1
{
    class ClasePila
    {
        private readonly int Max; // Tamaño de la pila
        private int Top; // Cantidad de datos almacenados
        private int LongitudMax; //Longitud maxima numerica del arreglo
        private int[] Arreglo; // Arreglo de la pila
                               // Constructor que recibe el Tamaño de la pila
        public ClasePila(int Tamaño)
        {
            Top = 0; // Inicializa la pila vacía
            Max = Tamaño; // Define el tamaño de la pila
            LongitudMax = 0;
            Arreglo = new int[Tamaño]; // Crea el arreglo
        }
        // Método para determinar si la pila está llena
        private bool EstaLlena()
        {
            if (Top == Max)
                return (true);
            else
                return (false);
        }
        // Método para determinar si la pila está vacía
        private bool EstaVacia()
        {
            if (Top == 0)
                return (true);
            else
                return (false);
        }
        // Método para insertar un dato en la pila
        public bool Push(int dato)
        {
            if (!EstaLlena()) // Si no está llena ...
            {
                Arreglo[Top] = dato; // Inserta el dato
                if (LongitudMax < dato.ToString().Length)
                    LongitudMax = dato.ToString().Length;
                Top++; // Incrementa la cantidad de datos almacenados
                return true; // Dato insertado con éxito
            }
            else
                return false; // No se insertó el dato
        }
        // Método para eliminar el último dato insertado en la pila
        public bool Pop()
        {
            if (!EstaVacia()) // Si no está vacía ...
            {
                Top--;
                Arreglo[Top] = 0;
                 // Disminuye la cantidad de datos almacenados
                return (true); // Dato eliminado con éxito
            }
            else
                return (false); // No se eliminó el dato
        }
        // Método para mostrar en pantalla los datos de la pila
        public string Mostrar()
        {
            string Resultado = ""; // Inicializa el resultado
            if (!EstaVacia()) // Si no está vacía ...
            {
                // Ciclo para recorrer el arreglo de la pila
                for (int i = Max-1; i >= 0 ; i--)
                {
                    Resultado += "\n" + i + " | ";
                    if (i < Top)
                    {
                        int espacio = LongitudMax - Arreglo[i].ToString().Length;
                        for (int j = 0; j < espacio; j++)
                        {
                                Resultado += " ";
                        }
                        Resultado = Resultado + Arreglo[i];
                    }
                    else
                    {
                        for (int j = 0; j < LongitudMax; j++)
                            Resultado += " ";
                    }
                    Resultado += " |";
                    if (i == Top)
                        Resultado += " T";
                }
            }
            else
                Resultado = "\n\nPila vacía !!!";
            return Resultado; // Devolver el Resultado
        }
        // Método para eliminar todos los datos de la pila
        public void Vaciar()
        {
            // Se inicializa a cero la cantidad de elementos almacenados en la pila
            Top = 0;
        }
    }
}
