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

            Console.WriteLine("El valor ANTES de la refenrecia {0}", numAR);

            PruebaRef(ref numAR);
            Console.WriteLine("El valor DESPUES de la refenrecia {0}", numAR);


            /*OUT*/
            //[out] [nombre_variable]

            //NO es necesario dar un valor antes de pasar por referencia con OUT
            int num2AR;

            Console.WriteLine("Con OUT no es necesario inicialiazr la variable");

            PruebaOut(out num2AR);
            Console.WriteLine("El valor DESPUES de OUT {0}", num2AR);

            /*VAR*/
            //Se debe inicializar en la misma linea
            var nombre = "Luis";
            var cedula = 1726503103;
            var sueldo = 900.50;

            /*TUPLA*/
            //Siempre debe ser 2 o + elementos
            //(tipo1, tipo2, ...) nombreVariable = (valor1, valor2, ...);

            (int, int, int) numPersonas = (1, 2, 3);
            (int, double, string, char) numPersonas2 = (27, 10.0, "Clarissa", 'F');

            Console.WriteLine(numPersonas.Item2 + " - " + numPersonas2.Item2 + " - " + numPersonas2.Item3);

            //Cuando se tiene diferentes tipos en los valores usaremos VAR
            //[var] nombreVariable = (valor1, valor2, ...); 
            var persona1 = ("Alexis", 'M', 2974368, 26);
            Console.WriteLine(persona1.Item2 + " - " + persona1.Item1 + " - " + persona1.Item3);

            //Podemos nombrar los valores
            //Para tipo implicito
            var persona2 = (nombre: "Alexis", sexo: 'M', telefono: 2974368, edad: 26);
            Console.WriteLine(persona2.nombre + " - " + persona2.sexo + " - " + persona2.edad + " - " + persona2.telefono);

            //Para tipo explicito
            (string nombre, char sexo, int telefono, byte edad) persona3 = ("Alexis", 'M', 2974368, 26);
            Console.WriteLine(persona3.nombre + " - " + persona3.sexo + " - " + persona3.edad + " - " + persona3.telefono);

        }

        static void PruebaRef(ref int numPa)
        {
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
