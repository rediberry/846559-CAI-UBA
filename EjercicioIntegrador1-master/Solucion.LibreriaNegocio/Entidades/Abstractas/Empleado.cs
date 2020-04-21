using Solucion.LibreriaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class Empleado : Persona
    {
        private int _legajo;
        private Salario _ultimoSalario;
        private DateTime _fechaIngreso;

        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }
        public int Legajo { get => _legajo; set => _legajo = value; }
        public Salario UltimoSalario { get => _ultimoSalario; set => _ultimoSalario = value; }


        public override string GetNombreCompleto()
        {
            return this.Apellido;
        }

        public override string GetCredencial()
        {
            // PUNTO C - para q muestre el salario
            string ficha = string.Format("Empleado {0} - {1} salario $ {2}", this.Legajo, GetNombreCompleto(), this._ultimoSalario.GetSalarioNeto().ToString());

            return ficha;
        }

        public Empleado() { }
        // PUNTO C
        public Empleado(int cod, string nombre,
            string apellido, DateTime fechaIngreso, double bruto)
        {
            this.Legajo = cod;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._fechaIngreso = fechaIngreso;
            this._ultimoSalario = new Salario(bruto); // PUNTO C
        }


        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Empleado))
            {
                return false;
            }
            return (this.Legajo == ((Empleado)obj).Legajo);

        }

    }
}