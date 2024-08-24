namespace Pacial_1._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxLista = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAltaEnvio = new System.Windows.Forms.Button();
            this.btnListarCostos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxLista
            // 
            this.tbxLista.Location = new System.Drawing.Point(12, 12);
            this.tbxLista.Multiline = true;
            this.tbxLista.Name = "tbxLista";
            this.tbxLista.Size = new System.Drawing.Size(329, 145);
            this.tbxLista.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAltaEnvio
            // 
            this.btnAltaEnvio.Location = new System.Drawing.Point(357, 35);
            this.btnAltaEnvio.Name = "btnAltaEnvio";
            this.btnAltaEnvio.Size = new System.Drawing.Size(109, 40);
            this.btnAltaEnvio.TabIndex = 2;
            this.btnAltaEnvio.Text = "Alta Envio(1)";
            this.btnAltaEnvio.UseVisualStyleBackColor = true;
            this.btnAltaEnvio.Click += new System.EventHandler(this.btnAltaEnvio_Click);
            // 
            // btnListarCostos
            // 
            this.btnListarCostos.Location = new System.Drawing.Point(357, 99);
            this.btnListarCostos.Name = "btnListarCostos";
            this.btnListarCostos.Size = new System.Drawing.Size(109, 40);
            this.btnListarCostos.TabIndex = 3;
            this.btnListarCostos.Text = "Listar costos(2)";
            this.btnListarCostos.UseVisualStyleBackColor = true;
            this.btnListarCostos.Click += new System.EventHandler(this.btnListarCostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 169);
            this.Controls.Add(this.btnListarCostos);
            this.Controls.Add(this.btnAltaEnvio);
            this.Controls.Add(this.tbxLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbxLista;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.Button btnListarCostos;
    }
}

