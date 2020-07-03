using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this._spf = new ServicioPlazoFijo();
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
            textBox1.Text = this._spf.ObtenerMontoTotal().ToString();
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
            //comboBox1.Text
        }

        #endregion


    }
}
