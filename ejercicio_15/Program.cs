using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            string clave;
            int intentos = 3;

            Console.WriteLine("Ingrese su usuario");
            user = Console.ReadLine();

            do
            {
                Console.WriteLine(user + " Ingrese su contraseña");
                clave = Console.ReadLine();
                if (clave == user)
                {
                    Console.WriteLine("Bienvenid@ " + user);
                }
                else Console.WriteLine("Acceso denegado. La contraseña no es correcta");
                intentos--;


            }
            while (intentos != 0 && clave != user);
            if (intentos == 0)
            {
                Console.WriteLine("CLAVE BLOQUEADA");
            }
            Console.ReadKey();
        }
    }
}
