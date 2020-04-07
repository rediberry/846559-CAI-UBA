using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable;
            char variable_= '0';
            int numero;
            bool esNumero;
            bool esLetra;

            string[] vocales = { "a", "e", "i", "o", "u" };
            do
            {
                Console.WriteLine("ingrese un carácter válido  (vocales, consonantes, números)");
                variable = Console.ReadLine();
                
                esNumero = int.TryParse(variable, out numero);
                //si le ingresas mas de un caracter, captura el error y sigue pidiendo un caracter
                try
                {
                    variable_ = char.Parse(variable);                    
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                esLetra = char.IsLetter(variable_);

            }
            while (!esNumero && !esLetra);

            if (esNumero == true)
            {
                Console.WriteLine("Se trata de una cifra numérica!");
            }
            if (esLetra == true)
            {
                variable = variable.ToLower();
                if (Array.Exists(vocales, element => element == variable))
                {
                    Console.WriteLine("Se trata de una vocal!");
                }
                else Console.WriteLine("Se trata de una consonante!");
            }
            Console.ReadKey();

            
        }
    }
}
