using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002b_PilaClasica
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePila Pila = new ClasePila(3);
            Pila.Push(5,false);
            Console.WriteLine(mostrar(Pila));
            Pila.Push(2,false);
            Pila.Push(3,false);
            Pila.Push(4,false);
            int dato = Pila.Pop(false);
            Console.WriteLine(Pila.Mostrar()); 
            vaciar(Pila);
            Console.WriteLine(Pila.Mostrar());


            Console.ReadLine();
        }

        static string mostrar(ClasePila pila)
        {
            //ToDo
            return "";
        }

        static void vaciar(ClasePila pila)
        {
           //ToDo
        }
    }
}
