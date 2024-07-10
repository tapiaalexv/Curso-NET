using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double num;

            //Pedir numero
            Console.Write("Dame un numero: ");
            num = Convert.ToDouble(Console.ReadLine());

            //Usamos la condicion if
            if (num >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }

            if (num <= 0)
            {
                Console.WriteLine("El numero es negativo");
            }


            /*IF -  ELSE*/
            // Variables
            decimal num1, num2, resultado = 0.0M;
            byte opcion;

            // Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            // Pedimos al usuario que escoja una opción
            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            // Pedimos el primer número
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // Pedimos el segundo número
            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            if (opcion == 1)// Suma
            {
                resultado = num1 + num2;
            }
            else if (opcion == 2) //Resta
            {
                resultado = num1 - num2;
            }
            else if (opcion == 3) //Multiplicacion
            {
                resultado = num1 * num2;
            }
            else if (opcion == 4) //Division
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("No es posible dividir entre cero!");
                }
            }
            else
            {
                Console.WriteLine("Esa opcion no existe");
            }
            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);


            /*SWITCH*/
            byte mes;

            Console.Write("Ingresa el número del que quieres conocer el mes: ");
            mes = Convert.ToByte(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                default:
                    Console.WriteLine("Ese número de mes no existe");
                    break;
            }

        }
    }
}
