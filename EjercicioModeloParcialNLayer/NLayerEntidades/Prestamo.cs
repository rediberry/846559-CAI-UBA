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
        public double CuotaCapital { get; set; }       
        
        [DataMember]
        public double CuotaInteres { get; set; }  
        
        [DataMember]
        public double Cuota { get; set; }
        
        public double CalcularInteres()
        {
            double interes = this.CuotaInteres * this.Plazo;
            return interes;
        }
        public override string ToString()
        {
            double Interes = this.Monto * (this.TNA / 100 / 12 * this.Plazo);
            return this.id + ") " + "Capital: $" + this.Monto + " - Plazo: " + this.Plazo + " meses" + " - Tipo: " + this.Linea + " - Interes: $" + Interes.ToString();
        }
    }
}
