using System;
using NLayer.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Net.Configuration;

namespace NLayer.Forms
{
    public partial class Form1 : Form
    {
        private ClienteServicio _cs;
        public Form1(ClienteServicio cs)
        {
            this._cs = cs;
            InitializeComponent();
        }

        #region Metodos
        private void CargarListadoTodos()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _cs.TraerClientes();
        }
        private void CargarListadoRegistro()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = _cs.TraerRegistro();
        }
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (ValidacionHelper.ValidarString(textBox1.Text) == ""|| ValidacionHelper.ValidarString(textBox2.Text) == "" || ValidacionHelper.ValidarString(textBox3.Text) == "")
            {
                msg = "Debe ingresar valores válidos en los campos";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }
        #endregion
        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargarListadoRegistro();
            this.CargarListadoTodos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    string nombre = textBox1.Text;
                    string apellido = textBox2.Text;
                    string direccion = textBox3.Text;
                    _cs.InsertarCliente(nombre, apellido, direccion);
                    MessageBox.Show("El cliente se ha dado de alta correctamente");
                    LimpiarCampos();
                    this.CargarListadoRegistro();
                    this.CargarListadoTodos();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error. \n" + ex.Message);
            }            
        }

        #endregion        
    }
}
