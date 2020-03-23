using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            bool esNumero;
            int valor;
            string cadenaInvertida = "";
            do
            {
                Console.WriteLine("Ingrese un número de 5 cifras");
                n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n, out valor);
            }
            while (!esNumero || valor < 10000 || valor > 99999);
            foreach (char letra in n)
            {
                cadenaInvertida = letra + cadenaInvertida;
            }
            Console.WriteLine("El número invertido es es " + cadenaInvertida);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
