using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3er_Corte
{
    class FuncionesHanoi
    {
        ClaseDatosNodoPilaLista nodo1;
        ClaseDatosNodoPilaLista nodo2;
        ClaseDatosNodoPilaLista nodo3;
        public void LlenarPilas(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreA, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreB, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreC)
        {
            int contador = 0;
            for (int i = 7; i >= 1; i--)
            {
                if (contador%2 == 0)
                {
                    nodo1 = new ClaseDatosNodoPilaLista();
                    nodo1.Dato = i;
                    nodo2 = new ClaseDatosNodoPilaLista();
                    nodo2.Dato = i;
                    nodo3 = new ClaseDatosNodoPilaLista();
                    nodo3.Dato = i;
                    TorreA.Push(nodo1);
                    TorreB.Push(nodo2);
                    TorreC.Push(nodo3);
                }
                contador++;
            }
        }

        public string Mostrar(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreA, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreB, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreC)
        {
            #region declaracion de variables
            string disco1 = "   *   ", disco2 = "  ***  ", disco3 = " ***** ", disco4 = "*******", mostrar = "",
                vacio ="   |   ", Base = "___|___", baseA = "   A   ", baseB= "   B   ", baseC = "   C   ";
            int[] arregloA = new int[4];
            int[] arregloB = new int[4];
            int[] arregloC = new int[4];
            nodo1 = new ClaseDatosNodoPilaLista();
            nodo2 = new ClaseDatosNodoPilaLista();
            nodo3 = new ClaseDatosNodoPilaLista();
            #endregion

            #region Proceso de obtener valores de la pila
            for (int i = 0; i < 4; i++) //Obtener los valores de las pilas
            {
                nodo1 = TorreA.Pop();
                if (nodo1 != null)
                    arregloA[i] = nodo1.Dato;
                
                nodo2 = TorreB.Pop();
                if (nodo2 != null)
                    arregloB[i] = nodo2.Dato;

                nodo3 = TorreC.Pop();
                if (nodo3 != null)    
                    arregloC[i] = nodo3.Dato;
               
            }
            for (int i = 3; i >= 0; i--) //reinsercion de los datos a las pilas 
            {
                if (arregloA[i] != 0)
                {
                    nodo1 = new ClaseDatosNodoPilaLista();
                    nodo1.Dato = arregloA[i];
                    TorreA.Push(nodo1);
                }

                if (arregloB[i] != 0)
                {
                    nodo2 = new ClaseDatosNodoPilaLista();
                    nodo2.Dato = arregloB[i];
                    TorreB.Push(nodo2);
                }

                if (arregloC[i] != 0)
                {
                    nodo3 = new ClaseDatosNodoPilaLista();
                    nodo3.Dato = arregloC[i];
                    TorreC.Push(nodo3);
                }

            }
            #endregion

            #region impresion de discos
            for (int i = 0; i < 4; i++)
            {
                switch (arregloA[i])
                {
                    case 1:
                        mostrar += disco1;
                        break;

                    case 3:
                        mostrar += disco2;
                        break;

                    case 5:
                        mostrar += disco3;
                        break;

                    case 7:
                        mostrar += disco4;
                        break;

                    default:
                        if (i == 3)
                            mostrar += Base;
                        else
                            mostrar += vacio;
                        break;
                }
                mostrar += "\t";
                switch (arregloB[i])
                {
                    case 1:
                        mostrar += disco1;
                        break;

                    case 3:
                        mostrar += disco2;
                        break;

                    case 5:
                        mostrar += disco3;
                        break;

                    case 7:
                        mostrar += disco4;
                        break;

                    default:
                        if (i == 3)
                            mostrar += Base;
                        else
                            mostrar += vacio;
                        break;
                }
                mostrar += "\t";
                switch (arregloC[i])
                {
                    case 1:
                        mostrar += disco1;
                        break;

                    case 3:
                        mostrar += disco2;
                        break;

                    case 5:
                        mostrar += disco3;
                        break;

                    case 7:
                        mostrar += disco4;
                        break;

                    default:
                        if (i == 3)
                            mostrar += Base;
                        else
                            mostrar += vacio;
                        break;
                }
                mostrar += "\n";
            }
            mostrar += baseA + "\t";
            mostrar += baseB + "\t";
            mostrar += baseC + "\t";
            #endregion

            return mostrar;
        }

        public void vaciar(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> Torre1, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> Torre2)
        {
            int verificar = 0;

            for (int i = 4; i >= 1; i--)
            {
                Torre1.Pop();
            }

            for (int i = 4; i >= 1; i--)
            {
                Torre2.Pop();
            }
        }
    }
}
