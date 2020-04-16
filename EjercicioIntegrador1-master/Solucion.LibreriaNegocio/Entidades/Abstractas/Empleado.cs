﻿using Solucion.LibreriaNegocio.Entidades;
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
        private int _puntaje;

        public int Puntaje { get => _puntaje; set => _puntaje = value; }
        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }
        public int Legajo { get => _legajo; set => _legajo = value; }
        public Salario UltimoSalario { get => _ultimoSalario; set => _ultimoSalario = value; }


        public override string GetNombreCompleto()
        {
            return this.Apellido;
        }

        public override string GetCredencial()
        {
            string ficha = string.Format("Empleado {0} - {1} - Puntaje {2}", this.Legajo, GetNombreCompleto(), this.Puntaje);
            
            return ficha;
        }

        public Empleado(int cod, string nombre, string apellido, DateTime fechaIngreso)
        {
            this.Legajo = cod;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._fechaIngreso = fechaIngreso;
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
