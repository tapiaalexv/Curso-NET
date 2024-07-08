using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        /*
        Tipos Numéricos Enteros: int, long, short, byte
        Tipos Numéricos de Punto Flotante: float, double, decimal
        Tipo Booleano: bool
        Tipo Carácter: char
        Tipo Cadena: string
        */

        static void Main(string[] args)
        {
            //Para las variables se utilizara notacion: camelCase
            int a = 11, numLibros = 20;
            
            double promedioFinal = 9.5;
            
            bool esVerdad = false; //por default C# le da valor de 'false'
            
            char letra = 'M';
            
            string frase = "Hola soy una frase";

            //Mostrar variables en consola
            Console.WriteLine(numLibros);
            Console.WriteLine();

            //Cadena de formato
            Console.WriteLine("Esto es una cadena de formato, la letra es {0}", letra);
            Console.WriteLine("El promedio es {0} con un total de libros de {1}",promedioFinal, numLibros);
                        
        }
    }
}
