using System;
using System.Globalization;
using System.Runtime.Remoting;

namespace _001_Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int InicioMenu = 0, FinMenu = 7, opcion = 0;

            String Menu = "1: BubbleSort " +
                "\n2: HeapSort" +
                "\n3: InsertSort" +
                "\n4: QuickSort" +
                "\n5: PancakeSort" +
                "\n6: SelectionSort" +
                "\n7: Finalizar" +
                "\nOpcion: ";
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(Menu);
                    int.TryParse(Console.ReadLine(), out opcion);

                    if(opcion < InicioMenu || opcion > FinMenu)
                    {
                        Console.WriteLine("Opcion invalida");
                        Console.ReadLine();
                    }
                } while (opcion < InicioMenu || opcion > FinMenu);

                int[] Array = new int[6] { 5, 7, 3, 1, 9, 4 };

                if(opcion < 7)
                {
                    Console.WriteLine("\nNumeros desordenados: 5,7,3,1,9,4");
                    Console.WriteLine("Ejecutando algoritmo...");
                }

                switch (opcion)
                {
                    
                    case 1:
                        bubbleSort(Array);
                        imprimir(Array);
                        break;
                   
                    case 2:
                        HeapSort(Array, Array.Length);
                        imprimir(Array);
                        break;
                    
                    case 3:
                        InsertSort(Array);
                        imprimir(Array);
                        break;

                    case 4:
                        QuickSort(0, Array.Length - 1, Array);
                        imprimir(Array);
                        break;
                   
                    case 5:
                        PancakeSort(Array,Array.Length);
                        imprimir(Array);
                        break;
             
                    case 6:
                        SelectionSort(Array);
                        imprimir(Array);
                        break;
 
                    case 7:
                        Console.WriteLine("\nFin del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

               

                Console.ReadLine();
            } while (opcion != FinMenu);

        }


        static void bubbleSort(int [] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        swap(j, j + 1, Array);
                    }
                }
            }
        }

        #region HeapSort    
        static void HeapSort(int[] Array,int n)
        {
            for (int i = n/2 - 1; i >= 0; i--)
            {
                Heapify(Array, n, i);
            }
            for(int i = n-1;i >= 0; i--)
            {
                swap(0,i,Array);
                Heapify(Array, i, 0);
            }
        }
        static void Heapify(int[] Array, int n, int i)
        {
            int Largest = i;
            int left = 2*i + 1;
            int right = 2*i + 2;
            if(left < n && Array[left] > Array[Largest])
            {
                Largest = left;
            }
            if (right < n && Array[right] > Array[Largest])
            {
                Largest = right;
            }
            if(Largest != i)
            {
                swap(i, Largest, Array);
                Heapify(Array, n, Largest);
            }
        }
        #endregion

        static void InsertSort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int j = i - 1;
                int temporal = Array[i];
                while (j >= 0 && Array[j] > temporal)
                {
                    Array[j + 1] = Array[j];
                    j--;
                }
                Array[j + 1] = temporal;
            }
        }

        static void QuickSort(int posInicio,int PosFinal,int[] Array)
        {
            int i, j, central;
            Double pivote;
            central = (posInicio + PosFinal) / 2;
            pivote = Array[central];
            i = posInicio;
            j = PosFinal;

            do
            {
                while (Array[i] < pivote) i++ ;
                while (Array[j] > pivote) j--;
                if (i <= j)
                {
                    swap(i,j,Array);
                    i++;
                    j--;
                }
            } while (i <= j);

            if(posInicio < j)
            {
                QuickSort(posInicio,j,Array);
            }
            if (i < PosFinal)
            {
                QuickSort(i,PosFinal,Array);
            }
        }

        #region PancakeSort
        static void PancakeSort(int[] Array, int n)
        {
            for(int i = n; i>1; i--)
            {
                int min = FindMax(Array,i);

                if(min != i - 1)
                {
                    flip(Array,min);

                    flip(Array,i-1);
                }
            }
        }
        static int FindMax(int[] Array, int n)
        {
            int min, i;
            for (min=0,i=0; i<n;i++)
            {
                if (Array[i] > Array[min])
                {
                    min = i;
                }
            }
            return min;
        }
        static void flip(int[] Array, int i)
        {
            int temp, Count = 0;
            while (Count < i)
            {
                swap(Count,i,Array);
                Count++;
                i--;
            }
        }
        #endregion

        static void SelectionSort(int[] Array)

        {
            for (int i = 0; i<Array.Length;i++)
            {
                int menor = i,j;
                for(j=i+1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[menor])
                    {
                        menor = j;
                    }
                }
                swap(menor, i, Array);
            }
        }

        static void imprimir(int[] Array)
        {
            Console.Write("Numeros ordenados:");
            foreach (int var in Array) { Console.Write("{0},", var); }
        }

        static void swap(int i1, int i2,int[] Arreglo)
        {
            int temporal = Arreglo[i1];
            Arreglo[i1] = Arreglo[i2];
            Arreglo[i2] = temporal;
        }
    }
   
}
