using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerEntidades
{
    [DataContract]
    public class TipoPrestamo
    {
        [DataMember]
        public string Linea { get; set; }
        [DataMember]
        public double TNA { get; set; }
    }
}
