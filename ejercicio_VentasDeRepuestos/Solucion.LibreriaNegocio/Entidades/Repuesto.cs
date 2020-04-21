using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_VentasDeRepuestos
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }

        public override string ToString()
        {
            return "[" + Codigo + "] " + Nombre;
        }
        public Repuesto(int codigo)
        {
            this._codigo = codigo;
        }

        public override bool Equals(object obj)
        {
            Repuesto objeto2 = (Repuesto)obj;

            bool resultado = (this.Codigo == objeto2.Codigo);

            return resultado;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}