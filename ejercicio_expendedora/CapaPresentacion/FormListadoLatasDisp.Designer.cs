namespace CapaPresentacion
{
    partial class FormListadoLatasDisp
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
            this.lblListadoLatasDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListadoLatasDisp
            // 
            this.lblListadoLatasDisp.AutoSize = true;
            this.lblListadoLatasDisp.Location = new System.Drawing.Point(12, 9);
            this.lblListadoLatasDisp.Name = "lblListadoLatasDisp";
            this.lblListadoLatasDisp.Size = new System.Drawing.Size(147, 78);
            this.lblListadoLatasDisp.TabIndex = 0;
            this.lblListadoLatasDisp.Text = "    + CO1 - Coca Cola Regular\r\n    + CO2 - Coca Cola Zero\r\n    + SP1 - Sprite Reg" +
    "ular\r\n    + SP2 - Sprite Zero\r\n    + FA1 - Fanta Regular\r\n    + FA2 - Fanta Zero" +
    "";
            // 
            // FormListadoLatasDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 100);
            this.Controls.Add(this.lblListadoLatasDisp);
            this.Name = "FormListadoLatasDisp";
            this.Text = "Listado de latas disponibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoLatasDisp;
    }
}