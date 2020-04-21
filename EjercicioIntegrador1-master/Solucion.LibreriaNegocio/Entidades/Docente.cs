using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Docente : Empleado
    {
        // PUNTO C
        public Docente(int cod, string nombre, string apellido, DateTime fechaIngreso, double bruto) : base(cod, nombre, apellido, fechaIngreso, bruto)
        {
        }

        public override string GetNombreCompleto()
        {
            return "Docente " + this.Apellido;
        }

    }
}
