using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    class Nomina
    {
        private List<Empleado> _empleados;
        private string _nombre;
        
        public List<Empleado> Empleados { get => _empleados; }
        
        public string Nombre { get => _nombre; set => _nombre = value; }
       
        public void AgregarEmpleado(Empleado empleado)
        {
            this.Empleados.Add(empleado);
        }
        
        public void AgregarEmpleado(string nombre, string apellido, double sueldo)
        {
            Empleado al = new Empleado(nombre, apellido, sueldo);

            // podemos aprovechar las validaciones del otro método
            this.AgregarEmpleado(al);
        }
        
        public Nomina(string nombre)
        {
            this._nombre = nombre;
            this._empleados = new List<Empleado>();
            
        }

        public void GetEmpleados()
        {
            foreach (var element in this.Empleados)
            {
                Console.WriteLine(element);
            }
        }
        
    }
}

