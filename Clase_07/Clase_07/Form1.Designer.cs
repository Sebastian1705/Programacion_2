namespace Clase_07
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
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(12, 189);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(47, 17);
            this.lblPesos.TabIndex = 0;
            this.lblPesos.Text = "Pesos";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(12, 152);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(42, 17);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(12, 115);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(38, 17);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "Euro";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(116, 184);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 22);
            this.txtPesos.TabIndex = 3;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(116, 147);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 22);
            this.txtDolar.TabIndex = 4;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(116, 110);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 22);
            this.txtEuro.TabIndex = 5;
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(222, 183);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 6;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(222, 146);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 7;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(222, 106);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 26);
            this.btnConvertEuro.TabIndex = 8;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Enabled = false;
            this.txtPesosAEuro.Location = new System.Drawing.Point(315, 183);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(100, 22);
            this.txtPesosAEuro.TabIndex = 9;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(315, 146);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 22);
            this.txtDolarAEuro.TabIndex = 10;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(315, 112);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 22);
            this.txtEuroAEuro.TabIndex = 11;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Enabled = false;
            this.txtPesosADolar.Location = new System.Drawing.Point(431, 183);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(100, 22);
            this.txtPesosADolar.TabIndex = 12;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(431, 146);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 22);
            this.txtDolarADolar.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(431, 112);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 22);
            this.txtEuroADolar.TabIndex = 14;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Enabled = false;
            this.txtPesosAPesos.Location = new System.Drawing.Point(548, 183);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 22);
            this.txtPesosAPesos.TabIndex = 15;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Enabled = false;
            this.txtDolarAPesos.Location = new System.Drawing.Point(548, 146);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(100, 22);
            this.txtDolarAPesos.TabIndex = 16;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Enabled = false;
            this.txtEuroAPesos.Location = new System.Drawing.Point(548, 112);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(100, 22);
            this.txtEuroAPesos.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 225);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblPesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtEuroAPesos;
    }
}

