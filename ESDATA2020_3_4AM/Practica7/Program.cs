using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePila Pila = new ClasePila(5);
            Pila.Push(10, false); 
            Pila.Push(2, false);     
            Pila.Push(3, false);
            Console.WriteLine(mostrar(Pila, 5));
            Pila.Push(4, false);
            Console.WriteLine(mostrar(Pila, 5));
            Pila.Push(5,false);
            Console.WriteLine(mostrar(Pila, 5));
            Console.ReadLine();
        }


        static string mostrar(ClasePila pila,int max)
        {
            int top = 0, tamaño_max = 0 ;
            int[] arreglo = new int[max];
            string mostrar = "\n";
            char space = ' ';

            for (int i = 0; i < max; i++)
            {
                arreglo[i] = pila.Pop(false);
                if (arreglo[i] == int.MinValue)
                {
                    top = i;
                    break;
                }
                else
                    top = max;
            }
            
            Array.Reverse(arreglo,0,top);

            for (int i = 0; i < top; i++)
                pila.Push(arreglo[i], false);

            tamaño_max = MaxLongitud(max, arreglo);
            for (int i = max - 1; i >= 0; i--)
            {
                mostrar += new string(space, (max - 1).ToString().Length - i.ToString().Length) + i + " | ";
                if (i < top)
                {
                    int longitud = arreglo[i].ToString().Length;
                    mostrar += new string(space, tamaño_max - longitud);
                    mostrar += arreglo[i];

                }
                else
                {
                    mostrar += new string(space, tamaño_max);
                }

                mostrar += " |";

                if (i == top)
                {
                    mostrar += " T";
                }
                mostrar += "\n";
            }

            return mostrar;
        }

        static void vaciar(ClasePila pila)
        {
            int verificar = 0;
            do
            {
                verificar = pila.Pop(false);
            } while (verificar != int.MinValue);
            Console.WriteLine("La Pila se ha vaciado con exito");
        }

        static int MaxLongitud(int max, int[] arreglo)
        {
            int longMax = 0;
            for (int i = 0; i < max; i++)
            {
                if (arreglo[i] != int.MinValue)
                {
                    if (arreglo[i].ToString().Length > longMax)
                    {
                        longMax = arreglo[i].ToString().Length;
                    }
                }
                else
                {
                    if (0.ToString().Length > longMax)
                    {
                        longMax = 0.ToString().Length;
                    }    
                }        
            }
            return longMax;
        }


    }
}

