using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Practica4_3_5_2
{
    class ClaseArregloOrdenado
    {
        private readonly int Max; // Tamaño del arreglo
        private int Top;
        private int[] Arreglo; // Declaración del arreglo
        public ClaseArregloOrdenado(int m) //Constructor
        {
            Top = 0;
            Max = m;
            Arreglo = new int[Max]; // Creación del arreglo
        }

        public bool EstaLleno() // Método para detectar si el arreglo está lleno
        {
            if (Top == Max)
                return (true);
            else
                return (false);
        }

        public bool EstaVacio() // Método para detectar si el arreglo está vacío
        {
            if (Top == 0)
                return (true);
            else
                return (false);
        }

        public bool Insertar(int dato)
        {
            int i = 0;
            if (!EstaLleno()) // Si no está lleno ...
            {
                for (i = 0; i <= Top - 1; i++)
                {
                    if (Arreglo[i] == dato) // No permite duplicados
                        return (false);
                    if (dato < Arreglo[i])
                    {
                        for (int y = Top; y >= i + 1; y--)// Desplazamiento de valores a la derecha
                            Arreglo[y] = Arreglo[y - 1];
                        break;
                    }
                }
                Arreglo[i] = dato; // Insercion del nuevo dato
                Top++; // Incrementa la cantidad de celdasocupadas
                return (true); // Dato insertado con exito
            }
            else
                return (false); // Arreglo lleno
        }

        public bool Eliminar(int dato)
        {
            int i = 0;
            if (!EstaVacio()) // Si no está vacío ...
            {
                for (i = 0; i <= Top - 1; i++)
                {
                    if (dato < Arreglo[i]) // Interrumpe la busqueda(no existe el dato)
                        return (false);
                    if (Arreglo[i] == dato) // Dato localizado
                    {
                        for (int y = i; y <= Top - 2; y++)
                            Arreglo[y] = Arreglo[y + 1];
                        // Desplazamiento a la izquierda
                        Top--;
                        return (true); // Dato eliminado con exito
                    }
                }
                return (false); // No se encuentra el dato
            }
            else
                return (false); // Arreglo vacio
        }

        public string Mostrar() // Método para desplegar los datos en pantalla
        {
            string Resultado = "\n\nTop=" + Top + "\n";
            if (!EstaVacio()) // Si no está vacío ...
            {
                for (int i = 0; i <= Top - 1; i++)
                    Resultado = Resultado + "\n[" + i + "] -> " + Arreglo[i];
            }
            else
                Resultado = Resultado + "\nArreglo vacío!!!";
            return (Resultado);
        }

        public bool Vaciar()
        {
            if (!EstaVacio())
            {
                Top = 0;
                return (true);
            }
            else
                return (false);
        }

        public int ObtenerMayor()
        {
            return (Arreglo[Top - 1]);
        }
    }
}
