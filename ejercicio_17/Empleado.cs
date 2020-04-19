using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    class Empleado : Persona
    {
        private double _sueldo;
        public double Sueldo { get => _sueldo; set => _sueldo = value; }
        public Empleado(string nom, string ape, double sueld)
        {
            
            this._nombre = nom;
            this._apellido = ape;
            this._sueldo = sueld;            
        }
        public string GetNombreCompleto2()
        {
            return string.Format("{0}, {1}, {2}", this._apellido, this._nombre, this._sueldo);
        }
    }
}
