using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.LibreriaExceptions
{
    public class LibreriaExceptions : Exception
    {
        public void capacidadInsuficienteException()
        {
            throw new NotImplementedException();
        }

        public void DineroInsuficienteException(string message) 
        {
            throw new NotImplementedException();
        }

        public void SinStockException(string message, Exception inner) 
        {
            throw new NotImplementedException();
        }
        public void CodigoInvalidoException(string message, Exception inner)
        {
            throw new NotImplementedException();
        }
    }
}
