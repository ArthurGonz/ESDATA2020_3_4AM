using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002c_Cola_Practica8_5_2
{
    class ClaseCola
    {
        private readonly int Max; // Tamaño de la cola
                                  // Declaración de los controles de la cola (frente y final)
        private int frente, final;
        ClaseNodo[] Arreglo; // Declaración del arreglo
                             //Propiedad pública para acceder al frente de la  cola
        public int Frente
        {
            get
            {
                return frente;
            }
        }
        // Propiedad pública para acceder al final de la cola
        public int Final
        {
            get
            {
                return final;
            }
        }
        // Constructor de la Cola que recibe como argumento el tamaño de la cola
        public ClaseCola(int Tamaño)
        {
            Max = Tamaño; // Define el tamaño de la cola
            frente = -1; // Inicializa la cola
            final = -1;
            Arreglo = new ClaseNodo[Max]; // Creación del arreglo
        }
        //Método privado para determinar si la Cola esta llena
        public bool EstaLlena()
        {
            if (final == Max - 1)
                return (true);
            else
                return (false);
        }
        //Método para determinar si la Cola esta vacía
        public bool EstaVacia()
        {
            if (frente == -1)
                return (true);
            else
                return (false);
        }
        //Método público que recibe un Nodo para insertarlo  en la Cola
        public bool Encolar(ClaseNodo Nodo)
        {
            if (!EstaLlena()) // Si no está llena ...
            {
                final++; // Incrementa el frente
                Arreglo[final] = new ClaseNodo(); // Crea  el espacio para el nodo
                Arreglo[final] = Nodo; // Inserta el Nodo  al final de la cola
                                       // Verifica si se trata del primer Nodo insertado en la cola
                if (final == 0) 
                    frente = 0;
                return (true); // Operación exitosa
            }
            else
                return (false); // No se insertó el Nodo (cola llena)
        }
        //Método público que elimina y devuelve el primer  Nodo de la Cola
        public ClaseNodo Desencolar()
        {
            if (!EstaVacia()) // Si no está vacía ...
            {
                ClaseNodo Nodo = Arreglo[frente]; // Guarda el Nodo
                Arreglo[frente] = null; // Elimina el nodo
                                        // Optimiza el espacio
                if (frente == final)
                {
                    frente = -1; // Inicializa vacía la cola
                    final = -1;
                }
                else
                    frente++; // Incrementa el frente de la cola
                return Nodo; // Devuelve el nodo eliminado
            }
            else
                return (null); // No se eliminó el Nodo (cola vacía)
        }
        //Método para consultar los datos del Nodo de la celda r
        public ClaseNodo Consultar(int r)
        {
            return (Arreglo[r]); // Devuelve el Nodo almacenado en la celda r
        }
    }
}
