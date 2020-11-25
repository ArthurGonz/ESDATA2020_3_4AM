using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ArreglosBidimensional.Programa3_6_5
{
    class ClaseMatriz
    {
        //Tamaño de la matriz
        private readonly int maxrenglones; // Máximo de renglones
        private readonly int maxcolumnas; // Máximo de columnas
        private int renglones; // Cantidad de renglones de la matriz
        private int columnas; // Cantidad de columnas de la matriz
        private double[,] Matriz; // Declaración de la matriz
        public int MaxRenglones()
        {
            return (maxrenglones);
        }
        public int MaxColumnas()
        {
            return (maxcolumnas);
        }
        public int Renglones
        {
            get
            {
                return (renglones);
            }
            set
            {
                renglones = value;
            }
        }
        public int Columnas
        {
            get
            {
                return (columnas);
            }
            set
            {
                columnas = value;
            }
        }
        // Propiedad para acceder a la celda [r,c] de la matriz
        public double this[int r, int c]
        {
            get
            {
                return (Matriz[r, c]);
            }
            set
            {
                Matriz[r, c] = value;
            }
        }
        public ClaseMatriz(int r, int c) // Constructor con parámetros
        {
            maxrenglones = r;
            maxcolumnas = c;
            Renglones = r;
            Columnas = c;
            Matriz = new double[maxrenglones, maxcolumnas];
            // Creación de la matriz
        }
        private bool EstaVacia()
        {
            if (Renglones == 0 || Columnas == 0)
                return (true);
            else
                return (false);
        }
        // Método que devuelve una cadena con el dibujo de la matriz
        public string Mostrar()
        {
            string Resultado = "";
            if (!EstaVacia()) // Si no está vacía ...
            {
                for (int r = 0; r <= Renglones - 1; r++)
                {
                    Resultado = Resultado + "\n";
                    for (int c = 0; c <= Columnas - 1; c++)
                        Resultado = Resultado + Matriz[r, c]
                        + "\t";
                }
            }
            else
                Resultado = "\nMatriz vacía ...";
            return (Resultado);
        }
        // Sobrecarga del operador + (suma)
        public static ClaseMatriz operator +(ClaseMatriz A,ClaseMatriz B)
        {
            ClaseMatriz MatrizC = new
            ClaseMatriz(A.Renglones, A.Columnas); // Creación de un objeto local
            for (int r = 0; r <= A.Renglones - 1; r++)
                for (int c = 0; c <= A.Columnas - 1; c++)
                    MatrizC[r, c] = A[r, c] + B[r, c]; // Suma matricial
            return (MatrizC); // Devuelve la matriz con el resultado de la suma
        }
        // Sobrecarga del operador * (multiplicación)
        public static ClaseMatriz operator *(ClaseMatriz A,
        ClaseMatriz B)
        {
            ClaseMatriz MatrizC = new
            ClaseMatriz(A.Renglones, B.Columnas); // Creación de un objeto local
            double suma = 0.0;
            for (int i = 0; i <= A.Renglones - 1; i++)
                for (int k = 0; k <= B.Columnas - 1; k++)
                {
                    suma = 0.0;
                    for (int j = 0; j <= A.Columnas - 1; j++)
                        suma = suma + A[i, j] * B[j, k];
                    MatrizC[i, k] = suma;
                }
            return (MatrizC);
        }
    }
}

