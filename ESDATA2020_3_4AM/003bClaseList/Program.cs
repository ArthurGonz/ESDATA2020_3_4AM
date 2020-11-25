using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003bClaseList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arreglo = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arreglo[i]);
            //}
            //List<int> miListaInt = new List<int>();
            //miListaInt.Add(5);
            //mostrar(miListaInt);
            //miListaInt.Add(2);
            //mostrar(miListaInt);
            //miListaInt.Add(6);
            //mostrar(miListaInt);
            //miListaInt.Add(5);
            //mostrar(miListaInt);

            //Console.WriteLine("Ordenando la lista");
            //miListaInt.Sort();
            //mostrar(miListaInt);

            //Console.WriteLine("Ordenando la lista descendente");
            //miListaInt.Sort();
            //miListaInt.Reverse();
            //mostrar(miListaInt);

            //Console.WriteLine("Eliminando el primer 5");
            //miListaInt.Remove(5);
            //mostrar(miListaInt);
            //Console.WriteLine("Eliminamos el valode de la primera posicion");
            //miListaInt.RemoveAt(1);
            //mostrar(miListaInt);
            //Console.WriteLine("Eliminamos el valode de la primera posicion");
            //miListaInt.RemoveAt(1);
            //mostrar(miListaInt);

            List<Persona> miListaPersona = new List<Persona>();
            Persona Persona = new Persona();
            Persona.nombre = "Patito7";
            Persona.Apellido = "Feo7";
            Persona.Edad = 20;
            miListaPersona.Add(Persona);
            mostrarListaObjeto(miListaPersona);

            Persona = new Persona();
            Persona.nombre = "Patito4";
            Persona.Apellido = "Feo4";
            Persona.Edad = 20;
            miListaPersona.Add(Persona);
            mostrarListaObjeto(miListaPersona);

            Persona = new Persona();
            Persona.nombre = "Patito1";
            Persona.Apellido = "Feo1";
            Persona.Edad = 20;
            miListaPersona.Add(Persona);
            mostrarListaObjeto(miListaPersona);
            
            
            Console.WriteLine("Eliminar elementos");
            Persona = new Persona();
            Persona.nombre = "Patito4";
            Persona.Apellido = "Feo4";
            Persona.Edad = 20;
            miListaPersona.Remove(Persona);

            //miListaPersona.Sort();
            mostrarListaObjeto(miListaPersona);


            Console.ReadLine();
        }
        static void mostrarListaObjeto(List<Persona> miListaPersona)
        {
            for (int i = 0; i < miListaPersona.Count; i++)
            {
                Console.Write("[Nombre: " + miListaPersona[i].nombre);
                Console.Write(", Apellido: " + miListaPersona[i].Apellido);
                Console.Write(", Edad: " + miListaPersona[i].Edad);
                Console.WriteLine("] ---->>>");
            }
            Console.WriteLine();
        }

        static void mostrar(List<int> miListaInt )
        {

            for (int i = 0; i < miListaInt.Count; i++)
            {
                Console.Write("-->"+miListaInt[i]);
            }
            Console.WriteLine();
        }
    }
}
