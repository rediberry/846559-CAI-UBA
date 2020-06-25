using NLayerDatos;
using NLayerEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNegocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }

        public int InsertarCliente(string nombre, string apellido, string direccion)
        {
            Cliente cliente = new Cliente();
            cliente.Ape = apellido;
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;

            TransactionResult resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);


        }

        internal bool Existe(int idCliente)
        {
            List<Cliente> lst = TraerClientes();

            foreach (Cliente c in lst)
            {
                if (c.id == c.id)
                    return true;
            }

            return false;
        }
    }
}
