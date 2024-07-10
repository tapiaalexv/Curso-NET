using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDatosExtras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*REFERENCIA*/
            //[ref] [nombre_variable]

            //Es necesario dar un valor antes de pasar por referencia
            int numAR = 0;

            Console.WriteLine("El valor ANTES de la refenrecia {0}",numAR);

            PruebaRef(ref numAR);
            Console.WriteLine("El valor DESPUES de la refenrecia {0}", numAR);


            /*OUT*/
            //[out] [nombre_variable]

            //NO es necesario dar un valor antes de pasar por referencia con OUT
            int num2AR;

            Console.WriteLine("Con OUT no es necesario inicialiazr la variable");

            PruebaOut(out num2AR);
            Console.WriteLine("El valor DESPUES de OUT {0}", num2AR);

            /**/
        }

        static void PruebaRef(ref int numPa){ 
            //Modificamos a traves de referencia el valor
            numPa = 10;
        }

        static void PruebaOut(out int numPa)
        {
            //Modificamos a traves de referencia el valor
            numPa = 20;
        }
    }
}
