using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioPlazoFijo
    {
        private PlazoFijoMapper mapper;

        public ServicioPlazoFijo()
        {
            mapper = new PlazoFijoMapper();
        }
        public List<PlazoFijo> TraerListado()
        {
            List<PlazoFijo> listplazofijo = mapper.TraerTodos();
            return listplazofijo;
        }
        public ResultadoTransaccion AltaPlazoFijo(int tipo, int dias, double capitalinicial, double tasa, string usuario)
        {
            PlazoFijo plazofijonuevo = new PlazoFijo(tipo, dias, capitalinicial, tasa, usuario);            
            ResultadoTransaccion resultado = mapper.Insert(plazofijonuevo);
            return resultado;
        }
        public double ObtenerMontoTotal()
        {
            double montototal = 0;
            Operador operador = new Operador(mapper.TraerTodos());
            foreach (PlazoFijo pf in operador.Listplazofijo)
            {
                montototal += pf.CapitalInicial;
            }
            return montototal;
        }

    }
}
