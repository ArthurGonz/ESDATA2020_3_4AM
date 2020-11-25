using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003a_ListasSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseListaSimpleOrdenada<ClaseDatosNodoListaSimple> 
                ListaSimple = new
            ClaseListaSimpleOrdenada<ClaseDatosNodoListaSimple>();
            ClaseDatosNodoListaSimple nodo; 

            nodo = new ClaseDatosNodoListaSimple(); //Pido memoria
            Console.WriteLine("Insertando un 6");
            nodo.Dato = 6;
            ListaSimple.Insertar(nodo);
            nodo = new ClaseDatosNodoListaSimple(); //Pido memoria
            Console.WriteLine("Insertando un 8");
            nodo.Dato = 8;
            ListaSimple.Insertar(nodo);

            nodo = new ClaseDatosNodoListaSimple(); //Pido memoria
            Console.WriteLine("Insertando un 3");
            nodo.Dato = 3;
            ListaSimple.Insertar(nodo);

            nodo = new ClaseDatosNodoListaSimple();
            Console.WriteLine("Insertando un 5");
            nodo.Dato = 5;
            ListaSimple.Insertar(nodo);
            Mostrar(ListaSimple);

            nodo = new ClaseDatosNodoListaSimple();
            nodo.Dato = 6;
            ListaSimple.Eliminar(nodo);
            Mostrar(ListaSimple);

            nodo = new ClaseDatosNodoListaSimple(); //Pido memoria
            Console.WriteLine("Insertando un 12");
            nodo.Dato = 12;
            ListaSimple.Insertar(nodo);
            Mostrar(ListaSimple);

            nodo = new ClaseDatosNodoListaSimple(); //Pido memoria
            Console.WriteLine("Insertando un 12");
            nodo.Dato = 15;
            ListaSimple.Insertar(nodo);
            Mostrar(ListaSimple);

            Console.ReadLine();
            
        }

        static void Mostrar(ClaseListaSimpleOrdenada<ClaseDatosNodoListaSimple> ListaSimple)
        {
            Console.Write("");
            Console.Write("NI-->");
            foreach (var nodoListaSimple in ListaSimple)
            {
                Console.Write(nodoListaSimple.Dato);
                Console.Write("-->");
            }
            Console.WriteLine("Null");
        }
    }
}
