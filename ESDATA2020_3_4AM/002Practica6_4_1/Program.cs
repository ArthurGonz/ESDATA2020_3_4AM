using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Practica6_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePila Pila = new ClasePila(5);

            
            Pila.Push(789);
            Pila.Push(4321);
            Pila.Push(21);
            Pila.Push(7);
            Pila.Pop();
            Console.WriteLine(Pila.Mostrar());

            Console.ReadLine();
        }
    }
}
