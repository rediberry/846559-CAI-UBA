using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLayerEntidades;
using NLayerNegocio;

namespace NLayerFormularios
{
    public partial class Form1 : Form
    {
        private LineasPrestamoServicio _lineasServicio;
        private PrestamoServicio _prestamoServicio;
        public Form1(LineasPrestamoServicio ls, PrestamoServicio ps)
        {
            this._lineasServicio = ls;
            this._prestamoServicio = ps;
            InitializeComponent();
        }
        #region Métodos
        private void CargarTiposPrestamo(List<TipoPrestamo> listaLineasPrestamo)
        {
            lstPrestamos.DataSource = null;
            lstTipoPrestamos.DataSource = listaLineasPrestamo;
        }
        private void CargarListaPrestamos(List<Prestamo> prestamos)
        {
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = prestamos;
            CalcularComisionOperador();
        }
        private void CalcularComisionOperador()
        {
            textBox1.Text = this._prestamoServicio.ObtenerPorcentajeComision().ToString();
        }

        #endregion
        #region Eventos
        private void form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(this._lineasServicio.TraerTipoPrestamo());
            //CargarListaPrestamos(this._prestamoServicio.TraerPrestamo());
        }
        #endregion
    }
}
