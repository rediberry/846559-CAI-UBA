
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


        public List<Empleado> Empleados { get => _empleados; }
        public List<Alumno> Alumnos { get => _alumnos; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }

        // Punto B
        public bool TieneAlumnos { get => _alumnos.Count > 0; }
        public bool TieneEmpleados { get => _empleados.Count > 0; }


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
        public int TraerDos() => 2;

        public void AgregarAlumno(Alumno alumno)
        {
            if (this._alumnos.SingleOrDefault(x => x.Codigo == alumno.Codigo) != null)
                throw new Exception("El alumno ya existe");

            if (alumno.Edad < 18)
                throw new Exception("El alumno es menor");

            this._alumnos.Add(alumno);
        }

        public void AgregarAlumno(string nombre, string apellido, int codigo, DateTime fechaNac)
        {
            Alumno al = new Alumno(codigo, nombre, apellido, fechaNac);

            // podemos aprovechar las validaciones del otro método
            this.AgregarAlumno(al);
        }

        // PUNTO C
        public void AgregarEmpleado(string nombre, string apellido, int codigo, DateTime ingreso, string tipo, string apodo, double bruto)
        {
            Empleado empleado;

            // podemos hacer alguna validacion dentro del switch si es algo particular para cada tipo
            switch (tipo.ToUpper())
            {
                case "A":
                    empleado = new Directivo(codigo, nombre, apellido, ingreso, bruto); // PUNTO C
                    break;
                case "D":
                    empleado = new Docente(codigo, nombre, apellido, ingreso, bruto); // PUNTO C
                    break;
                case "B":
                    empleado = new Bedel(codigo, nombre, apellido, ingreso, bruto, apodo); // PUNTO C
                    break;
                default:
                    throw new Exception("Tipo inválido.");
            }

            // podemos hacer alguna validacion general ej. codigo
            if (this._empleados.SingleOrDefault(x => x.Legajo == empleado.Legajo) != null)
                throw new Exception("El legajo ya existe");

            this._empleados.Add(empleado);
        }

        // punto A
        public void EliminarAlumno(int c)
        {
            Alumno alumno = this._alumnos.SingleOrDefault(x => x.Codigo == c);

            // otra forma de buscar es iterar la lista y comparar el código, hacer las validaciones y borrar directamente

            if (alumno != null)
            {
                this._alumnos.Remove(alumno);
            }
            else
            {
                throw new Exception("El alumno no está registrado en esta facultad.");
            }
        }

        // punto A
        public void EliminarEmpleado(int c)
        {
            Empleado empleado = this._empleados.SingleOrDefault(x => x.Legajo == c);

            if (empleado != null)
            {
                if (empleado.Antiguedad > 5)
                    throw new Exception("El empleado es demasiado costoso como para despedirlo");
                else
                    this._empleados.Remove(empleado);
            }
            else
            {
                throw new Exception("El empleado ya no trabaja en esta facultad.");
            }
        }
    }
}