using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class TipoPlazoFijo
    {
        private int _id;
        private double _tasa;
        private string _descripcion;

        public TipoPlazoFijo(double tasa, string descripcion)
        {
            this._descripcion = descripcion;
            this._tasa = tasa;
        }
        [DataMember]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        [DataMember]
        public double Tasa
        {
            get
            {
                return this._tasa;
            }
            set
            {
                this._tasa = value;
            }
        }
        [DataMember]
        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }
    }
}
