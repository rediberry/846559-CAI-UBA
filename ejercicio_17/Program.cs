using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string cargar = "SI";
            Nomina n = new Nomina("sistemas");
            while(cargar == "SI")
            {
                Console.WriteLine("Ingrese un nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese un apellido");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo");
                double sueldo = double.Parse(Console.ReadLine());
                n.AgregarEmpleado(nombre, apellido, sueldo);                
                Console.WriteLine("Desea Continuar la carga? SI / NO");
                cargar = Console.ReadLine();                
            }

            n.GetEmpleados();


            //Empleado caro = n.ObtenerEmpleadoMasCaro();
            Console.ReadKey();


        }
    }
}
