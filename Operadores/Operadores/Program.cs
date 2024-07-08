using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operadores binarios*/

            //Suma
            Console.WriteLine(5 + 6);
            int num1 = 3;
            double num2 = 12.5;
            Console.WriteLine(num1 + num2);

            //Concatenacion de cadenas
            string saludo = "Hola";
            string nombre = "Alexis";
            Console.WriteLine(saludo + " " + nombre);

            //Resta
            Console.WriteLine(5 - 6);
            int num3 = 3;
            double num4 = 12.5;
            Console.WriteLine(num1 - num2);

            //Multiplicacion
            Console.WriteLine(5 * 6);
            int num5 = 3;
            double num6 = 12.5;
            Console.WriteLine(num1 * num2);

            //Division
            Console.WriteLine(13 / 3); //Si se usan entereos el resultado sera entero
            Console.WriteLine(13 / 3.0); //Si se quiere un decimal basta con agregar un .float a cualquiera

            //Resto
            Console.WriteLine(5 % 2);

            //Jerarquia de Operadores Binarios
            //1. * / %
            //2. + -

        }
    }
}
