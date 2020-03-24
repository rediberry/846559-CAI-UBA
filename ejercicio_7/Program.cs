using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string n;
            bool esNumero;
            int valor2;
            string n2;
            int valor3;
            string n3;
            int valor4;
            string n4;
            int valor5;
            string n5;

            do
            {
                Console.WriteLine("Ingrese el primer número");
                n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n, out valor);
            }
            while (!esNumero);
            Console.WriteLine("El primer número Ingresado es " + n);
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese el segundo número");
                n2 = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n2, out valor2);
            }
            while (!esNumero);
            Console.WriteLine("El segundo número Ingresado es " + n2);
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese el tercer número");
                n3 = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n3, out valor3);
            }
            while (!esNumero);
            Console.WriteLine("El tercer número Ingresado es " + n3);
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese el cuarto número");
                n4 = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n4, out valor4);
            }
            while (!esNumero);
            Console.WriteLine("El cuarto número Ingresado es " + n4);
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese el quinto número");
                n5 = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n5, out valor5);
            }
            while (!esNumero);
            Console.WriteLine("El quinto número Ingresado es " + n5);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Los 5 números ingresados son " + n + "; " + n2 + "; " + n3 + "; " + n4 + "; " + n5);

            int[] myNumbers = { valor, valor2, valor3, valor4, valor5 };
            Array.Sort(myNumbers);

            Console.WriteLine("el número más chico es " + myNumbers[0]);
            Console.WriteLine("el número del medio es " + myNumbers[2]);
            Console.WriteLine("el número más grande es " + myNumbers[4]);

            Console.ReadKey();
        }
    }
}
