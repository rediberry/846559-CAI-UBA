using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected double _sueldo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }

        public virtual string GetNombreCompletoySueldo()
        {
            return string.Format("{0}, {1}, ${2}", this._apellido, this._nombre, this._sueldo);
        }
    }
}
