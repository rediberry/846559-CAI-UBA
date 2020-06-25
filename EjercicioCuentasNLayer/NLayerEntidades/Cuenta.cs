using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace NLayerEntidades
{
    [DataContract]
    public class Cuenta
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int NroCuenta { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public float Saldo { get; set; }
        [DataMember]
        public DateTime FechaApertura { get; set; }
        [DataMember]
        public DateTime FechaModificacion { get; set; }
        [DataMember]
        public bool Activo { get; set; }
        [DataMember]
        public int idCliente { get; set; }

        public override string ToString()
        {
            return string.Format("{3}) Cuenta nro {0} / {1} Saldo $ {2}", this.NroCuenta, this.Descripcion, this.Saldo.ToString("0.00"), this.id);
        }
    }
}
