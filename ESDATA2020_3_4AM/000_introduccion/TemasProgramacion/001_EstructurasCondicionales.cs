using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_introduccion
{
    class EstructurasCondicionales
    {
        static void Main()
        {
            #region if

            int a = 0;
            int b = 1;

            //0>1 false
            bool boleano = a > b;
            int c = a + b;

            bool boleano2 = false && true;

            /* x y z
             * 0 0 0
             * 0 1 0
             * 1 0 0
             * 1 1 1
             * 
             * || Or
             * && AND
             * | Pipe
             * ^ Control
             * & ANDERSON
             */

            int x = 2;
            x = x + 5;
            x += 5;

            //Logica bolean
            if (a > b && 50 < 100){
                //Verdadero
            }
            else{
                //Falso
            }

           
            #endregion

            #region switch
            int opcion = 5;
            switch (opcion)
            {
                case 1:
                    break;

                default:
                    break;

            }
            #endregion

            #region operador terniario
            a = 0;
            //enero 1
            //febrero 2
            //..
            //Diciembre 12

            switch (DateTime.Now.Month)
            {
                case 1: //a = 1; break;
                case 2: //a = 2; break;
                case 3: //a = 3; break;
                case 4: //a = 4; break;
                case 5: a = 16; break;
                case 6: //a = 6; break;
                case 7: //a = 7; break;
                case 8: //a = 8; break;
                case 9: //a = 9; break;
                case 10: //a = 10; break;
                case 11: //a = 11; break;
                case 12: a = 8; break;
            }

            if (DateTime.Now.Month <= 5 && DateTime.Now.Month > 0) {
                a = 16;
            }
            else {
                a = 8;
            }

            a = DateTime.Now.Month <= 5 && DateTime.Now.Month > 0 ? 16 : 8;

            #endregion
        }
    }
}
