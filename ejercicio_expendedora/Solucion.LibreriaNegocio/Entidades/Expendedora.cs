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

        public List<Lata> Latas { get => _latas; }
        public string Proveedor { get => _proveedor; set => _proveedor = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Dinero { get => _dinero; set => _dinero = value; }
        public bool Encendida { get => _encendida; set => _encendida = value; }

        public Expendedora(List<Lata> latas, string proveedor, int capacidad, double dinero)
        {
            this._latas = latas;
            this._proveedor = proveedor;
            this._capacidad = capacidad;
            this._dinero = dinero;            
        }

        public void AgregarLata(Lata lata)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        public bool EstaVacia()
        {
            throw new NotImplementedException();
        }
    }
}
