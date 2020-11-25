using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Practica10_6_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista> PilaOrdenadaLista =
            new ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista>();

            int InicioMenu = 0, FinMenu = 6, opcion = 0;

            String Menu = "1: Agregar Nodo " +
                "\n2: Borrar Nodo" +
                "\n3: Buscar Nodo" +
                "\n4: Mostrar Nodos" +
                "\n5: Vaciar" +
                "\n6: Finalizar" +
                "\nOpcion: ";
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(Menu);
                    int.TryParse(Console.ReadLine(), out opcion);

                    if (opcion < InicioMenu || opcion > FinMenu)
                    {
                        Console.WriteLine("Opcion invalida");
                        Console.ReadLine();
                    }
                } while (opcion < InicioMenu || opcion > FinMenu);

                switch (opcion)
                {

                    case 1:
                        AgregarNodo(PilaOrdenadaLista);
                        break;

                    case 2:
                        BorrarNodo(PilaOrdenadaLista);
                        break;

                    case 3:
                        BuscarNodo(PilaOrdenadaLista);
                        break;

                    case 4:
                        MostrarNodos(PilaOrdenadaLista);
                        break;

                    case 5:
                        VaciarNodo(PilaOrdenadaLista);
                        break;

                    case 6:
                        Console.WriteLine("\nFin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

                Console.ReadLine();
            } while (opcion != FinMenu);

            Console.ReadLine();
        }
        static void MostrarNodos(ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista> PilaOrdenadaLista)
        {
            Console.Write("Top-->");
            foreach (var item in PilaOrdenadaLista)
            {
                Console.Write(item.Dato + "-->");
            }
            Console.WriteLine("Null");
        }

        static void AgregarNodo(ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista> PilaOrdenadaLista)
        {
            ClaseDatosNodoPilaLista nodo;
            nodo = new ClaseDatosNodoPilaLista();
            Console.Write("Ingrese el Nodo a agregar: ");
            nodo.Dato = int.Parse(Console.ReadLine());
            PilaOrdenadaLista.Push(nodo);
        }

        static void BorrarNodo(ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista> PilaOrdenadaLista)
        {
            ClaseDatosNodoPilaLista nodo;
            nodo = PilaOrdenadaLista.Pop();
            Console.WriteLine("Se extrajo de la fila el " + nodo.Dato);
        }

        static void BuscarNodo(ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista> PilaOrdenadaLista)
        {
            ClaseDatosNodoPilaLista nodo;
            nodo = new ClaseDatosNodoPilaLista();
            Console.WriteLine("Ingrese el nodo a buscar: ");
            nodo.Dato = int.Parse(Console.ReadLine());
            nodo = PilaOrdenadaLista.Buscar(nodo);
        }

        static void VaciarNodo(ClasePilaOrdenadaLista<ClaseDatosNodoPilaLista> PilaOrdenadaLista)
        {
            PilaOrdenadaLista.Vaciar();
        }

    }
}
