using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        private string _nombre;

        public List<Lata> Latas { get => _latas; }
        public string Proveedor { get => _proveedor; set => _proveedor = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Dinero { get => _dinero; set => _dinero = value; }
        public bool Encendida { get => _encendida; set => _encendida = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Expendedora(string nombre, List<Lata> latas, string proveedor, int capacidad, double dinero)
        {
            this._nombre = nombre;
            this._latas = latas;
            this._proveedor = proveedor;
            this._capacidad = capacidad;
            this._dinero = dinero;            
        }
        public Expendedora(string nombre)
        {
            this._nombre = nombre;
            this._latas = new List<Lata>();            
        }

        public void AgregarLata(Lata lata)
        {
            if (this._latas.SingleOrDefault(x => x.Codigo != lata.Codigo) != null)
                throw new Exception("La lata no existe");
            
            this._latas.Add(lata);
        }
        public void AgregarLata(string codigo, string nombre, string sabor, double precio, double volumen)
        {
            Lata al = new Lata(codigo, nombre, sabor, precio, volumen);
            // podemos aprovechar las validaciones del otro método
            this.AgregarLata(al);
        }
        public Lata ExtraerLata(string nombre, double precio)
        {
            throw new NotImplementedException();
        }
        public string GetBalance()
        {
            throw new NotImplementedException();
        }
        public int GetCapacidadRestante()
        {
            throw new NotImplementedException();
        }
        public void EncenderMaquina()
        {
            Encendida = true;           
        }
        public bool EstaVacia()
        {
            throw new NotImplementedException();
        }
    }
}
