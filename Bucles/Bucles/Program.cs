using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FOR*/
            // Asignación compuesta (x -= 5) == (x = x - 5)
            // (acumulador = acumulador + variable) == (acumulador += variable)

            //Variables
            byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Console.Write("Ingresa el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificación: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificacion;
            }

            //Calculamos el promedio
            promedio = sumaCalif / numAlumnos;

            //Mostramos el promedio
            Console.WriteLine("El promedio es: {0}", promedio);

            /*WHILE*/
            byte numero1 = 1;

            while (numero1 <= 10)
            {
                Console.WriteLine("EL numero es: {0}", numero1);
                numero1++;
            }


            /*DO-WHILE*/
            //Variables
            decimal num1, num2, resultado = 0M;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                //Pedimos una opción
                Console.Write("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //Pedimos los dos números
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Hacer la operación según la opción escogida
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no es valido");
                    }
                    break;
            }

            //Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
