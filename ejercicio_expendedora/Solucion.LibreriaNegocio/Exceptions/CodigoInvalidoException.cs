using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.Exceptions
{
    public class CodigoInvalidoException : ApplicationException
    {
        private string _mensaje = "";

        public CodigoInvalidoException(string mensaje)
        {
            _mensaje = mensaje;
        }

        public override string Message
        {
            get
            {
                return string.Format("{0}", _mensaje);
            }
        }
    }
}
