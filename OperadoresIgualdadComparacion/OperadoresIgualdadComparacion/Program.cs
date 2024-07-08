using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresIgualdadComparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operadores de Igualdad*/
            // ==, !=
            int a = 1, b = 2;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            /*Operadores de Comparacion*/
            // <, >, <=, >=
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);

            //PALABRAS CLAVES / KEYWORDS
            /*
             int @int; se usa @ para usar palabras claves como nombre de variable
            NO SE RECOMIENDO NOMBRAR CON KEYWORDS A VARIABLES
             */
        }
    }
}
