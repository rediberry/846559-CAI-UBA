using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_19
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            int[] resultado = Frase.PalabrasCaracteres(frase);
            Console.WriteLine("La frase tiene {0} palabras", resultado[0]);
            Console.WriteLine("La frase tiene {0} caracteres", resultado[1]);
            Console.ReadKey();
        }
    }
}
