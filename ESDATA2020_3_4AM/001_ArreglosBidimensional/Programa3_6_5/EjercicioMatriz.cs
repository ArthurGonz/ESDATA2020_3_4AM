using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ArreglosBidimensional.Programa3_6_5
{
    class EjercicioMatriz
    {
        static void Main()
        {
            ClaseMatriz Matriz;
            Matriz = new ClaseMatriz(10,10);

            Matriz[0, 0] = 5;
            Matriz[0, 1] = 4;
            Matriz[0, 2] = 3;
            Matriz[0, 3] = 2;
            Matriz[0, 4] = 1;
            Matriz[0, 5] = 0;
            Console.WriteLine(Matriz.Mostrar());
            

            int[,] m = new int[10, 10];
            m[0, 0] = 5;

            Console.ReadLine();
        }
    }
}
