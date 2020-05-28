using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen; //asumimos que siempre son ml (mililitros)

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Volumen { get => _volumen; set => _volumen = value; }

        public Lata(string codigo, string nombre, string sabor, double precio, double volumen)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._sabor = sabor;
            this._precio = precio;
            this._volumen = volumen;
        }

        private double GetPrecioPorLitro()
        {
            double precioxlitro = Math.Round((1000 / _volumen) * _precio,2);
            return precioxlitro;
        }
        public override string ToString()
        {
            double precioxlitro = GetPrecioPorLitro();
            string descripcion = string.Format("{0} - {1} $ {2} / $/L {3}", this.Nombre, this.Sabor, this.Precio, precioxlitro);

            return descripcion;
        }

    }
}
