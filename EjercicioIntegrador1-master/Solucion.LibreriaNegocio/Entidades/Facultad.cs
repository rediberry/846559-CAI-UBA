﻿
using Solucion.LibreriaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Facultad
    {
        private List<Empleado> _empleados;
        private List<Alumno> _alumnos;
        private string _nombre;
        private int _cantidadSedes;
    

        public List<Empleado> Empleados { get => _empleados;  }
        public List<Alumno> Alumnos { get => _alumnos; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }

        // public string Nombre { get; set; } NO


        public Facultad(string nombre)
        {
            this._nombre = nombre;
            this._empleados = new List<Empleado>();
            this._alumnos = new List<Alumno>();
        }



        public int TraerUno()
        {
            return 1;
        }
        public int TraerDos() =>  2;

        public void AgregarAlumno(Alumno alumno)
        {
            if (this.Alumnos.SingleOrDefault(x => x.Codigo == alumno.Codigo) != null)
                throw new Exception("El alumno ya existe");

            if(alumno.Edad < 18)
                throw new Exception("El alumno es menor");

            this.Alumnos.Add(alumno);
        }

        public void AgregarAlumno(string nombre, string apellido, int codigo, DateTime fechaNac)
        {
            Alumno al = new Alumno(codigo, nombre, apellido, fechaNac);

            // podemos aprovechar las validaciones del otro método
            this.AgregarAlumno(al);
        }

        public void AgregarEmpleado(string nombre, string apellido, int codigo, DateTime ingreso, string tipo, string apodo, int puntaje)
        {
            Empleado empleado;

            // podemos hacer alguna validacion dentro del switch si es algo particular para cada tipo
            switch (tipo.ToUpper())
            {
                case "A":
                    empleado = new Directivo(codigo, nombre, apellido, ingreso, puntaje);
                    break;
                case "D":
                    empleado = new Docente(codigo, nombre, apellido, ingreso, puntaje);
                    break;
                case "B":
                    empleado = new Bedel(codigo, nombre, apellido, ingreso, apodo, puntaje);
                    break;
                default:
                    throw new Exception("Tipo inválido.");
            }

            // podemos hacer alguna validacion general ej. codigo
            if (this.Empleados.SingleOrDefault(x => x.Legajo == empleado.Legajo) != null)
                throw new Exception("El legajo ya existe");

            this.Empleados.Add(empleado);
        }
        public void EliminarEmpleado(int legajo)
        {
            try
            {
                foreach (Empleado a in Empleados)
                {
                    if (a.Legajo == legajo)
                    {
                        Empleados.Remove(a);
                    }
                    else throw new Exception("El legajo no existe");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void EliminarAlumno(int codigo)
        {
            try
            {
                foreach (Alumno a in Alumnos)
                {
                    if (a.Codigo == codigo)
                    {
                        Alumnos.Remove(a);
                    }
                    else throw new Exception("El codigo no existe");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
