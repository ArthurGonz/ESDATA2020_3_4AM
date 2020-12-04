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
                mostrar += "\t";
                mostrar += arregloA[i];
                mostrar += "\t";
                mostrar += arregloB[i];
                mostrar += "\t";
                mostrar += arregloC[i];
                mostrar += "\n";

            }

            //for (int i = 0; i < 4; i++)
            //{
                
            //    mostrar += "\n";
            //}

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
    
        public int SeleccionJugada(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreA, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreB, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreC, int numeroMovimientos, bool terminar)
        {
            string jugada = "";

            Console.Write("jugada: ");
            jugada = Console.ReadLine();

            switch (jugada)
            {
                case "AB":
                    Mover(TorreA, TorreB, nodo1, nodo2);
                    break;

                case "AC":
                    Mover(TorreA, TorreC, nodo1, nodo3);
                    break;

                case "BA":
                    Mover(TorreB, TorreA, nodo2, nodo1);
                    break;

                case "BC":
                    Mover(TorreB, TorreC, nodo2, nodo3);
                    break;

                case "CA":
                    Mover(TorreC, TorreA, nodo3, nodo1);
                    break;

                case "CB":
                    Mover(TorreC, TorreB, nodo3, nodo2);
                    break;

                case "Q":
                    terminar = Perder(numeroMovimientos);
                    numeroMovimientos--;
                    return -1;
                    break;
                default:
                    Console.WriteLine("Movimiento invalido");
                    break;
            }
            numeroMovimientos++;
            return numeroMovimientos;
        }

        public void Mover(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreOrigen, ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreDestino, ClaseDatosNodoPilaLista nodoOrigen, ClaseDatosNodoPilaLista nodoDestino )
        {
            int datoOrigen = 0, datoDestino = 0;

            // Extraer dato de origen
            nodoOrigen = TorreOrigen.Pop(); 
            datoOrigen = nodoOrigen.Dato;
            //extraer dato destino
            nodoDestino = TorreDestino.Pop();
            if(nodoDestino != null)
                datoDestino = nodoDestino.Dato;
            // Reintegrar dato destino
            TorreDestino.Push(nodoDestino);

            if (datoDestino != 0)
            {
                if (datoOrigen < datoDestino) //Verificar si el dato a insertar es menor
                {
                    TorreDestino.Push(nodoOrigen); //incluir dato origen a destino
                }
                else
                {
                    TorreOrigen.Push(nodoOrigen); //reintegrar dato origen
                    Console.WriteLine("Movimiento invalido");
                }
            }
            else
            {
                TorreDestino.Push(nodoOrigen); //incluir dato origen a destino vacio
            }
        }

        public bool Perder(int numeroMovimientos)
        {
            Console.Clear();
            Console.WriteLine("Perdiste el juego y realizaste {0} movimientos", numeroMovimientos);
            Console.ReadLine();
            return true;
        }

        public bool Ganar(ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreA, int numeroMovimientos) 
        {
            int[] arregloA = new int[4];
            for (int i = 0; i < 4; i++) //Obtener los valores de las pilas
            {
                nodo1 = TorreA.Pop();
                if (nodo1 != null)
                    arregloA[i] = nodo1.Dato;
            }

            for (int i = 3; i >= 0; i--) //reinsercion de los datos a las pilas 
            {
                if (arregloA[i] != 0)
                {
                    nodo1 = new ClaseDatosNodoPilaLista();
                    nodo1.Dato = arregloA[i];
                    TorreA.Push(nodo1);
                }
            }

            if (arregloA[3] != 0)
            {
                Console.WriteLine("Felicidades has ganado");
                Console.WriteLine("Realizaste {0} movimientos", numeroMovimientos);
                Console.ReadLine();
                return true;
            }
            return false;
        }

    }
}
