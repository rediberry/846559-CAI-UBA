using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    class VentaRepuestos
    {
        private string _nombrecomercio;
        private string _direccion;        
        private List<Repuesto> _listaProductos;

        public string NombreComercio { get => _nombrecomercio; set => _nombrecomercio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public List<Repuesto> ListaProductos { get => _listaProductos; }

        public void AgregarRepuesto(Repuesto r1)
        {
            throw new NotImplementedException();
        }
        public void QuitarRepuesto(int a)
        {
            throw new NotImplementedException();
        }
        public void ModificarPrecio(int a, double b)
        {
            throw new NotImplementedException();
        }
        public void AgregarStock(int a, int b)
        {
            throw new NotImplementedException();
        }
        public void QuitarStock(int a, int b)
        {
            throw new NotImplementedException();
        }
        public List<Repuesto> TraerPorCategoria(int a)
        {
            throw new NotImplementedException();
        }
    }
}
