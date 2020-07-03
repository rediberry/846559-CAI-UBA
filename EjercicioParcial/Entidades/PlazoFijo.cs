using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class PlazoFijo
    {
        private int _id;
        private int _tipo;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;
        private double _interes;
        private double _montoFinal;
        private string _usuario;

        public PlazoFijo(int tipo, int dias, double capitalinicial, double tasa, string usuario)
        {
            this._tipo = tipo;
            this._dias = dias;
            this._capitalInicial = capitalinicial;
            this._tasa = tasa;
            this._interes = (((tasa / 365 * dias) * capitalinicial) / 100);
            this._montoFinal = capitalinicial + this._interes;
            this._usuario = usuario;
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
        public int Tipo
        {
            get
            {
                return this._tipo;
            }
            set
            {
                this._tipo = value;
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
        public int Dias
        {
            get
            {
                return this._dias;
            }
            set
            {
                this._dias = value;
            }
        }
        [DataMember]
        public double CapitalInicial
        {
            get
            {
                return this._capitalInicial;
            }
            set
            {
                this._capitalInicial = value;
            }
        }
        [DataMember]
        public double Interes
        {
            get
            {
                return this._interes;
            }
            set
            {
                this._interes = value;
            }
        }
        [DataMember]
        public double MontoFinal
        {
            get
            {
                return this._montoFinal;
            }
            set
            {
                this._montoFinal = value;
            }
        }
        [DataMember]
        public string Usuario
        {
            get
            {
                return this._usuario;
            }
            set
            {
                this._usuario = value;
            }
        }
        
        public override string ToString()
        {
            string descripcion;
            if (this._tipo == 1)
            {
                descripcion = "Plazo Fijo Web";
            }
            else
            {
                descripcion = "Plazo Fijo UVA";
            }
            return this._id + ") Plazo " + this._dias + " días, Cap. inic. $ " + this._capitalInicial + " Interes $ " + this._interes + " - " + descripcion;

        }
    }
}
