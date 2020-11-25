using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002c_Cola
{
    class ClaseCola
    {
        private readonly int Max; // Define el tamaño de la cola
        private int Frente;
        private int Final;
        private int[] Arreglo; // Declaración del arreglo
        public ClaseCola(int Tamaño)
        {
            Max = Tamaño; // Define el tamaño de la cola
            Frente = -1; // Inicializa la cola vacía
            Final = -1;
            Arreglo = new int[Max]; // Creación del arreglo de tamaño Max
        }
        // Método para detectar si la cola está llena
        private bool EstaLlena()
        {
            if (Final == Max - 1)
                return (true);
            else
                return (false);
        }
        // Método para detectar si la cola está vacía
        private bool EstaVacia()
        {
            if (Frente == -1)
                return (true);
            else
                return (false);

        }
        // Método para insertar un Dato en la cola
        public bool Encolar(int Dato)
        {
            if (!EstaLlena()) // Si no está llena ...
            {
                Final++; // Incrementa el Final de la cola
                Arreglo[Final] = Dato; // Inserta el Dato en el Final del Arreglo
                                       // Verifica si se trata del primer Dato  insertado en la cola
                if (Final == 0)
                    Frente = Final;
                return (true); // Inserción exitosa
            }
            else
                return (false); // No se insertó el dato (cola llena)
        }
        // Método para eliminar el primer dato de la cola
        public int Desencolar()
        {
            int salida; 
            if (!EstaVacia()) // Si no está vacía ...
            {
                salida = Arreglo[Frente];
                // Compara si la cola se quedó vacía para optimizar el espacio
                if (Frente == Final)
                {
                    Frente = -1; // Inicializa la cola
                    Final = -1;
                }
                else
                    Frente++; // Elimina el dato incrementando el Frente
                return salida; // Eliminación exitosa
            }
            else
                return int.MinValue; // No se eliminó el dato (cola vacía)
        }
        // Método para desplegar en pantalla los datos de  la cola
        public string Mostrar()
        {
            string Resultado = "\n";
            if (!EstaVacia()) // Si no está vacía ...
            {
                for (int i = Frente; i <= Final; i++) // Recorre las celdas ocupadas de la cola
                    Resultado = Resultado + "\n[" + i + "] -> " + Arreglo[i].ToString();
            }
            else
                Resultado = "\nCola vacía !!!";
            Resultado = Resultado + "\n\nFrente = " +
            Frente.ToString();
            Resultado = Resultado + "\nFinal = " +
            Final.ToString();
            Resultado = Resultado + "\nMax = " +
            Max.ToString();
            return (Resultado); // Devuelve el Resultado
        }
        // Método para eliminar todos los datos almacenados en la cola
        public void Vaciar()
        {
            // Inicializa vacía la cola
            Frente = -1;
            Final = -1;
        }
    }
}

