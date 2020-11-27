using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003eListasDobles
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble =
                new ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble>();

            #region Insertar
            Console.BackgroundColor = ConsoleColor.DarkGray;
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Proceso de inserción de datos");
            //Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Insertar(listaDoble, 5);
            MostrarDesdeInicio(listaDoble);

            Insertar(listaDoble, 7);
            MostrarDesdeInicio(listaDoble);


            Insertar(listaDoble, 6);
            MostrarDesdeInicio(listaDoble);


            Insertar(listaDoble, 3);
            MostrarDesdeInicio(listaDoble);
            MostrarDesdeFinal(listaDoble);

            Insertar(listaDoble, 4);
            MostrarDesdeInicio(listaDoble);
            #endregion
            //NI/Null<-->3<-->4<-->5<-->6<-->7<-->NF/Null
            Modificar(listaDoble, 4, 5);
            MostrarDesdeInicio(listaDoble);
            #region Eliminar
            //Console.BackgroundColor = ConsoleColor.DarkGray;
            //Console.WriteLine("Proceso de eliminación de datos");
            //Console.BackgroundColor = ConsoleColor.Black;
            //Eliminar(listaDoble, 6);
            //MostrarDesdeInicio(listaDoble);

            //Eliminar(listaDoble, 5);
            //MostrarDesdeInicio(listaDoble);


            #endregion

            Console.ReadLine();
        }

        static void Modificar(
            ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble, int dato, int newDato)
        {
            Console.WriteLine("Proceso de modificación de nodo");

            ClaseDatosNodoListaDoble nodo = new ClaseDatosNodoListaDoble();
            nodo.Dato = dato;
            ClaseDatosNodoListaDoble nodoEsta = listaDoble.Buscar(nodo);
            if (nodoEsta != null)
            {//si existe
                Console.Write("Cambiando nodo con valor: " + dato);
                nodo = new ClaseDatosNodoListaDoble();
                nodo.Dato = newDato;
                nodoEsta = listaDoble.Buscar(nodo);
                if (nodoEsta == null)
                {
                    Console.WriteLine(" por valor: " + newDato);
                    Eliminar(listaDoble, dato);
                    Insertar(listaDoble, newDato);
                }
                else {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" nuevo nodo ya existe, imposible modificar nodo");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            else {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Dato no existe");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        static void Eliminar(ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble, int dato)
        {
            Console.WriteLine("Eliminando dato: " + dato + " de la lista");
            ClaseDatosNodoListaDoble nodo = new ClaseDatosNodoListaDoble();
            nodo.Dato = dato;
            listaDoble.Eliminar(nodo);
        }

        static void Insertar(ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble, int dato)
        {
            Console.WriteLine("Insertando valor: " + dato + " en la lista");
            ClaseDatosNodoListaDoble info = new ClaseDatosNodoListaDoble();
            info.Dato = dato;
            listaDoble.Insertar(info);
        }

        static void Mostrar(ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble)
        {
            Console.WriteLine("Mostrando Contenido de la lista desde el inicio y desde el fin");
            Console.Write("NI/Null");
            foreach (var item in listaDoble.DesdeNodoInicial)
            {
                Console.Write("<-->" + item.Dato);
            }
            Console.WriteLine("<-->NF/Null");


            Console.Write("NF/Null");
            foreach (var item in listaDoble.DesdeNodoFinal)
            {
                Console.Write("<-->" + item.Dato);
            }
            Console.WriteLine("<-->NI/Null");
        }

        static void MostrarDesdeInicio(ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble)
        {
            Console.WriteLine("Mostrando Contenido de la lista desde el inicio");
            Console.Write("NI/Null");
            foreach (var item in listaDoble.DesdeNodoInicial)
            {
                Console.Write("<-->" + item.Dato);
            }
            Console.WriteLine("<-->NF/Null");
        }

        static void MostrarDesdeFinal(ClaseListaDobleOrdenada<ClaseDatosNodoListaDoble> listaDoble)
        {
            Console.WriteLine("Mostrando Contenido de la lista desde el final");
            Console.Write("NF/Null");
            foreach (var item in listaDoble.DesdeNodoFinal)
            {
                Console.Write("<-->" + item.Dato);
            }
            Console.WriteLine("<-->NI/Null");
        }
    }
}
