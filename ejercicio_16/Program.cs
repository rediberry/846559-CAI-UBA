using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            bool esNumero;
            int valor;
            string valor2;
            int digitos = 0;

            do
            {
                Console.WriteLine("Ingrese un numero");
                n = Console.ReadLine();
                esNumero = int.TryParse(n, out valor);
            }
            while (!esNumero);
            valor2 = valor.ToString();
            foreach (char item in valor2)
            {
                digitos++;
                
            }
            Console.WriteLine("Numero ingresado: " + valor + " - tiene " + digitos + " dígitos");
            Console.ReadKey();
        }
    }
}
