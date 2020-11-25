using System;

namespace _001_Arreglos.Programa3_1
{
    class Programa3_1
    {
        static void Main()
        {
            ClaseArregloDesordenado arregloDesordenado; //Declarando el identificador
            arregloDesordenado = new ClaseArregloDesordenado(5); //creando el objeto
            //Console.WriteLine(arregloDesordenado.Mostrar()+"...");
            //arregloDesordenado.Insertar(5);
           // Console.WriteLine(arregloDesordenado.Mostrar() + "...");

            bool ejecutado = false;
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("\ninsertando:" + (i + 1));
                ejecutado = arregloDesordenado.Insertar(i+1);
                if (ejecutado)
                    Console.WriteLine(arregloDesordenado.Mostrar());
                else
                    Console.WriteLine("Error al insertar dato");
            }

            Console.WriteLine("insertado = " + 2);
            arregloDesordenado.Insertar(2);

            Console.WriteLine("\nEliminando valor 3 del arreglo");
            ejecutado = arregloDesordenado.Eliminar(3);
            if (ejecutado)
                Console.WriteLine(arregloDesordenado.Mostrar());
            else
                Console.WriteLine("Error al eliminar el dato");
            

            Console.WriteLine("\nEliminando valor 8 del arreglo");
            ejecutado = arregloDesordenado.Eliminar(8);
            if (ejecutado)
                Console.WriteLine(arregloDesordenado.Mostrar());           
            else
                Console.WriteLine("Error al eliminar el dato");

            Console.WriteLine("\nEl dato mayor registrado en el arreglo es:" + 
            arregloDesordenado.ObtenerMayor());

            Console.WriteLine("\nOrdenando arreglo");
            arregloDesordenado.Ordenar();
            Console.WriteLine(arregloDesordenado.Mostrar());

            Console.ReadLine();
        }

    }
}
