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
            int numMovimientos = 0; //Contador de movimientos
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
                    case 'A': //Seleccion de torre inicial A
                        Hanoi.vaciar(TorreB,TorreC);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        break;

                    case 'B': //Seleccion de torre inicial B
                        Hanoi.vaciar(TorreA, TorreC);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        break;

                    case 'C': //Seleccion de torre inicial C
                        Hanoi.vaciar(TorreB, TorreA);
                        Console.WriteLine(Hanoi.Mostrar(TorreA, TorreB, TorreC));
                        break;

                    default:
                        break;
                }
                Console.ReadLine();
            } while (!terminar);

            Console.ReadLine();
        }
    }
}
