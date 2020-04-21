using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.Entidades
{
    public class Directivo : Empleado

    {// PUNTO C
        public Directivo(int cod, string nombre, string apellido, DateTime fechaIngreso, double bruto) : base(cod, nombre, apellido, fechaIngreso, bruto)
        {
        }

        public override string GetNombreCompleto()
        {
            return "SR. Director " + this._apellido;
        }
    }
}