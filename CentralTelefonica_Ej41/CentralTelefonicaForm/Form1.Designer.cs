namespace CentralTelefonicaForm
{
    partial class frmCentralTelefonica
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
            this.btnGenararLlamada = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.bntSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenararLlamada
            // 
            this.btnGenararLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenararLlamada.Location = new System.Drawing.Point(27, 12);
            this.btnGenararLlamada.Name = "btnGenararLlamada";
            this.btnGenararLlamada.Size = new System.Drawing.Size(352, 73);
            this.btnGenararLlamada.TabIndex = 0;
            this.btnGenararLlamada.Text = "Generar Llamada";
            this.btnGenararLlamada.UseVisualStyleBackColor = true;
            this.btnGenararLlamada.Click += new System.EventHandler(this.btnGenararLlamada_Click);
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionTotal.Location = new System.Drawing.Point(27, 108);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(352, 73);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionLocal.Location = new System.Drawing.Point(27, 203);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(352, 73);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(27, 299);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(352, 73);
            this.btnFacturacionProvincial.TabIndex = 3;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = true;
            // 
            // bntSalir
            // 
            this.bntSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalir.Location = new System.Drawing.Point(27, 398);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(352, 73);
            this.bntSalir.TabIndex = 4;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = true;
            // 
            // frmCentralTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 482);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnGenararLlamada);
            this.Name = "frmCentralTelefonica";
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenararLlamada;
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button bntSalir;
    }
}

