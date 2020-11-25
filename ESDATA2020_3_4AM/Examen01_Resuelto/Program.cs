using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01_Resuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato = 0, datoE=0;
            ClaseArregloDesordenado_1 arreglo1 = new ClaseArregloDesordenado_1(3);
            ClaseArregloDesordenado_1 arreglo2 = new ClaseArregloDesordenado_1(3);
            ClaseArregloDesordenado_1 arreglo3 = new ClaseArregloDesordenado_1(3);
            
            Console.WriteLine("Arreglo 1: " + arreglo1.Mostrar());
            Console.WriteLine("Arreglo 2: " + arreglo2.Mostrar());
            Console.WriteLine("Arreglo 3: " + arreglo3.Mostrar());

            for (int i = 0; i <= 9; i++)
            {
                dato = GetData("Dato a insertar:", "Error al ingresar dato... Solo se aceptan numeros");
                bool inserto = arreglo1.Insertar(dato);
                if (!inserto)
                {
                    datoE = arreglo1.Eliminar();
                    arreglo1.Insertar(dato);
                    inserto = arreglo2.Insertar(datoE);

                    if (!inserto)
                    {
                        dato = arreglo2.Eliminar();
                        arreglo2.Insertar(datoE);
                        inserto = arreglo3.Insertar(dato);
                        if (!inserto)
                        {
                            datoE = arreglo3.Eliminar();
                            arreglo3.Insertar(dato);
                        }
                    }
                }
                Console.WriteLine("Arreglo 1: " + arreglo1.Mostrar());
                Console.WriteLine("Arreglo 2: " + arreglo2.Mostrar());
                Console.WriteLine("Arreglo 3: " + arreglo3.Mostrar());
            }
            //arreglo1.Insertar(5);
            //arreglo1.Insertar(6);
            //arreglo1.Insertar(7);
            //arreglo1.Eliminar();
            //bool inserto = arreglo1.Insertar(8);
            //if (!inserto)
            //{
            //    Console.WriteLine("No inserto");
            //}
            //Console.WriteLine(arreglo1.Mostrar());

            Console.ReadLine();
        }

        static int GetData(string mensaje, string msgError)
        {
            int dato;
            bool val = false;
            do
            {
                Console.WriteLine(mensaje);
                val = int.TryParse(Console.ReadLine(), out dato);
                if (!val)
                    Console.WriteLine(msgError);
            } while (!val);
            return dato;
        }
    }
}
