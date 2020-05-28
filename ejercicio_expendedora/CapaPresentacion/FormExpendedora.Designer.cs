namespace CapaPresentacion
{
    partial class FormExpendedora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpendedora));
            this.lblEncender = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnListadoLatas = new System.Windows.Forms.Button();
            this.btnExtraerLata = new System.Windows.Forms.Button();
            this.btnVerBalance = new System.Windows.Forms.Button();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.btnInsertarLata = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblListadoLatas = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.listLatas = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCuentaLatas = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.btnVolverInsertar = new System.Windows.Forms.Button();
            this.btnVolverExtraer = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncender
            // 
            this.lblEncender.AutoSize = true;
            this.lblEncender.Location = new System.Drawing.Point(12, 9);
            this.lblEncender.Name = "lblEncender";
            this.lblEncender.Size = new System.Drawing.Size(124, 13);
            this.lblEncender.TabIndex = 0;
            this.lblEncender.Text = "Encender expendedora?";
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(15, 36);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(51, 27);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(85, 36);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(51, 27);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListadoLatas
            // 
            this.btnListadoLatas.Location = new System.Drawing.Point(15, 78);
            this.btnListadoLatas.Name = "btnListadoLatas";
            this.btnListadoLatas.Size = new System.Drawing.Size(158, 36);
            this.btnListadoLatas.TabIndex = 3;
            this.btnListadoLatas.Text = "Listado de latas disponibles";
            this.btnListadoLatas.UseVisualStyleBackColor = true;
            this.btnListadoLatas.Click += new System.EventHandler(this.btnListadoLatas_Click);
            // 
            // btnExtraerLata
            // 
            this.btnExtraerLata.Location = new System.Drawing.Point(15, 162);
            this.btnExtraerLata.Name = "btnExtraerLata";
            this.btnExtraerLata.Size = new System.Drawing.Size(158, 36);
            this.btnExtraerLata.TabIndex = 4;
            this.btnExtraerLata.Text = "Extraer lata";
            this.btnExtraerLata.UseVisualStyleBackColor = true;
            this.btnExtraerLata.Click += new System.EventHandler(this.btnExtraerLata_Click);
            // 
            // btnVerBalance
            // 
            this.btnVerBalance.Location = new System.Drawing.Point(15, 204);
            this.btnVerBalance.Name = "btnVerBalance";
            this.btnVerBalance.Size = new System.Drawing.Size(158, 36);
            this.btnVerBalance.TabIndex = 5;
            this.btnVerBalance.Text = "Ver balance";
            this.btnVerBalance.UseVisualStyleBackColor = true;
            this.btnVerBalance.Click += new System.EventHandler(this.btnVerBalance_Click);
            // 
            // btnVerStock
            // 
            this.btnVerStock.Location = new System.Drawing.Point(15, 246);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(158, 36);
            this.btnVerStock.TabIndex = 6;
            this.btnVerStock.Text = "Ver stock";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // btnInsertarLata
            // 
            this.btnInsertarLata.Location = new System.Drawing.Point(15, 120);
            this.btnInsertarLata.Name = "btnInsertarLata";
            this.btnInsertarLata.Size = new System.Drawing.Size(158, 36);
            this.btnInsertarLata.TabIndex = 7;
            this.btnInsertarLata.Text = "Insertar lata";
            this.btnInsertarLata.UseVisualStyleBackColor = true;
            this.btnInsertarLata.Click += new System.EventHandler(this.btnInsertarLata_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(223, 120);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "código";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(223, 162);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(36, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "precio";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(212, 204);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(70, 13);
            this.lblVolumen.TabIndex = 11;
            this.lblVolumen.Text = "volumen (mL)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(284, 113);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(284, 155);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(284, 197);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtVolumen.TabIndex = 14;
            // 
            // lblListadoLatas
            // 
            this.lblListadoLatas.AutoSize = true;
            this.lblListadoLatas.Location = new System.Drawing.Point(210, 9);
            this.lblListadoLatas.Name = "lblListadoLatas";
            this.lblListadoLatas.Size = new System.Drawing.Size(147, 91);
            this.lblListadoLatas.TabIndex = 15;
            this.lblListadoLatas.Text = "   Latas Disponibles:\r\n    + CO1 - Coca Cola Regular\r\n    + CO2 - Coca Cola Zero\r" +
    "\n    + SP1 - Sprite Regular\r\n    + SP2 - Sprite Zero\r\n    + FA1 - Fanta Regular\r" +
    "\n    + FA2 - Fanta Zero";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 36);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(226, 288);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(158, 36);
            this.btnRetirar.TabIndex = 17;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // listLatas
            // 
            this.listLatas.FormattingEnabled = true;
            this.listLatas.Location = new System.Drawing.Point(428, 78);
            this.listLatas.Name = "listLatas";
            this.listLatas.Size = new System.Drawing.Size(360, 290);
            this.listLatas.TabIndex = 19;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(428, 374);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCuentaLatas
            // 
            this.lblCuentaLatas.AutoSize = true;
            this.lblCuentaLatas.Location = new System.Drawing.Point(428, 58);
            this.lblCuentaLatas.Name = "lblCuentaLatas";
            this.lblCuentaLatas.Size = new System.Drawing.Size(0, 13);
            this.lblCuentaLatas.TabIndex = 21;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(428, 342);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 22;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(202, 263);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(76, 13);
            this.lblDinero.TabIndex = 23;
            this.lblDinero.Text = "Ingrese Dinero";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(284, 256);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(100, 20);
            this.txtDinero.TabIndex = 24;
            // 
            // btnVolverInsertar
            // 
            this.btnVolverInsertar.Location = new System.Drawing.Point(15, 330);
            this.btnVolverInsertar.Name = "btnVolverInsertar";
            this.btnVolverInsertar.Size = new System.Drawing.Size(158, 36);
            this.btnVolverInsertar.TabIndex = 25;
            this.btnVolverInsertar.Text = "Volver";
            this.btnVolverInsertar.UseVisualStyleBackColor = true;
            this.btnVolverInsertar.Click += new System.EventHandler(this.btnVolverInsertar_Click);
            // 
            // btnVolverExtraer
            // 
            this.btnVolverExtraer.Location = new System.Drawing.Point(226, 330);
            this.btnVolverExtraer.Name = "btnVolverExtraer";
            this.btnVolverExtraer.Size = new System.Drawing.Size(158, 36);
            this.btnVolverExtraer.TabIndex = 26;
            this.btnVolverExtraer.Text = "Volver";
            this.btnVolverExtraer.UseVisualStyleBackColor = true;
            this.btnVolverExtraer.Click += new System.EventHandler(this.btnVolverExtraer_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(15, 400);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(158, 38);
            this.btnApagar.TabIndex = 27;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FormExpendedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnVolverExtraer);
            this.Controls.Add(this.btnVolverInsertar);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCuentaLatas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listLatas);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblListadoLatas);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInsertarLata);
            this.Controls.Add(this.btnVerStock);
            this.Controls.Add(this.btnVerBalance);
            this.Controls.Add(this.btnExtraerLata);
            this.Controls.Add(this.btnListadoLatas);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblEncender);
            this.Name = "FormExpendedora";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.FormExpendedora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncender;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnListadoLatas;
        private System.Windows.Forms.Button btnInsertarLata;
        private System.Windows.Forms.Button btnExtraerLata;
        private System.Windows.Forms.Button btnVerBalance;
        private System.Windows.Forms.Button btnVerStock;        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblListadoLatas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.ListBox listLatas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCuentaLatas;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Button btnVolverInsertar;
        private System.Windows.Forms.Button btnVolverExtraer;
        private System.Windows.Forms.Button btnApagar;
    }
}

