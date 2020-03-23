using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int num_reg;
            bool esNumero;

            do
            {
                Console.WriteLine("ingrese los 3 ultimos digitos de su registro");
                n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n, out num_reg);
            }
            while (!esNumero);
            Console.WriteLine("El numero de registro ingresado es " + num_reg);

            if (num_reg < 100)
            {
                Console.WriteLine("Por ser menor a 100, se incrementará en 100 a los efectos del programa");
                num_reg = num_reg + 100;
            }
            Console.ReadKey();
            for (int i = 1; i < num_reg + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " – FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " – Foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " – Bar");
                }
                else Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
