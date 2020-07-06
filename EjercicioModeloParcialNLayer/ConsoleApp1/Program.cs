using System;
using System.Collections.Generic;
using NLayerEntidades;
using NLayerNegocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrestamoServicio ps = new PrestamoServicio();
            ps.AltaPrestamo("Prestamo Personal", 50, 12, 20000, 0);

        }
    }
}
