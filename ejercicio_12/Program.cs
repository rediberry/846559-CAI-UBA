using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool var;
            DateTime fecha1;
            DateTime fecha2;
            string n;
            TimeSpan dif;
            int años;
            int meses;
            int dias;
            int dias_rest;

            do
            {
                Console.WriteLine("Ingrese una fecha");
                n = Console.ReadLine();
                var = DateTime.TryParse(n, out fecha1);
            }
            while (var == false);
            do
            {
                Console.WriteLine("Ingrese otra fecha");
                n = Console.ReadLine();
                var = DateTime.TryParse(n, out fecha2);
            }
            while (var == false);
            dif = (fecha2 - fecha1);
            dias = Convert.ToInt32(dif.TotalDays);
            años = (dias) / 365;
            meses = (dias % 365) / 30;
            dias_rest = (dias % 365) % 30;

            Console.WriteLine("La diferencia es de "+años+" años"+", "+meses+" meses y "+dias_rest+" día/s");
            
            Console.ReadKey();
        }
    }
}
