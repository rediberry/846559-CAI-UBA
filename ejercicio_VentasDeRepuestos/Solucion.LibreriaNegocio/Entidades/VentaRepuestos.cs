using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_VentasDeRepuestos
{
    public class VentaRepuestos
    {
        private string _nombrecomercio;
        private string _direccion;        
        private List<Repuesto> _listaProductos;
        public VentaRepuestos()
        {
            this._listaProductos = new List<Repuesto>();
        }

        public List<Categoria> TraerCategorias()
        {
            List<Categoria> listaTemporal = new List<Categoria>();

            foreach (Repuesto r in _listaProductos)
            {
                Categoria existente = null;
                foreach (Categoria c in listaTemporal)
                {
                    if (c.Codigo == r.Categoria.Codigo)
                    {
                        existente = c;
                    }
                }

                if (existente == null)
                    listaTemporal.Add(r.Categoria);

            }

            return listaTemporal;
        }
        public void AgregarRepuesto(Repuesto r, Categoria c)
        {
            r.Categoria = c;
            foreach (Repuesto rep in _listaProductos)
            {
                if (!rep.Equals(r))
                {
                    //this._listaProductos.Add(r);
                    this._listaProductos.Remove(r);
                    break;
                }

            }


        }

        private Categoria ExisteCategoria(int codCategoria)
        {
            Categoria resultado = null;
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Categoria.Codigo == codCategoria)
                    resultado = r.Categoria;
            }

            return resultado;
        }

        public void AgregarRepuesto(Repuesto r, int codCat, string nombreCat)
        {

            Categoria categoriaExistente = ExisteCategoria(codCat);

            if (categoriaExistente == null)
                r.Categoria = new Categoria(codCat, nombreCat);
            else
                r.Categoria = categoriaExistente;

            this._listaProductos.Add(r);
        }
        public void QuitarRepuesto(int cod)
        {
            // ToDo
        }
        public void ModificarPrecio(int cod, double precio)
        {
            foreach (Repuesto r in this._listaProductos)
            {
                if (cod == r.Codigo)
                {
                    r.Precio = precio;
                }
            }
        }
        public void AgregarStock(int codigo, int cantidad)
        {
            // ToDo
        }
        public void QuitarStock(int codigo, int cantidad)
        {
            // ToDo
        }
        public List<Repuesto> TraerPorCategoria(int cod)
        {
            // ToDo
            throw new NotImplementedException();
        }

    }
}