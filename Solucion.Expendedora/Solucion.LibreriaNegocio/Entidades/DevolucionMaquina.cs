using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.Entidades
{
    public class DevolucionMaquina //abstraccion que contempla el resultado de extraer lata
    {
        private Lata _lata;
        private double _cambio;

        public Lata Lata { get => _lata;  }
        public double Cambio { get => _cambio; set => _cambio = value; }

        public DevolucionMaquina(Lata lata, double cambio)
        {
            this._cambio = cambio;
            this._lata = lata;           
        }
        //la idea es que el metodo extraer tambien de vuelva un objeto de tipo DevolucionMaquina (es decir, un objeto lata y un objeto cambio)
    }
}
