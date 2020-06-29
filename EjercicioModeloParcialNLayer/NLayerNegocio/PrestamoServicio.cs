using NLayerDatos;
using NLayerEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerNegocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper mapper;
        public PrestamoServicio()
        {
            mapper = new PrestamoMapper();
        }
        public List<Prestamo> TraerPrestamo(int idCliente)
        {
            List<Prestamo> resultado = mapper.Traer(idCliente);
            return resultado;
        }
        public Prestamo AltaPrestamo(string linea, double tna, int plazo, double monto, string usuario, int id)
        {            
                Prestamo p = new Prestamo();
                p.id = id;
                p.Linea = linea;
                p.Monto = monto;
                p.Plazo = plazo;
                p.TNA = tna;
                p.Usuario = usuario; 
                
                ResultadoTransaccion t = mapper.Insert(p);

                if (t.IsOk)
                {
                    return p;
                }
                else
                {
                    throw new Exception("Error al abrir la cuenta. " + t.Error);
                }
            
            
        }
    }
}
