using System;
using System.Collections.Generic;
using NLayerEntidades;
using NLayerDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNegocio
{
    public class LineasPrestamoServicio
    {
        private LineasPrestamoMapper mapper;

        public LineasPrestamoServicio()
        {
            mapper = new LineasPrestamoMapper();
        }
        public List<TipoPrestamo> TraerClientes()
        {
            List<TipoPrestamo> result = mapper.TraerTodos();
            return result;
        }
    }
    
}
