using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String fechastring;
            DateTime fecha_hoy = DateTime.Now;
            TimeSpan diferencia_fechas;           
            DateTime fecha;
            int dias;        

           
            do
            {
                Console.WriteLine("Ingrese una fecha válida");
                fechastring = Console.ReadLine();                
                

            } while (DateTime.TryParse(fechastring, out fecha) != true);
            diferencia_fechas = fecha_hoy - fecha;
            dias = diferencia_fechas.Days;

            Console.WriteLine("La diferencia entre la fecha ingresada y el día de hoy es " + dias + " día/s");
            Console.ReadKey();

            
        }
    }
}
