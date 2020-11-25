using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003a_ColaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseColaLista<ClaseNodoColaLista> colaLista = new ClaseColaLista<ClaseNodoColaLista>();

            ClaseNodoColaLista nodo;

            Encolar(colaLista, 6);
            Mostrar(colaLista);

            Encolar(colaLista,7);
            Mostrar(colaLista);

            colaLista.Desencolar();
            Console.WriteLine("Desencolar");
            Mostrar(colaLista);
            Console.ReadLine();
        }

        public static void Encolar(ClaseColaLista<ClaseNodoColaLista> colaLista, int dato)
        {
           ClaseNodoColaLista nodo = new ClaseNodoColaLista();
            nodo.Dato = dato;
            colaLista.Encolar(nodo);
        }

        public static void Mostrar(ClaseColaLista<ClaseNodoColaLista> colaLista)
        {
            //Console.Write("<-- ");
            foreach (var item in colaLista)
            {
                Console.Write(item.Dato + "--> ");
            }
            Console.WriteLine("Null");
        }
    }
}
