using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solucion.LibreriaNegocio;
using Solucion.LibreriaNegocio.Entidades;
using Solucion.LibreriaNegocio.Exceptions;

namespace CapaPresentacion
{
    public partial class FormExpendedora : Form
    {
        #region "Atributos y constructor"
        Expendedora exp1 = new Expendedora("Expendedora CAI");
        public FormExpendedora()
        {
            InitializeComponent();
        }
        #endregion

        #region "Métodos"
        private void limpiarForm()
        {
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtVolumen.Clear();
            txtDinero.Clear();
        }
        private void CargarListaLatas(List<Lata> latas)
        {
            listLatas.DataSource = null;
            listLatas.DataSource = latas;

        }
        #endregion

        #region "Eventos"
        private void button2_Click(object sender, EventArgs e)
        {
            FormSaludoFinal f1 = new FormSaludoFinal();            
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEncender.Hide();
            btnSi.Hide();
            btnNo.Hide();
            btnListadoLatas.Show();
            btnInsertarLata.Show();
            btnExtraerLata.Show();
            btnVerStock.Show();
            btnVerBalance.Show();
            pictureBox1.Show();
            btnApagar.Show();

        }

        private void btnListadoLatas_Click(object sender, EventArgs e)
        {
            btnApagar.Enabled = false;
            btnExtraerLata.Enabled = false;
            btnInsertarLata.Enabled = false;
            btnVerStock.Enabled = false;
            btnVerBalance.Enabled = false;
            FormListadoLatasDisp f1 = new FormListadoLatasDisp();
            f1.ShowDialog();
            btnExtraerLata.Enabled = true;
            btnInsertarLata.Enabled = true;
            btnVerStock.Enabled = true;
            btnVerBalance.Enabled = true;
            btnApagar.Enabled = true;
        }

        private void FormExpendedora_Load(object sender, EventArgs e)
        {
            btnListadoLatas.Hide();
            btnInsertarLata.Hide();
            btnExtraerLata.Hide();
            btnVerStock.Hide();
            btnVerBalance.Hide();
            pictureBox1.Hide();
            lblCodigo.Hide();
            lblPrecio.Hide();
            lblVolumen.Hide();
            txtCodigo.Hide();
            txtPrecio.Hide();
            txtVolumen.Hide();
            lblListadoLatas.Hide();
            btnGuardar.Hide();
            btnRetirar.Hide();
            listLatas.Hide();
            btnVolver.Hide();
            lblCuentaLatas.Hide();
            lblBalance.Hide();
            lblDinero.Hide();
            txtDinero.Hide();
            btnVolverExtraer.Hide();
            btnVolverInsertar.Hide();
            btnApagar.Hide();
        }

