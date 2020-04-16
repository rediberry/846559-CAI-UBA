using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    class Empleado : Persona
    {
        public Empleado(string nom, string ape, double sueld)
        {
            
            this._nombre = nom;
            this._apellido = ape;
            this._sueldo = sueld;
        }

    }
}
