using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Program
    {
        static ClaseArregloDesordenado Arreglo1 = new ClaseArregloDesordenado(3);
        static ClaseArregloDesordenado Arreglo2 = new ClaseArregloDesordenado(3);
        static ClaseArregloDesordenado Arreglo3 = new ClaseArregloDesordenado(3);
        static int dato, pasar,pasar2;
        static bool verificar;
        static void Main(string[] args)
        {
          
            imprimir();
            #region 1
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine("Dato a insertar: ");
                    verificar = int.TryParse(Console.ReadLine(), out dato);
                    if (!verificar)
                        Console.WriteLine("Intente nuevamente");
                } while (!verificar);
                if (i < 1)
                    pasar = Arreglo1.Insertar(dato);
                else
                    Arreglo1.Insertar(dato);
                imprimir();
            }
            #endregion

            #region 2
            for (int i = 0; i < 3; i++)
            {
                Arreglo1.Eliminar(pasar);
                Arreglo2.Insertar(pasar);
                do
                {
                    Console.WriteLine("Dato a insertar: ");
                    verificar = int.TryParse(Console.ReadLine(), out dato);
                    if (!verificar)
                        Console.WriteLine("Intente nuevamente");
                } while (!verificar);
                pasar2= Arreglo1.Insertar(dato);
                imprimir();
            }
            for (int i = 0; i < 3; i++)
            {
                Arreglo1.Eliminar(pasar);
                Arreglo2.Eliminar(pasar);
                do
                {
                    Console.WriteLine("Dato a insertar: ");
                    verificar = int.TryParse(Console.ReadLine(), out dato);
                    if (!verificar)
                        Console.WriteLine("Intente nuevamente");
                } while (!verificar);
                Arreglo1.Insertar(dato);
                imprimir();
            }
            #endregion

            Console.ReadLine();
        }

        static void imprimir()
        {
            Console.WriteLine(Arreglo1.Mostrar(1));
            Console.WriteLine(Arreglo2.Mostrar(2));
            Console.WriteLine(Arreglo3.Mostrar(3));
        }

    }
}
