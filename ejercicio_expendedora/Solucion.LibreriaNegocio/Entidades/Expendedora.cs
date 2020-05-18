using System;
using System.Collections.Generic;
using Solucion.LibreriaNegocio.Exceptions;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (Regex.IsMatch(lata.Codigo.ToString().ToUpper(), @"CO1|CO2|SP1|SP2|FA1|FA2"))
            {
                this._latas.Add(lata);
            }
            else if (!Regex.IsMatch(lata.Codigo.ToString().ToLower(), @"CO1|CO2|SP1|SP2|FA1|FA2")) 
            {
                CodigoInvalidoException ex = new CodigoInvalidoException(string.Format("{0} no es un codigo válido", lata.Codigo));
                throw ex;
            }
        }
        public void AgregarLata(string codigo, string nombre, string sabor, double precio, double volumen)
        {
            Lata al = new Lata(codigo, nombre, sabor, precio, volumen);
            // podemos aprovechar las validaciones del otro método
            this.AgregarLata(al);
        }
        public Lata ExtraerLata(string nombre, double precio )
        {
            Lata lata = this._latas.SingleOrDefault(x => x.Codigo == nombre);            

            if (lata != null)
            {
                _dinero = _dinero + precio;
                return lata;                
            }
            else
            {
                throw new Exception("No hay stock de esa lata");  
            }
        }
        public string GetBalance()
        {
            return _dinero.ToString();
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
            if (_latas.Count > 0)
            {
                return true;
            }
            else return false;
        }
        public string GetMarca(string codigo)
        {
            string n = "";

            switch (codigo.ToUpper())
            {
                case "CO1":
                    n = "Coca Cola";
                    break;
                case "CO2":
                    n = "Coca Cola";
                    break;
                case "SP1":
                    n = "Sprite";
                    break;
                case "SP2":
                    n = "Sprite";
                    break;
                case "FA1":
                    n = "Fanta";
                    break;
                case "FA2":
                    n = "Fanta";
                    break;                
            }
            return n;                   
        } 
        public string GetSabor(string codigo)
        {
            string s = "";

            switch (codigo.ToUpper())
            {
                case "CO1":
                    s = "Regular";
                    break;
                case "CO2":
                    s = "Zero";
                    break;
                case "SP1":
                    s = "Regular";
                    break;
                case "SP2":
                    s = "Zero";
                    break;
                case "FA1":
                    s = "Regular";
                    break;
                case "FA2":
                    s = "Zero";
                    break;
            }
            return s;
        }
        public string ContarLatas(Expendedora expendedora)
        {
            int count = Latas.Count();
            return count.ToString();
        }
    }
}
