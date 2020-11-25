using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arreglos
{
    class ClaseArregloDesordenado
    {
        #region campos
        private readonly int max;
        private int top;
        private int[] arreglo;
        #endregion

        #region propiedades
        #endregion


        #region Metodos
        //Metodo Constructor
        public ClaseArregloDesordenado(int m){
            max = m;
            top = 0;
            arreglo = new int[max];
        }

        public bool EstaLleno()
        {
            if (top == max)
                return true;    
            return false;
        }

        public bool EstaVacio()
        {
            if (top == 0)
                return true;
            return false;
        }

        public bool Insertar(int dato) 
        {
            if (!EstaLleno())
            {
                for (int i = 0; i < top-1; i++)
                    if (arreglo[i] == dato)
                        return false;

                arreglo[top] = dato;
                top = top + 1; //Top++;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        /// <summary>
        /// Metodo que permite eliminar un valor dentro del arreglo
        /// </summary>
        /// <param name="dato">Valor a eliminar </param>
        /// <returns>True en caso de eliminar el arreglo, false en caso de no eliminar el arreglo</returns>
        public bool Eliminar(int dato) 
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < top-1; i++)
                    if (arreglo[i] == dato)
                    {
                        for (int y = i; y <= top - 2; y++)
                            arreglo[y] = arreglo[y + 1];
                        top = top - 1;
                        return true; //Se elimino el dato
                    }    //Fin de Condicion
                return false;
            }
            return false;
        }

        public String Mostrar() 
        {
            string resultado = "Top = " + top + "\t{";
            if (!EstaVacio())
                for (int i = 0; i < top; i++)
                {
                    resultado = resultado + arreglo[i];
                    if (i < top - 1)
                        resultado += ",";
                }
            else
                return "Top = 0.  Arreglo Vacio";
            return resultado+"}";
        }

        public Boolean Ordenar() {
            if (!EstaVacio())
            {
                for (int p = 0; p <= top-2; p++)
                    for (int i = p+1; i <= top-1; i++)
                        if(arreglo[i] < arreglo[p])
                            swap(i,p);
                return true;
            }
            return false;
        }

        private void swap(int index1, int index2)
        {
            int temporal = arreglo[index2];
            arreglo[index2] = arreglo[index1];
            arreglo[index1] = temporal;
        }
        public int ObtenerMayor() {

            int Mayor = arreglo[0];
            for (int i = 0; i <= top-1; i++)
                if(arreglo[i] > Mayor)
                    Mayor = arreglo[i];
            return Mayor;
        }

        #endregion
            
        #region Eventos
        #endregion
    }

}
