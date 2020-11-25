using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002c_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseCola Cola = new ClaseCola(5);

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("insertando {0}", i);
                Cola.Encolar(i);
                Console.Write(Cola.Mostrar());

            }
            //Console.WriteLine("Insertando 5");
            //Cola.Insertar(5);
            //Console.WriteLine("Insertando 7");
            //Cola.Insertar(7);
            //Console.WriteLine(Cola.Mostrar());

            Console.WriteLine("\nEliminar dato de la cola");
           int dato = Cola.Desencolar();
            Console.WriteLine(Cola.Mostrar());
            Console.WriteLine("El dato eliminado de la cola es: {0}", dato);
            Console.ReadLine();
        }
    }
}
