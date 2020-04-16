using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Docente : Empleado
    {
        

        

        public Docente(int cod, string nombre, string apellido, DateTime fechaIngreso, int puntaje) : base(cod,nombre,apellido,fechaIngreso)
        {
        }

        public override string GetNombreCompleto()
        {
            return "Docente " + this.Apellido;
        }

        /*public int GetPuntaje()
        {
            Console.WriteLine("Su puntaje es {0}", Puntaje);
        }*/
    }
}
