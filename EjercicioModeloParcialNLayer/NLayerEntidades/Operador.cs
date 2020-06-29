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
        public double Comision { get; set; }
        [DataMember]
        public double PorcentajeComision { get; set; }
    }
}
