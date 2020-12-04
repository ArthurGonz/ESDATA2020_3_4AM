using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3er_Corte
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inicializacion de variables
            FuncionesHanoi Hanoi = new FuncionesHanoi(); //Funciones Logicas
            ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreA = new ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista>(); //Pila 1
            ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreB = new ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista>(); //Pila 2
            ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista> TorreC = new ClasePilaDesordenadaLista<ClaseDatosNodoPilaLista>(); //Pila 3
            int numeroMovimientos = 0; //Contador de movimientos
            bool terminar = false, verificar = false;  //Condicion de finalizacion y verificacion
            char opc; //Opcion de seleccion de torre
            #endregion

            #region Seleccion de torre inicial
            Hanoi.LlenarPilas(TorreA, TorreB, TorreC);
            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
            #endregion

            do
            {
                Console.Write("En que torre quiere iniciar el juego? (A, B o C):");
                opc = char.Parse(Console.ReadLine());


                switch (opc)
                {
                    #region Case A
                    case 'A': //Seleccion de torre inicial A
                        Hanoi.vaciar(TorreB,TorreC);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        do
                        {
                            Console.Write("En que torre quiere terminar el juego? (B o C):");
                            opc = char.Parse(Console.ReadLine()); //Seleccion de torre ganadora
                            Console.Clear();
                            Console.WriteLine(Hanoi.Mostrar(TorreA,TorreB,TorreC));

                            if (opc == 'B') //Seleccion de torre final B
                            {
                                do
                                {
                                    numeroMovimientos = Hanoi.SeleccionJugada(TorreA,TorreB,TorreC,numeroMovimientos,terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA,TorreB,TorreC));
                                    if (numeroMovimientos == -1)
                                    {
                                        terminar = true;
                                        Environment.Exit(0);
                                    }
                                   terminar = Hanoi.Ganar(TorreB,numeroMovimientos);
                                } while (!terminar);
                                Environment.Exit(0);
                            }
                            if (opc == 'C') //Seleccion de torre final C
                            {
                                do
                                {
                                    numeroMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numeroMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    if (numeroMovimientos == -1)
                                    {
                                        terminar = true;
                                        Environment.Exit(0);
                                    }
                                    terminar = Hanoi.Ganar(TorreC, numeroMovimientos);
                                } while (!terminar);
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Seleccion invalida");
                        } while (!terminar);
                        break;
                    #endregion

                    #region case B
                    case 'B': //Seleccion de torre inicial B
                        Hanoi.vaciar(TorreA, TorreC);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        do
                        {
                            Console.Write("En que torre quiere terminar el juego? (A o C):");
                            opc = char.Parse(Console.ReadLine()); //Seleccion de torre ganadora
                            Console.Clear();
                            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));

                            if (opc == 'A') //Seleccion de torre final B
                            {
                                do
                                {
                                    numeroMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numeroMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    if (numeroMovimientos == -1)
                                    {
                                        terminar = true;
                                        Environment.Exit(0);
                                    }
                                    terminar = Hanoi.Ganar(TorreA, numeroMovimientos);
                                } while (!terminar);
                                Environment.Exit(0);
                            }
                            if (opc == 'C') //Seleccion de torre final C
                            {
                                do
                                {
                                    numeroMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numeroMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    if (numeroMovimientos == -1)
                                    {
                                        terminar = true;
                                        Environment.Exit(0);
                                    }
                                    terminar = Hanoi.Ganar(TorreC, numeroMovimientos);
                                } while (!terminar);
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Seleccion invalida");
                        } while (!terminar);
                        break;
                    #endregion

                    #region Case C
                    case 'C': //Seleccion de torre inicial C
                        Hanoi.vaciar(TorreA, TorreB);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        do
                        {
                            Console.Write("En que torre quiere terminar el juego? (A o B):");
                            opc = char.Parse(Console.ReadLine()); //Seleccion de torre ganadora
                            Console.Clear();
                            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));

                            if (opc == 'A') //Seleccion de torre final B
                            {
                                do
                                {
                                    numeroMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numeroMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    if (numeroMovimientos == -1)
                                    {
                                        terminar = true;
                                        Environment.Exit(0);
                                    }
                                    terminar = Hanoi.Ganar(TorreA, numeroMovimientos);
                                } while (!terminar);
                                Environment.Exit(0);
                            }
                            if (opc == 'B') //Seleccion de torre final B
                            {
                                do
                                {
                                    numeroMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numeroMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    if (numeroMovimientos == -1)
                                    {
                                        terminar = true;
                                        Environment.Exit(0);
                                    }
                                    terminar = Hanoi.Ganar(TorreB, numeroMovimientos);
                                } while (!terminar);
                                Environment.Exit(0);
                            }
                        } while (!terminar);
                        
          
                            break;
                    #endregion

                    case 'Q': //Letra de finalizacion
                        terminar = Hanoi.Perder(numeroMovimientos); //Verificacion de salir del programa
                        break;

                    default:
                        if (opc.ToString() == opc.ToString().ToLower())
                            Console.WriteLine("Ingrese opcion en Mayuscula, intente nuevamente");
                        else
                            Console.WriteLine("Opcion invalida, intente nuevamente");
                        break;
                }
                Console.ReadLine();
            } while (!terminar);

            Console.ReadLine();
        }
    }
}
