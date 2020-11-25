using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arreglos
{
    class InicializarArregloMultidimensional
    {
        static void Main()
        {
            Console.WriteLine("Muti");

            //int[_] ArregloUnidimensional;
            int[] ArregloUnidimensional;

            //int[_,_]ArregloBidimensional;
            int[,] ArregloBidimensional;

            //int[_,_,_] ArregloTridimensional;
            int[,,] ArregloTridimensional;

            int[,] Bidimensional1 = new int[5,5];
            int[,] Bidimensional2 = new int[5, 5] { 
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15},
                {16,17,18,19,20 },
                {21,22,23,24,25 } 
            };
            int renglon = 5;
            int columnas = 5;

            for( int i = 0; i < renglon; i++ )
            {
                for( int j = 0; j < columnas; j++ )
                {
                    Console.WriteLine("[{0},{1}]: {2}",i,j,Bidimensional2[i,j]);
                }
            }

        }
    }
}
