using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_De_Hanoi
{
    class FuncionesHanoi
    {
        public void LlenarPilas(ClasePila TorreA, ClasePila TorreB, ClasePila TorreC)
        {
            int count = 0;
            for (int i = 7; i >= 1; i--)
            {
                if (count % 2 == 0)
                {
                    TorreA.Push(i);
                    TorreB.Push(i);
                    TorreC.Push(i);
                    count = 0;
                }
                count++;
            }
        }

        public string Mostrar(ClasePila TorreA, ClasePila TorreB, ClasePila TorreC)
        {
            string disco1 = "   *   ",
                disco2 = "  ***  ",
                disco3 = " ***** ",
                disco4 = "*******",
                vacio = "   |   ", Base = "___|___",
                baseA = "   A   ", baseB = "   B   ", baseC = "   C   ";

            int[] arregloA = new int[4];
            int[] arregloB = new int[4];
            int[] arregloC = new int[4];
            string mostrar = "";

            #region proceso de obtener valores
            for (int i = 0; i < 4; i++) //Obtener los valores de las pilas
            {
                arregloA[i] = TorreA.Pop();
                arregloB[i] = TorreB.Pop();
                arregloC[i] = TorreC.Pop();
            }

            for (int i =3; i >= 0; i--) //Ingresar nuevamente los valores a las pilas
            {
                if (arregloA[i] != int.MinValue)
                    TorreA.Push(arregloA[i]);
                if (arregloB[i] != int.MinValue)
                    TorreB.Push(arregloB[i]);
                if (arregloC[i] != int.MinValue)
                    TorreC.Push(arregloC[i]);
            }
            #endregion

            #region Impresion de discos de asterisco 
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

        public void vaciar(ClasePila Torre1, ClasePila Torre2)
        {
            int verificar = 0;
            do
            {
                verificar = Torre1.Pop();
            } while (verificar != int.MinValue);
            verificar = 0;
            do
            {
                verificar = Torre2.Pop();
            } while (verificar != int.MinValue);
        }

        public int SeleccionJugada(ClasePila TorreA, ClasePila TorreB, ClasePila TorreC, int numMovimientos,bool terminar)
        {
            string jugada = "";
            
            Console.Write("jugada: ");
            jugada = Console.ReadLine();

            switch (jugada)
            {
                case "AB":
                    Mover(TorreA, TorreB);
                    break;

                case "AC":
                    Mover(TorreA, TorreC);
                    break;

                case "BA":
                    Mover(TorreB, TorreA);
                    break;

                case "BC":
                    Mover(TorreB, TorreC);
                    break;

                case "CA":
                    Mover(TorreC, TorreA);
                    break;

                case "CB":
                    Mover(TorreC, TorreB);
                    break;

                case "Q":
                    terminar = Perder(numMovimientos);
                    numMovimientos--;
                    break;
                default:
                    Console.WriteLine("Movimiento invalido");
                    break;
            }
            numMovimientos++;
            return numMovimientos;
        }

        public void Mover(ClasePila torreOrigen, ClasePila torreDestino)
        {
            int datoOrigen = 0, datoDestino = 0;
            datoOrigen = torreOrigen.Pop(); //Extraer dato origen
            datoDestino = torreDestino.Pop(); //Extraer dato destino
            torreDestino.Push(datoDestino); //reintegrar dato destino
            if (datoDestino != int.MinValue)
            {
                if (datoOrigen < datoDestino)
                {
                    torreDestino.Push(datoOrigen); //incluir dato origen a destino
                }
                else
                {
                    torreOrigen.Push(datoOrigen); //reintegrar dato origen
                    Console.WriteLine("Movimiento invalido");
                }
            }
            else
            {
                torreDestino.Push(datoOrigen); //incluir dato origen a destino
            }
        }

        public bool Ganar(ClasePila torreGanadora,int numMovimientos)
        {
            if (torreGanadora.EstaLlena())
            {
                Console.WriteLine("Felicidades Has ganado");
                Console.WriteLine("Realizaste {0} movimientos", numMovimientos);
                return true;
            }
            return false;
        }

        public bool Perder(int numMovimientos)
        {
            Console.Clear();
            Console.WriteLine("Perdiste el juego y realizaste {0} movimientos", numMovimientos);
            return true;
        }

    }
}
