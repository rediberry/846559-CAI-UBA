using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerEntidades
{
    [DataContract]
    public class Prestamo
    {
        [DataMember]
        public string Linea { get; set; }
        [DataMember]
        public double TNA { get; set; }
        [DataMember]
        public int Plazo { get; set; }
        [DataMember]
        public double Monto { get; set; }
        [DataMember]
        public string Usuario { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public double CuotaCapital
        {
            get
            {
                return Monto / Plazo;
            }
        }
        [DataMember]
        public double CuotaInteres
        {
            get
            {
                return CuotaCapital * (TNA / 12 / 100);
            }
        }
        [DataMember]
        public double Cuota
        {
            get
            {
                return CuotaCapital + CuotaInteres;
            }
        }
    }
}
