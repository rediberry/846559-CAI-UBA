using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidades;
using NLayer.Negocio;

namespace NLayer.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClienteServicio servicio = new ClienteServicio();

                int cod = servicio.InsertarCliente("Liu", "Kang", "China Town");

                Console.WriteLine("Se ha insertado el cliente nro " + cod.ToString());

                List<Cliente> lst = servicio.TraerClientes();

                foreach (Cliente c in lst)
                {
                    Console.WriteLine(c);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        
        }
    }
}
