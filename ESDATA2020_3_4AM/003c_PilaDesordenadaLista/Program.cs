using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003c_PilaDesordenadaLista
{
        class Program
        {
            static void Main(string[] args)
            {

                ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> pilaDesordenadaLista =
                    new ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista>();

                ClaseDatosNodoPilaLista nodo;
                Console.WriteLine("Insertando Datos");
                nodo = new ClaseDatosNodoPilaLista();
                nodo.Dato = 5;
                pilaDesordenadaLista.Push(nodo);
                Mostrar(pilaDesordenadaLista);
                nodo = new ClaseDatosNodoPilaLista();
                nodo.Dato = 7;
                pilaDesordenadaLista.Push(nodo);
                Mostrar(pilaDesordenadaLista);

                nodo = new ClaseDatosNodoPilaLista();
                nodo.Dato = 9;
                pilaDesordenadaLista.Push(nodo);
                Mostrar(pilaDesordenadaLista);
                nodo = new ClaseDatosNodoPilaLista();
                nodo.Dato = 14;
                pilaDesordenadaLista.Push(nodo);

                Mostrar(pilaDesordenadaLista);

                try
                {
                    Console.WriteLine("Eliminando datos de la pila");
                    nodo = pilaDesordenadaLista.Pop();
                    Mostrar(pilaDesordenadaLista);
                    Console.WriteLine("Se extrajo de la pila el valor: " + nodo.Dato);

                    nodo = pilaDesordenadaLista.Pop();
                    Mostrar(pilaDesordenadaLista);
                    Console.WriteLine("Se extrajo de la pila el valor: " + nodo.Dato);

                    nodo = pilaDesordenadaLista.Pop();
                    Mostrar(pilaDesordenadaLista);
                    Console.WriteLine("Se extrajo de la pila el valor: " + nodo.Dato);

                    nodo = pilaDesordenadaLista.Pop();
                    Mostrar(pilaDesordenadaLista);
                    Console.WriteLine("Se extrajo de la pila el valor: " + nodo.Dato);

                    nodo = pilaDesordenadaLista.Pop();
                    Mostrar(pilaDesordenadaLista);
                    Console.WriteLine("Se extrajo de la pila el valor: " + nodo.Dato);

                    nodo = pilaDesordenadaLista.Pop();
                    Mostrar(pilaDesordenadaLista);
                    Console.WriteLine("Se extrajo de la pila el valor: " + nodo.Dato);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();
            }

            static void Mostrar(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> pilaDesordenadaLista)
            {
                Console.Write("Top-->");
                foreach (var item in pilaDesordenadaLista)
                {
                    Console.Write(item.Dato + "-->");
                }
                Console.WriteLine("null");
            }
        }
}
