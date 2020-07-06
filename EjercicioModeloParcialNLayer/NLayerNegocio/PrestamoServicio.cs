using NLayerDatos;
using NLayerEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public List<Prestamo> TraerPrestamo()
        {
            List<Prestamo> resultadoList = mapper.Traer();            
            return resultadoList;
        }
        public ResultadoTransaccion AltaPrestamo(string linea, double tna, int plazo, double monto, double cuota)
        {            
                Prestamo p = new Prestamo();                
                p.Linea = linea;
                p.Monto = monto;
                p.Plazo = plazo;
                p.TNA = tna;
                p.Cuota = cuota;
                
                ResultadoTransaccion t = mapper.Insert(p);

                if (t.IsOk)
                {
                    return t;
                }
                else
                {
                    throw new Exception("Error al dar de alta el prestamo. " + t.Error);
                }            
        }        
        public double ObtenerComision()
        {
            double comision = 0;
            Operador operador = new Operador(mapper.Traer());
            foreach (Prestamo p in operador.Prestamos)
            {
                comision += (p.Monto * (p.TNA / 100 / 12 * p.Plazo))/p.Plazo * operador.PorcentajeComision* p.Plazo;
            }
            return comision;
        }
        public double ObtenerCuotaCapital(double tna, double monto, int plazo)
        {
            double cuotacapital = monto / plazo;
            return cuotacapital;
        }
        public double ObtenerCuotaInteres(double tna, double monto, int plazo)
        {
            double cuotainteres = monto * (tna/100/12*plazo)/plazo;
            return cuotainteres;
        }
        public double ObtenerCuotaTotal(double tna, double monto, int plazo)
        {
            double cuotatotal = ObtenerCuotaCapital(tna,monto,plazo) + ObtenerCuotaInteres(tna, monto, plazo);
            return cuotatotal;
        }
    }
}
