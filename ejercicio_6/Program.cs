using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
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

            do
            {
                Console.WriteLine("Ingrese el primer Valor Entero");
                n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n, out valor);
            }
            while (!esNumero);
            Console.WriteLine("El primer Valor Ingresado es " + n);
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("Ingrese el segundo Valor Entero");
                n2 = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n2, out valor2);
            }
            while (!esNumero);
            Console.WriteLine("El segundo Valor Ingresado es " + n2);
            Console.ReadKey();
            Console.Clear();

            int resultado = (valor + valor2) * (valor - valor2);
            Console.WriteLine("el resultado de la operación aritmetica (a+b)*(a-b) es " + resultado);
            Console.ReadKey();
        }
    }
}
