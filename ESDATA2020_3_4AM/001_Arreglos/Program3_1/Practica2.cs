using System;

namespace _001_Arreglos.Program3_1
{
    class Practica2
    {
        static void Main()
        {
            ClaseArregloDesordenado OpcionesArreglo;
            int InicioMenu = 0, FinMenu = 6, opcion = 0,longitud=0,dato = 0, datoEliminar=0;
            bool ejecutado;
            String Menu = "1: Insertar " +
                "\n2: Eliminar" +
                "\n3: Mostrar" +
                "\n4: Numero Mayor" +
                "\n5: Ordenar" +
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
            OpcionesArreglo = new ClaseArregloDesordenado(longitud);

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Longitud del arreglo: {0}\n", longitud );
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
                        ejecutado = OpcionesArreglo.EstaLleno();
                        if (ejecutado) { 
                            Console.WriteLine("El arreglo esta lleno");
                        }
                        else
                        {           
                            try
                            {
                                Console.Write("Ingrese valor a insertar: ");
                                dato = int.Parse(Console.ReadLine());
                                ejecutado = OpcionesArreglo.Insertar(dato);
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
                        
                        ejecutado = OpcionesArreglo.EstaVacio();
                        if (!ejecutado)
                        {
                            try
                            {
                                Console.Write("Ingrese valor a Eliminar: ");
                                datoEliminar = int.Parse(Console.ReadLine());
                                ejecutado = OpcionesArreglo.Eliminar(datoEliminar);
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
                        Console.WriteLine(OpcionesArreglo.Mostrar());
                        break;

                    case 4:
                        Console.WriteLine("El valor mas grande del arreglo es: {0}", OpcionesArreglo.ObtenerMayor());
                        break;

                    case 5:
                        Console.WriteLine("Ordenando arreglo...");
                        OpcionesArreglo.Ordenar();
                        Console.WriteLine(OpcionesArreglo.Mostrar());
                        
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
        }

    }
}
