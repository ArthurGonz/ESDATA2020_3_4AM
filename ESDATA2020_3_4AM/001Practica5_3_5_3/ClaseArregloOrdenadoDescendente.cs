using System;


namespace _001Practica5_3_5_3
{
    class ClaseArregloOrdenadoDescendente
    {
        private int top; // Variable para contar la cantidad de celdas ocupadas
        private readonly int Max; // Tamaño del arreglo
        private ClaseDatos[] Arreglo; // Declaracion del arreglo de objetos
        public int Top
        {
            get{
                return (top);
            }
            set{
                top = value;
            }
        }
        public ClaseArregloOrdenadoDescendente(int m) //Constructor
        {
            Max = m;
            top = 0;
            Arreglo = new ClaseDatos[Max]; // Creación del arreglo
        }

        public bool EstaLleno() // Método para detectar si el arreglo está lleno
        {
            if (Top == Max)
                return (true);
            else
                return (false);
        }

        public bool EstaVacio() // Método para detectar si el arreglo está vacío
        {
            if (Top == 0)
                return (true);
            else
                return (false);
        }

        public bool Insertar(ClaseDatos Dato) // Método para insertar un dato en el arreglo
        {
            int i = 0;
            if (!EstaLleno()) // Si no está lleno ...
            {
                for (i = 0; i < Top; i++)
                {
                    if (Dato.NumeroMatricula == Arreglo[i].NumeroMatricula) // No se permiten duplicados
                        return (false);
                    if (Dato.Calificacion > Arreglo[i].Calificacion)
                    {
                        for (int y = Top; y >= i + 1; y--)
                            Arreglo[y] = Arreglo[y - 1]; // Desplazamiento de valores
                        break; // Termina
                    }
                }
                Arreglo[i] = Dato; // Se inserta el dato en el arreglo
                Top++; // Se incrementa la cantidad de datos del arreglo
                return (true); // Inserción exitosa !!!
            }
            else
                return (false); // No se inserta el dato (arreglo lleno)
        }

        public bool Eliminar(UInt16 NumeroMatricula) // Método para eliminar un dato del arreglo
        {
            int i = 0, x = 0;
            if (!EstaVacio()) // Si no está vacío ...
            {
                for (i = 0; i <= Top - 1; i++)
                {
                    if (Arreglo[i].NumeroMatricula == NumeroMatricula) // Comparación
                    {
                        for (x = i; x <= Top - 2; x++) // Desplazamiento de los valores de las celdas sucesoras
                            Arreglo[x] = Arreglo[x + 1];
                        Top--; // Se decrementa la cantidad de datos del arreglo
                        return (true);
                    }
                }
                return (false); // No se elimina el dato (no existe el jugador)
            }
            else
                return (false); // No se elimina el dato (arreglo vacío)
        }

        public ClaseDatos Consultar(int celda)
        {
            if (celda >= 0 && celda < top)
                return Arreglo[celda];
            else
                return null; // Devuelve el objeto almacenado en la celda del Arreglo
        }

        public double CalcularPromedio()
        {
            if (!EstaVacio())
            {
                double Suma = 0.0;
                for (int i = 0; i <= Top - 1; i++)
                    Suma += Arreglo[i].Calificacion; // Sumatoria
                return (Suma / Top); // Calcula el promedio y lo devuelve
            }
            else
                return (0.0); // Arreglo vacío (devuelve 0.0)
        }

        public bool Vaciar()
        {
            if (!EstaVacio()) // Si no está vacío ...
            {
                Top = 0; // Inicializa la variable Top
                return (true);
            }
            else
                return (false);
        }

    }
}
