using NLayerEntidades;
using NLayerNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CuentaServicio servicio = new CuentaServicio();

                Cuenta c = servicio.AbrirCuenta("Caja ahorro en Bitcoins", 60);

                Console.WriteLine("Alta cuenta " + c);

                // try catch acá - no tiene feedback
                servicio.ModificarSaldo(c.id, 200);

                Console.WriteLine("Saldo Modificado");

                c = servicio.Traer(60);

                Console.WriteLine("Nuevo estado cuenta: " + c);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
