using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Practica4_3_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseArregloOrdenado ArregloOrdenado;
            int InicioMenu = 0, FinMenu = 6, opcion = 0, longitud = 0, dato = 0, datoEliminar = 0;
            bool ejecutado;
            String Menu = "1: Insertar " +
                "\n2: Eliminar" +
                "\n3: Mostrar" +
                "\n4: Numero Mayor" +
                "\n5: Vaciar" +
                "\n6: Salir" +
                "\nOpcion: ";
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la longitud base del arreglo");
                int.TryParse(Console.ReadLine(), out longitud);
                if (longitud <= 0)
                {
                    Console.WriteLine("Opcion invalida Reintente nuevamente");
                    Console.ReadLine();
                }
            } while (longitud <= 0);
            ArregloOrdenado = new ClaseArregloOrdenado(longitud);

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Longitud del arreglo: {0}\n", longitud);
                    Console.Write(Menu);
                    int.TryParse(Console.ReadLine(), out opcion);

                    if (opcion < InicioMenu || opcion > FinMenu)
                    {
                        Console.WriteLine("Opcion invalida");
                        Console.ReadLine();
                    }
                } while (opcion < InicioMenu || opcion > FinMenu);

                Console.WriteLine("");
                switch (opcion)
                {

                    case 1:
                        ejecutado = ArregloOrdenado.EstaLleno();
                        if (ejecutado)
                        {
                            Console.WriteLine("El arreglo esta lleno");
                        }
                        else
                        {
                            try
                            {
                                Console.Write("Ingrese valor a insertar: ");
                                dato = int.Parse(Console.ReadLine());
                                ejecutado = ArregloOrdenado.Insertar(dato);
                                if (ejecutado)
                                    Console.WriteLine("Insertando: " + dato);
                                else
                                    Console.WriteLine("Error al insertar dato");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error al insertar dato");
                            }
                        }

                        break;

                    case 2:

                        ejecutado = ArregloOrdenado.EstaVacio();
                        if (!ejecutado)
                        {
                            try
                            {
                                Console.Write("Ingrese valor a Eliminar: ");
                                datoEliminar = int.Parse(Console.ReadLine());
                                ejecutado = ArregloOrdenado.Eliminar(datoEliminar);
                                if (ejecutado)
                                    Console.WriteLine("Eliminando: " + datoEliminar);
                                else
                                    Console.WriteLine("Error al eliminar dato");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error al eliminar dato");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El arreglo esta vacio");
                        }
                        break;

                    case 3:
                        Console.WriteLine(ArregloOrdenado.Mostrar());
                        break;

                    case 4:
                        Console.WriteLine("El valor mas grande del arreglo es: {0}", ArregloOrdenado.ObtenerMayor());
                        break;

                    case 5:
                        ArregloOrdenado.Vaciar();
                        Console.WriteLine("El arreglo fue vaciado");
                        break;

                    case 6:
                        Console.WriteLine("Fin del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

                Console.ReadLine();
            } while (opcion != FinMenu);

        Console.ReadLine();
        }
    }
}
