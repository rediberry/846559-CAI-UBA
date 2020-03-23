using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string palabra_reverso;
            Console.WriteLine("Ingrese una palabra para determinar si es un Palíndromo");
            palabra = Console.ReadLine();

            char[] array = palabra.ToCharArray();
            Array.Reverse(array);
            palabra_reverso = string.Join("", array);
            if (palabra == palabra_reverso)
            {
                Console.WriteLine("La palabra ingresada es un Palíndromo");
            }
            else Console.WriteLine("La palabra ingresada NO es un Palíndromo");

            Console.ReadKey();


        }
    }
}
