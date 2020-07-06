using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerEntidades
{
    [DataContract]
    public class Operador
    {
        [DataMember]
        public List<Prestamo> Prestamos { get; set; }
        [DataMember]
        public double Comision
        {
            get
            {
                double c = 0;
                foreach (Prestamo p in Prestamos)
                {
                    c += PorcentajeComision * (p.Monto * p.Plazo * (p.TNA/12) );
                }
                return c;
            }
        }
        [DataMember]
        public double PorcentajeComision { get; set; } = 0.15;

        public Operador(List<Prestamo> prestamosDelOperador)
        {
            this.Prestamos = prestamosDelOperador;
            this.PorcentajeComision = 0.15;
        }
    }
}
