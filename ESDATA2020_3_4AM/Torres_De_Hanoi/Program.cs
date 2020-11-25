using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_De_Hanoi
{
    class Program
    {  
        static void Main(string[] args)
        {

            #region Inicializacion de variables
            FuncionesHanoi Hanoi = new FuncionesHanoi(); //Funciones Logicas
            ClasePila TorreA = new ClasePila(4); //Pila 1
            ClasePila TorreB = new ClasePila(4); //Pila 2
            ClasePila TorreC = new ClasePila(4); //Pila 3
            int numMovimientos = 0; //Contador de movimientos
            bool terminar = false,verificar=false; //Condicion de finalizacion
            char opc;
            #endregion

            #region Seleccion De Torre Inicial
            Hanoi.LlenarPilas(TorreA, TorreB, TorreC);
            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
            #endregion
            do 
            {
                Console.Write("En que torre quiere iniciar el juego: (A, B o C): ");
                opc = char.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 'A': //Seleccion de torre inicial A
                        Hanoi.vaciar(TorreB, TorreC); //Vaciar torres  no seleccionadas
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC)); //Imprimir las torres
                        do
                        {
                            Console.Write("En que torre quiere terminar el juego (B, C): "); 
                            opc = char.Parse(Console.ReadLine()); //Seleccion de torre final
                            Console.Clear();
                            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                       
                            if (opc == 'B') //Seleccion de torre final B
                            {
                                verificar = true;
                                do
                                {
                                    numMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC,numMovimientos,terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    terminar = Hanoi.Ganar(TorreB,numMovimientos); //verificacion de victoria
                                } while (!terminar) ;
                            }
                            if(opc=='C') //Seleccion de torre final C
                            {
                                verificar = true;
                                do
                                {
                                    numMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    terminar = Hanoi.Ganar(TorreC,numMovimientos); //verificacion de victoria
                                } while (!terminar);
                            }
                            Console.WriteLine("Seleccion invalida");
                        } while (!verificar);
                        break;
                    #region CaseB
                    case 'B': //Seleccion de torre inicial B
                        Hanoi.vaciar(TorreA, TorreC);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        do
                        {
                            Console.Write("En que torre quiere terminar el juego (A, C): ");
                            opc = char.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                            if (opc == 'A') //Seleccion de torre final A
                            {
                                verificar = true;
                                do
                                {
                                    numMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numMovimientos, terminar); //jugada a realizar
                                    Console.Clear();
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    terminar = Hanoi.Ganar(TorreA,numMovimientos); //verificacion de victoria
                                } while (!terminar);
                            }
                            if (opc == 'C') //Seleccion de torre final C
                            {
                                verificar = true;
                                do
                                {
                                    Console.Clear();
                                    numMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numMovimientos, terminar); //jugada a realizar
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    terminar = Hanoi.Ganar(TorreC,numMovimientos); //verificacion de victoria
                                } while (!terminar);
                            }
                            Console.WriteLine("Seleccion invalida");
                        } while (!verificar);
                        break;
                    #endregion

                    #region CaseC
                    case 'C': //Seleccion de torre inicial C
                        Hanoi.vaciar(TorreA, TorreB);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        do
                        {
                            Console.Write("En que torre quiere terminar el juego (A, B): ");
                            opc = char.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                            if (opc == 'A') //Seleccion de torre final A
                            {
                                verificar = true;
                                do
                                {
                                    Console.Clear();
                                    numMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numMovimientos, terminar); //jugada a realizar
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    terminar = Hanoi.Ganar(TorreA,numMovimientos); //verificacion de victoria
                                } while (!terminar);
                            }
                            if (opc == 'B') //Seleccion de torre final B
                            {
                                verificar = true;
                                do
                                {
                                    Console.Clear();
                                    numMovimientos = Hanoi.SeleccionJugada(TorreA, TorreB, TorreC, numMovimientos, terminar); //jugada a realizar
                                    Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                                    terminar = Hanoi.Ganar(TorreB,numMovimientos); //verificacion de victoria
                                } while (!terminar);
                            }
                            Console.WriteLine("Seleccion invalida");
                        } while (!verificar);
                        break;
                    #endregion
                    case 'Q': //Letra de finalizacion
                        terminar = Hanoi.Perder(numMovimientos); //Verificacion de salir del programa
                        break;

                    default:
                        if (opc.ToString() == opc.ToString().ToLower()) //Verificar si las opciones son mayusculas
                            Console.WriteLine("Ingrese opcion en mayuscula, Intente nuevamente");
                        else
                            Console.WriteLine("Opcion invalida, Intente nuevamente");
                        break;
                }
                Console.ReadLine();
            } while (!terminar); 

            Console.ReadLine();
        }
    }
}
