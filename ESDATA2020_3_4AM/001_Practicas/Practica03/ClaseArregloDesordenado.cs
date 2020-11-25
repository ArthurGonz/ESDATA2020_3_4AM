using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace _001_Practicas.Practica03
{
    
    class ClaseArregloDesordenado
    {
        private int top;
        private readonly int max; 
        private ClaseDatos[] Array;

        static void Main()
        {
            Application.Run(new Practica03_());
        }
        
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        public ClaseArregloDesordenado(int m)
        {
            max = m;
            top = 0;
            Array = new ClaseDatos[max];
        }
       
        public bool EstaLleno()
        {
            if (top == max)
                return true;
            else
                return false;
        }

        public bool EstaVacio()
        {
            if (top == 0)
                return true;
            else
                return false;
        }

        public bool Insertar(ClaseDatos dato)
        {
            if (!EstaLleno())
            {
                for (int i = 0; i < top; i++)
                    if (Array[i].Uniforme == dato.Uniforme)
                        return false;
                Array[top] = dato;
                top++;
                
                return true;
            }
            else
            {
                return false;
            }             
        }

        public bool Eliminar(UInt16 Uniforme)
        {
            int i = 0, x = 0;
            if (!EstaVacio()) 
            {
                for (i = 0; i < top; i++)
                {
                    if (Array[i].Uniforme == Uniforme) 
                    {
                        for (x = i; x < top - 1; x++)
                            Array[i] = Array[i + 1];
                        top--; 
                    return (true);
                    }
                }
                return (false); 
            }
            else
                return (false); 
        }

        public ClaseDatos Consultar(int celda)
        {
            if (celda >= 0 && celda < top)
                return Array[celda];
            else
                return null;
        }

        public bool Ordenar()
        {
            if (!EstaVacio())
            {
                int p=0, x=0;
                ClaseDatos temporal = new ClaseDatos();
                for (p = 0; p <= top - 2; p++)
                    for (x = p + 1; x <= top - 1; x++)
                        if (Array[x].Porcentaje < Array[p].Porcentaje)

                            temporal = Array[p];
                            Array[p] = Array[x];
                            Array[x] = temporal;
                return true;
            }
            return false;
        }

        public ClaseDatos Mayor()
        {
            ClaseDatos Mayor = Array[0];
            for (int i=0; i<top;i++)
                if(Array[i].Porcentaje > Mayor.Porcentaje)
                    Mayor = Array[i];
                return Mayor;
        }




    }
}
