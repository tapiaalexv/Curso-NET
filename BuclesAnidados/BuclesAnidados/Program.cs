﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio #1*/
            int numero, exponente;
            int i; //Variable de control de bucle

            double resultado = 1;
            double resultado_negativo;

            //Pedimos la base(número)
            Console.Write("Ingresa la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Pedimos el exponente
            Console.Write("Ingresa el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            if (exponente < 0) //Si el exponente es negativo, entonces...
            {
                exponente *= -1; // exponente = exponente * -1  ---> convierte el exponente a positivo

                for (i = 1; i <= exponente; i++) // Iteración desde 1 hasta llegar al exponente
                {
                    resultado *= numero;
                }

                // Dividimos al 1 entre el resultado y se lo asignamos a una nueva variable
                resultado_negativo = (1 / resultado);

                //Mostramos el resultado
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado_negativo);
            }

            else // Si el exponente no es menor que cero, por lo tanto es mayor o igual
            {
                for (i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }

                //Mostramos el resultado
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
            }



            /*Ejercicio #2*/
        }
    }
}
