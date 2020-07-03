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
        public Operador TraerPrestamo(int usuario)
        {
            List<Prestamo> resultadoList = mapper.Traer();
            Operador ResultadoOperador = new Operador(resultadoList);
            //ResultadoOperador.Prestamos = resultadoList;
            return ResultadoOperador;
        }
        public ResultadoTransaccion AltaPrestamo(string linea, double tna, int plazo, double monto, string usuario, int id)
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
                    return t;
                }
                else
                {
                    throw new Exception("Error al abrir la cuenta. " + t.Error);
                }            
        }
        public Prestamo Simular(string linea, double tna, int plazo, double monto, string usuario)
        {
            Prestamo p = new Prestamo();
            p.Linea = linea;
            p.Monto = monto;
            p.Plazo = plazo;
            p.TNA = tna;
            p.Usuario = usuario;

            return p;
        }
        public double ObtenerPorcentajeComision()
        {
            double comision = 0;
            Operador operador = new Operador(mapper.Traer());
            foreach (Prestamo p in operador.Prestamos)
            {
                comision += p.CuotaInteres * operador.PorcentajeComision;
            }
            return comision;
        }
    }
}
