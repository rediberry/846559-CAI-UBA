using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Operador
    {
        private List<PlazoFijo> _listplazoFijo;
        private double _montoTotal;

        public Operador(List<PlazoFijo> lpf)
        {
            this._listplazoFijo = lpf;            
        }

        public List<PlazoFijo> Listplazofijo
        {
            get
            {
                return this._listplazoFijo;
            }
            set
            {
                this._listplazoFijo = value;
            }
        }
        public double Montototal
        {
            get
            {
                return this._montoTotal;
            }
            set
            {
                this._montoTotal = value;
            }
        }
    }
}
