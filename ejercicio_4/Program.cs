using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2;
            int aux1 = 0, aux2 = 0;
            Console.WriteLine("ingrese la primera palabra");
            palabra1 = Console.ReadLine();
            Console.WriteLine("ingrese la segunda palabra");
            palabra2 = Console.ReadLine();

            if (palabra1.Length == palabra2.Length)
            {
                for (int i = 0; i < palabra1.Length; i++)
                {
                    for (int j = 0; j < palabra2.Length; j++)
                    {
                        if (palabra1[i] == palabra2[j])
                            aux1++;
                        if (palabra1[i] == palabra1[j])
                            aux2++;
                    }
                }
                if (aux1 != aux2)
                {
                    Console.WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
                }
                else
                    Console.WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else Console.WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            Console.ReadKey();

        
            
                        
        }
    }
}
