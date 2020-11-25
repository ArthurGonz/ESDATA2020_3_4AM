using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002b_PilaClasica
{
    class ClasePila
    {
        private readonly int max;
        private int top;
        private int[] arreglo;


        public ClasePila(int tamaño)
        {
            top = 0;
            max = tamaño;
            arreglo = new int[tamaño];

        }

        private bool EstaLleno()
        {
            if (top == max)
                return (true);
            else
                return (false);
        }

        private bool EstaVacio()
        {
            if (top == 0)
                return (true);
            else
                return (false);
        }




        private string MostrarVerbose()
        {
            char space = ' ';
            string resultado = "\n";
            int longMax = MaxLongitud();

            for (int i = max - 1; i >= 0; i--)
            {
                resultado += new string(space, (max - 1).ToString().Length - i.ToString().Length) + i + " | ";
                if (arreglo[i] == int.MinValue)
                {
                    resultado += new string(space, longMax - 1);
                    resultado += 0;
                }

                else
                {
                    resultado += new string(space, longMax - arreglo[i].ToString().Length);
                    resultado += arreglo[i];
                }

                resultado += " |";

                if (i == top)
                {
                    resultado += " T";

                }
                resultado += "\n";
            }
            return resultado;

        }

        public bool Push(int valor, bool verbose)
        {
            if (!EstaLleno())
            {
                for (int i = max - 1; i >= top; i--)
                {
                    if (i == max - 1)
                    {
                        arreglo[i] = valor;
                    }
                    else
                    {
                        arreglo[i] = valor;
                        arreglo[i + 1] = int.MinValue;
                    }
                    if (verbose)
                    {
                        System.Console.WriteLine(MostrarVerbose());
                    }

                }
                arreglo[top] = valor;
                top++;
                return true;

            }
            return (false);

        }



        public int Pop(bool verbose)
        {
            if (!EstaVacio())
            {
                top--;
                for (int i = top; i < max - 1; i++)
                {
                    arreglo[i + 1] = arreglo[i];
                    arreglo[i] = int.MinValue;
                    if (verbose)
                    {
                        System.Console.WriteLine(MostrarVerbose());
                    }

                }
                int salida = arreglo[max - 1];
                arreglo[max - 1] = int.MinValue;
                return salida;
            }
            else
                return int.MinValue;
        }

        public string Mostrar()
        {
            char space = ' ';
            string resultado = "\n";
            if (!EstaVacio())
            {
                int tamaño_max = MaxLongitud();

                for (int i = max - 1; i >= 0; i--)
                {
                    resultado += new string(space, (max - 1).ToString().Length - i.ToString().Length) + i + " | ";
                    if (i < top)
                    {
                        resultado += new string(space, tamaño_max - arreglo[i].ToString().Length);
                        resultado += arreglo[i];
                    }
                    else
                    {
                        resultado += new string(space, tamaño_max);
                    }

                    resultado += " |";


                    if (i == top)
                    {
                        resultado += " T";
                    }
                    resultado += "\n";

                }
            }

            else resultado = "La pila esta vacia";

            return resultado;



        }

        private int MaxLongitud()
        {
            int longMax = 0;
            for (int i = 0; i < max; i++)
            {
                if (this.arreglo[i] != int.MinValue)
                {
                    if (this.arreglo[i].ToString().Length > longMax)
                    {
                        longMax = this.arreglo[i].ToString().Length;
                    }

                }
                else
                {
                    if (0.ToString().Length > longMax)
                    {
                        longMax = 0.ToString().Length;
                    }
                }
            }

            return longMax;

        }

        public void Vaciar()
        {

            top = 0;
        }


    }
}
