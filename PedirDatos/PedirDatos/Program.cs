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
            Console.Write("Como te llamas?: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}", nombre);

        }
    }
}
