using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            bool esNumero;
            int valor;
            int n2;
            

            do
            {
                Console.WriteLine("Ingrese un numero");
                n = Console.ReadLine();
                esNumero = int.TryParse(n, out valor);
            }
            while (!esNumero);
            
            for (int i = 1; i < 11; i++)
            {
                n2 = i * valor;
                Console.WriteLine(valor + " x " + i + " = " + n2);
            }
            Console.ReadKey();
        }
    }
}
