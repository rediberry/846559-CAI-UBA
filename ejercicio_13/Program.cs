using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {

            string n;
            bool esNumero;
            int factorial;
            do
            {
                Console.WriteLine("ingrese un número");
                n = Console.ReadLine();
                esNumero = int.TryParse(n, out factorial);
            }
            while (!esNumero);


            Console.WriteLine("El factorial del numero ingresado es "+Factorial.Facto(factorial));
            Console.ReadKey();
        }
    }
}
