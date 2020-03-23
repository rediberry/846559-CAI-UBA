using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int num_reg;
            bool esNumero;
            int cont = 0;
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
            for (int i = 1; i < num_reg+1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                    
                if (cont <= 2 && i % 3 == 0)
                {
                   Console.WriteLine(i + " - Es primo y divisible por 3");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Es divisible por 3");
                }
                else if (cont <= 2)
                {
                    Console.WriteLine(i + " - Es primo");
                }
                else Console.WriteLine(i);

                cont = 0;
                              
            }
                       
            Console.ReadKey();
            Console.Clear();
        }
    }
}
