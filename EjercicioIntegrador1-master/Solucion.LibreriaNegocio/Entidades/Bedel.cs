﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.Entidades
{
    public class Bedel : Empleado
    {
        protected string _apodo;
        
        

        public string Apodo { get => _apodo; set => _apodo = value; }
        public Bedel(int cod, string nombre, string apellido, DateTime fechaIngreso, string apodo, int puntaje) : base(cod, nombre, apellido, fechaIngreso)
        {
            this._apodo = apodo;
        }

        public override string GetNombreCompleto()
        {
            return "Bedel " + this.Apodo;
        }

    }
}