        private void btnInsertarLata_Click(object sender, EventArgs e)
        {
            if (exp1.Latas.Count() < 7)
            {
                btnListadoLatas.Enabled = false;
                btnExtraerLata.Enabled = false;
                btnInsertarLata.Enabled = false;
                btnVerStock.Enabled = false;
                btnVerBalance.Enabled = false;
                btnApagar.Enabled = false;
                btnVolverInsertar.Show();
                lblListadoLatas.Show();
                lblCodigo.Show();
                lblPrecio.Show();
                lblVolumen.Show();
                txtCodigo.Show();
                txtPrecio.Show();
                txtVolumen.Show();
                btnGuardar.Show();
            }
            else if (exp1.Latas.Count() >= 7)
            {
                CapacidadInsuficienteException ex = new CapacidadInsuficienteException(string.Format("La {0} se encuentra llena", exp1.Nombre));
                MessageBox.Show(ex.Message);                
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {            
                try
                {
                    string c = txtCodigo.Text;
                    double p = Double.Parse(txtPrecio.Text);
                    double v = Double.Parse(txtVolumen.Text);
                    string n = exp1.GetMarca(c);
                    string s = exp1.GetSabor(c);

                    //generamos el objeto acá
                    Lata ll = new Lata(c, n, s, p, v);
                    exp1.AgregarLata(ll);
                    MessageBox.Show("La lata se inserto correctamente");
                    limpiarForm();
                    btnListadoLatas.Enabled = true;
                    btnExtraerLata.Enabled = true;
                    btnInsertarLata.Enabled = true;
                    btnVerStock.Enabled = true;
                    btnVerBalance.Enabled = true;
                    btnApagar.Enabled = true;
                    lblListadoLatas.Hide();
                    lblCodigo.Hide();
                    lblPrecio.Hide();
                    lblVolumen.Hide();
                    txtCodigo.Hide();
                    txtPrecio.Hide();
                    txtVolumen.Hide();
                    btnGuardar.Hide();
                    btnVolverInsertar.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");
                    limpiarForm();
                    btnInsertarLata.PerformClick();
                }            
        }
        
        private void btnVerStock_Click(object sender, EventArgs e)
        {
            if (exp1.EstaVacia())
            {
                btnListadoLatas.Enabled = false;
                btnExtraerLata.Enabled = false;
                btnInsertarLata.Enabled = false;
                btnVerStock.Enabled = false;
                btnVerBalance.Enabled = false;
                btnApagar.Enabled = false;
                btnVolver.Show();
                string count = exp1.ContarLatas(exp1);
                lblCuentaLatas.Show();
                lblCuentaLatas.Text = string.Format("La expendedora tiene {0} latas",count);
                listLatas.Sorted = true;
                CargarListaLatas(exp1.Latas);
                listLatas.Show();
            }
            else if (!exp1.EstaVacia())
            {
                SinStockException ex = new SinStockException(string.Format("La {0} no tiene stock.", exp1.Nombre));
                MessageBox.Show(ex.Message);                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnListadoLatas.Enabled = true;
            btnExtraerLata.Enabled = true;
            btnInsertarLata.Enabled = true;
            btnVerStock.Enabled = true;
            btnVerBalance.Enabled = true;
            btnApagar.Enabled = true;
            btnVolver.Hide();
            listLatas.Hide();
            lblCuentaLatas.Hide();
            lblBalance.Hide();
        }

        private void btnVerBalance_Click(object sender, EventArgs e)
        {
            btnListadoLatas.Enabled = false;
            btnExtraerLata.Enabled = false;
            btnInsertarLata.Enabled = false;
            btnVerStock.Enabled = false;
            btnVerBalance.Enabled = false;
            btnApagar.Enabled = false;
            btnVolver.Show();
            string count = exp1.ContarLatas(exp1);
            int capacidadRestante = exp1.GetCapacidadRestante();
            string balance = exp1.GetBalance();
            lblBalance.Show();
            lblBalance.Text = string.Format("La expendedora tiene {0} latas, la capacidad restante es de {1} latas.\nEl dinero que hay dentro es ${2}.", count, capacidadRestante, balance);
        }

        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            if (exp1.EstaVacia())
            {
                btnListadoLatas.Enabled = false;
                btnExtraerLata.Enabled = false;
                btnInsertarLata.Enabled = false;
                btnVerStock.Enabled = false;
                btnVerBalance.Enabled = false;
                btnApagar.Enabled = false;
                btnVolverExtraer.Show();
                lblListadoLatas.Show();
                lblCodigo.Show();              
                txtCodigo.Show();
                btnRetirar.Show();
                lblDinero.Show();
                txtDinero.Show();
                
            }
            else
            {
                MessageBox.Show("La expendedora está vacía.");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                string c = txtCodigo.Text;
                double p = Double.Parse(txtDinero.Text);
                DevolucionMaquina LataVuelto = exp1.ExtraerLata(c, p);
                exp1.Latas.Remove(LataVuelto.Lata);
                MessageBox.Show(string.Format("Aquí tiene su {0} - {1}. Su vuelto es ${2}.", LataVuelto.Lata.Nombre, LataVuelto.Lata.Sabor, LataVuelto.Cambio.ToString()));
                limpiarForm();
                btnListadoLatas.Enabled = true;
                btnExtraerLata.Enabled = true;
                btnInsertarLata.Enabled = true;
                btnVerStock.Enabled = true;
                btnVerBalance.Enabled = true;
                btnApagar.Enabled = true;
                lblListadoLatas.Hide();
                lblCodigo.Hide();               
                txtCodigo.Hide();               
                btnRetirar.Hide();
                lblDinero.Hide();
                txtDinero.Hide();
                btnVolverExtraer.Hide();
            }
            catch (Exception ex)
            {
                limpiarForm();
                MessageBox.Show("Intente nuevamente." + ex.Message);                
            }
        }

        private void btnVolverInsertar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnListadoLatas.Enabled = true;
            btnExtraerLata.Enabled = true;
            btnInsertarLata.Enabled = true;
            btnVerStock.Enabled = true;
            btnVerBalance.Enabled = true;
            btnApagar.Enabled = true;
            lblListadoLatas.Hide();
            lblCodigo.Hide();
            lblPrecio.Hide();
            lblVolumen.Hide();
            txtCodigo.Hide();
            txtPrecio.Hide();
            txtVolumen.Hide();
            btnGuardar.Hide();
            btnVolverInsertar.Hide();

        }

        private void btnVolverExtraer_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnListadoLatas.Enabled = true;
            btnExtraerLata.Enabled = true;
            btnInsertarLata.Enabled = true;
            btnVerStock.Enabled = true;
            btnVerBalance.Enabled = true;
            btnApagar.Enabled = true;
            lblListadoLatas.Hide();
            lblCodigo.Hide();
            txtCodigo.Hide();
            btnRetirar.Hide();
            lblDinero.Hide();
            txtDinero.Hide();
            btnVolverExtraer.Hide();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnListadoLatas.Hide();
            btnInsertarLata.Hide();
            btnExtraerLata.Hide();
            btnVerStock.Hide();
            btnVerBalance.Hide();
            pictureBox1.Hide();
            lblCodigo.Hide();
            lblPrecio.Hide();
            lblVolumen.Hide();
            txtCodigo.Hide();
            txtPrecio.Hide();
            txtVolumen.Hide();
            lblListadoLatas.Hide();
            btnGuardar.Hide();
            btnRetirar.Hide();
            listLatas.Hide();
            btnVolver.Hide();
            lblCuentaLatas.Hide();
            lblBalance.Hide();
            lblDinero.Hide();
            txtDinero.Hide();
            btnVolverExtraer.Hide();
            btnVolverInsertar.Hide();
            btnApagar.Hide();
            lblEncender.Show();
            btnSi.Show();
            btnNo.Show();
        }
#endregion
    }
}
