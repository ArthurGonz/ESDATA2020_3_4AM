using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePila Pila = new ClasePila(10);

            //Console.WriteLine(Pila.Mostrar());
            //Pila.Push(6);
            //Console.WriteLine(Pila.Mostrar());
            //Pila.Push(4);
            //Console.WriteLine(Pila.Mostrar());
            //Pila.Push(3);
            //Console.WriteLine(Pila.Mostrar() );
            //Pila.Push(1);

            Pila.Push(7);
            Pila.Push(5);
            Pila.Push(3);
            Pila.Push(1);
            Console.WriteLine(Pila.Mostrar());

            Pila.Pop();
            Console.WriteLine(Pila.Mostrar());
            Console.ReadLine();

        }
    }
}
