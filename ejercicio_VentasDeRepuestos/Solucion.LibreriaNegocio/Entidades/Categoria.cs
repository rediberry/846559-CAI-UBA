using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_VentasDeRepuestos
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Categoria(int codCat, string nombreCat)
        {
            this._codigo = codCat;
            this._nombre = nombreCat;
        }
        public override bool Equals(object obj)
        {
            Categoria obj2 = (Categoria)obj;

            bool resultado = (this.Codigo == obj2.Codigo
                && this.Nombre == obj2.Nombre);

            return resultado;
        }
    }
}
