using System;


namespace _001_Arreglos
{
    class _01_InicializarArreglo
    {
        static void Main()
        {
            int dato;
            int[] MiArreglo; //identificador de variable de tipo arreglo

            //Aqui estoy pidiendo 5 espacios de memoria de tamaño entero    
            MiArreglo = new int[5];

            int[] MiSegundoArreglo = new int[5]; //Todas las posiciones se declaran en 0

            int[] MiTercerArreglo = new int[5] { 1, 2, 3, 4, 5 }; 

            int[] MiCuartoArreglo = new int[] { 1, 2, 3, 4, 5 };

            Imprimir(MiArreglo);
        
            MiArreglo[0] = 5;
            MiArreglo[1] = 4;
            MiArreglo[2] = 3;
            MiArreglo[3] = 2;
            MiArreglo[4] = 1;

            Imprimir(MiArreglo);

            object[] MiArregloObjetos = new object[5];

        }

        static void Imprimir(int[] Arreglo)
        {
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine("El valor en {0} contiene: {1}", i, Arreglo[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
