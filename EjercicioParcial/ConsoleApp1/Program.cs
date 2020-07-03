using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicioPlazoFijo spf = new ServicioPlazoFijo();
            spf.AltaPlazoFijo(2, 30, 20000, 40, "846559");            
            List<PlazoFijo> lpf = spf.TraerListado();
            foreach (PlazoFijo p in lpf)
            {
                Console.WriteLine("ok");
            }
            Console.ReadKey();
        }
    }
}
