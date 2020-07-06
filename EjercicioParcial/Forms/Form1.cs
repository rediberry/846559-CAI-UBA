using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        private ServicioPlazoFijo _spf;
        public Form1(ServicioPlazoFijo spf)
        {
            this._spf = spf;
            InitializeComponent();
        }
        #region Metodos
        private void CargarListaPlazoFijo(List<PlazoFijo> lpf)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lpf;
            CalcularMontoTotal();
        }
        private void CalcularMontoTotal()
        {
            textBox1.Text = Math.Round(this._spf.ObtenerMontoTotal(),2).ToString();
        }
        private void TraerTasaInteres()
        {
            string plazofijoweb = "40.00";
            string plazofijouva = "02.00";

            if (int.Parse(comboBox1.SelectedIndex.ToString()) == 0)
            {
                textBox2.Text = plazofijoweb;
            }
            else if (int.Parse(comboBox1.SelectedIndex.ToString()) == 1)
            {
                textBox2.Text = plazofijouva;
            }
            else
            {
                textBox2.Text = null;
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if(ValidacionHelper.ValidarDouble(textBox3.Text) == -1 || ValidacionHelper.ValidarInt(textBox4.Text) == -1)
            {
                msg = "Debe ingresar valores validos en los campos capital a invertir y dias.";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }
        private int ObtenerTipo()
        {
            int tipo;
            if (int.Parse(comboBox1.SelectedIndex.ToString()) == 0)
            {
                tipo = 1;
            }
            else tipo = 2;            
            return tipo;
        }
        private void LimpiarCampos()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();            
        }
        #endregion
        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListaPlazoFijo(this._spf.TraerListado());
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Enabled = false;            
        }
        private void Form1_FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraerTasaInteres();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    double tasa = Convert.ToDouble(textBox2.Text);
                    double capitalinicial = Convert.ToDouble(textBox3.Text);
                    int dias = Convert.ToInt32(textBox4.Text);
                    textBox5.Text = "$" + Math.Round(this._spf.ObtenerInteresARecibir(tasa, capitalinicial, dias),2).ToString();
                    textBox6.Text = "$" + Math.Round(this._spf.ObtenerMontoFinal(tasa, capitalinicial, dias),2).ToString(); ;
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
                    double tasa = Convert.ToDouble(textBox2.Text);
                    double capitalinicial = Convert.ToDouble(textBox3.Text);
                    int dias = Convert.ToInt32(textBox4.Text);
                    string usuario = ConfigurationManager.AppSettings["Registro"];
                    int tipo = ObtenerTipo();
                    this._spf.AltaPlazoFijo(tipo, dias, capitalinicial, tasa, usuario);
                    MessageBox.Show("El Plazo Fijo se dió de alta exitosamente");
                    CargarListaPlazoFijo(this._spf.TraerListado());
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
