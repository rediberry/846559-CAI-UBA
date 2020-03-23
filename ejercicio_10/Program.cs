using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_input;
            string nombre_apellido = "";
            int edad;
            Console.WriteLine("Ingrese Nombre, Apellido y Edad en cualquier orden");
            user_input = Console.ReadLine();
            string[] palabras = user_input.Split(' ');
            foreach (string word in palabras)
            {
                if (int.TryParse(word, out edad) == true)
                {
                    Console.WriteLine("EDAD: " + edad);
                }
                else nombre_apellido = nombre_apellido + " " + word;
            }
            Console.WriteLine("NOMBRE Y APELLIDO: " + nombre_apellido);

            Console.ReadKey();
        }
    }
}
