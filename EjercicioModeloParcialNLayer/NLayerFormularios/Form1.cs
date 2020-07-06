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
            lstTipoPrestamos.DataSource = null;
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
            textBox1.Text = "$ " + this._prestamoServicio.ObtenerComision().ToString();
        }
        private void TraerLineayTNA()
        {
            string prestamoSubsidiadotxt = "Prestamo Subsidiado";
            string prestamoSubsidiado = "25.50";
            string prestamoPersonaltxt = "Prestamo Personal";
            string prestamoPersonal = "50.00";
            string prestamoRefinanciaciontxt = "Prestamo Refinanciación";
            string prestamoRefinanciacion = "60.00";

            if (int.Parse(lstTipoPrestamos.SelectedIndex.ToString()) == 0)
            {
                textBox5.Text = prestamoSubsidiadotxt;
                textBox6.Text = prestamoSubsidiado;
            }
            else if (int.Parse(lstTipoPrestamos.SelectedIndex.ToString()) == 1)
            {
                textBox5.Text = prestamoPersonaltxt;
                textBox6.Text = prestamoPersonal;
            }
            else if (int.Parse(lstTipoPrestamos.SelectedIndex.ToString()) == 2)
            {
                textBox5.Text = prestamoRefinanciaciontxt;
                textBox6.Text = prestamoRefinanciacion;
            }
            else
            {
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (ValidacionHelper.ValidarDouble(textBox7.Text) == -1 || ValidacionHelper.ValidarInt(textBox8.Text) == -1)
            {
                msg = "Debe ingresar valores validos en los campos Monto y Plazo (meses).";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }
        private void LimpiarCampos()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            lstTipoPrestamos.ClearSelected();
        }
        #endregion
        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(this._lineasServicio.TraerTipoPrestamo());
            CargarListaPrestamos(this._prestamoServicio.TraerPrestamo());
            lstTipoPrestamos.ClearSelected();            
        }
        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraerLineayTNA();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    double tna = Convert.ToDouble(textBox6.Text);
                    double monto = Convert.ToDouble(textBox7.Text);
                    int plazo = Convert.ToInt32(textBox8.Text);
                    textBox2.Text = "$" + Math.Round(this._prestamoServicio.ObtenerCuotaCapital(tna, monto, plazo), 2).ToString();
                    textBox3.Text = "$" + Math.Round(this._prestamoServicio.ObtenerCuotaInteres(tna, monto, plazo), 2).ToString(); 
                    textBox4.Text = Math.Round(this._prestamoServicio.ObtenerCuotaTotal(tna, monto, plazo), 2).ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    double tna = Convert.ToDouble(textBox6.Text);
                    double monto = Convert.ToDouble(textBox7.Text);
                    int plazo = Convert.ToInt32(textBox8.Text);
                    string linea = textBox5.Text;
                    double cuota = Convert.ToDouble(textBox4.Text);                    
                    this._prestamoServicio.AltaPrestamo(linea, tna, plazo, monto, cuota);
                    MessageBox.Show("El Prestamo se dió de alta exitosamente");
                    CargarListaPrestamos(this._prestamoServicio.TraerPrestamo());
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }
        }

        #endregion


    }
}
