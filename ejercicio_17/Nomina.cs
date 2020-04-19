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

        public bool TieneEmpleados { get => _empleados.Count > 0; }

        public List<Empleado> Empleados { get => _empleados; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public void AgregarEmpleado(string nombre, string apellido, double sueldo)
        {
            Empleado al = new Empleado(nombre, apellido, sueldo);

            this.Empleados.Add(al);
        }
        public void EliminarEmpleado(string apellido)
        {
            foreach (Empleado e in this._empleados)
            {
                if (apellido == e.Apellido)
                {
                    this.Empleados.Remove(e);
                    break;
                }
            }
        }

        public Nomina(string nombre)
        {
           this._nombre = nombre;
           this._empleados = new List<Empleado>();

        }

        public void GetEmpleados()
        {
           foreach (Empleado e in this.Empleados)
           {
              Console.WriteLine(e);
           }
        }
        public void ObtenerEmpleadoCaro()
        {       
            double maxSueldo = double.MinValue;
            foreach (Empleado e in this.Empleados)
            {
                if (e.Sueldo > maxSueldo)
                {
                    maxSueldo = e.Sueldo;
                }
            }
            foreach (Empleado e in this._empleados)
            {
                if (maxSueldo == e.Sueldo)
                {
                    Console.WriteLine(e.GetNombreCompleto2());
                    break;
                }
            }
        }

    }
}
        
        






    


