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
        private string _linea;
        private double _tna;
        public TipoPrestamo(string linea, double tna)
        {
            this._linea = linea;
            this._tna = tna;
        }
        [DataMember]
        public string Linea 
        {
            get
            {
                return this._linea;
            }
            set
            {
                this._linea= value;
            }
        }
        [DataMember]
        public double TNA 
        {
            get
            {
                return this._tna;
            }
            set
            {
                this._tna = value;
            }
        }
        public override string ToString()
        {
            return this._linea + " -" + " TNA " + this._tna + "%";
        }
    }
}
