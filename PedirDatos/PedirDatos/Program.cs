using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PedirDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            //Preguntamos el nombre del usuario
            /*Console.Write("Como te llamas?: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}", nombre);*/

            string entrada;
            int num1 = 5, num2, resultado;

            Console.Write("Dame un numero para sumar a {0}:", num1);
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);
            resultado = num1 + num2;

            Console.WriteLine("El resultado es {0}",resultado);
        }
    }
}
