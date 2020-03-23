using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario = "Suyai";
            string usuario2;
            do
            {
                Console.WriteLine("Ingrese su usuario");
                usuario2 = Console.ReadLine();
                if (usuario2 != usuario)
                {
                    Console.WriteLine("No te conozco");
                }
                
            } while (usuario2 != usuario);

            Console.WriteLine("¡Hola, " + usuario2 +"!");
            Console.ReadKey();

        }
    }
}
