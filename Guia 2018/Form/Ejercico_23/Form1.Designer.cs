namespace Ejercico_23
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
            this.lalReal = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAReal = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.btnConvertReal = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.txtRealADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAReal = new System.Windows.Forms.TextBox();
            this.txtRealAReal = new System.Windows.Forms.TextBox();
            this.txtRealAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPesos
            // 
            this.lblPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(12, 138);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(100, 23);
            this.lblPesos.TabIndex = 0;
            this.lblPesos.Text = "Pesos";
            // 
            // lalReal
            // 
            this.lalReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalReal.Location = new System.Drawing.Point(12, 104);
            this.lalReal.Name = "lalReal";
            this.lalReal.Size = new System.Drawing.Size(100, 23);
            this.lalReal.TabIndex = 1;
            this.lalReal.Text = "Real";
            // 
            // lblDolar
            // 
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(12, 67);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(100, 23);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Dolar";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(95, 141);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 3;
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(95, 104);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(100, 20);
            this.txtReal.TabIndex = 4;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(95, 66);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 5;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Location = new System.Drawing.Point(344, 141);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.ReadOnly = true;
            this.txtPesosADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosADolar.TabIndex = 6;
            // 
            // txtPesosAReal
            // 
            this.txtPesosAReal.Location = new System.Drawing.Point(450, 141);
            this.txtPesosAReal.Name = "txtPesosAReal";
            this.txtPesosAReal.ReadOnly = true;
            this.txtPesosAReal.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAReal.TabIndex = 7;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Location = new System.Drawing.Point(556, 141);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.ReadOnly = true;
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAPesos.TabIndex = 8;
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(213, 139);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(113, 23);
            this.btnConvertPesos.TabIndex = 9;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // btnConvertReal
            // 
            this.btnConvertReal.Location = new System.Drawing.Point(213, 101);
            this.btnConvertReal.Name = "btnConvertReal";
            this.btnConvertReal.Size = new System.Drawing.Size(113, 23);
            this.btnConvertReal.TabIndex = 10;
            this.btnConvertReal.Text = "->";
            this.btnConvertReal.UseVisualStyleBackColor = true;
            this.btnConvertReal.Click += new System.EventHandler(this.btnConvertReal_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(213, 63);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(113, 23);
            this.btnConvertDolar.TabIndex = 11;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // txtRealADolar
            // 
            this.txtRealADolar.Location = new System.Drawing.Point(344, 103);
            this.txtRealADolar.Name = "txtRealADolar";
            this.txtRealADolar.ReadOnly = true;
            this.txtRealADolar.Size = new System.Drawing.Size(100, 20);
            this.txtRealADolar.TabIndex = 12;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(344, 63);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 13;
            // 
            // txtDolarAReal
            // 
            this.txtDolarAReal.Location = new System.Drawing.Point(450, 63);
            this.txtDolarAReal.Name = "txtDolarAReal";
            this.txtDolarAReal.ReadOnly = true;
            this.txtDolarAReal.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAReal.TabIndex = 14;
            // 
            // txtRealAReal
            // 
            this.txtRealAReal.Location = new System.Drawing.Point(450, 103);
            this.txtRealAReal.Name = "txtRealAReal";
            this.txtRealAReal.ReadOnly = true;
            this.txtRealAReal.Size = new System.Drawing.Size(100, 20);
            this.txtRealAReal.TabIndex = 15;
            // 
            // txtRealAPesos
            // 
            this.txtRealAPesos.Location = new System.Drawing.Point(556, 103);
            this.txtRealAPesos.Name = "txtRealAPesos";
            this.txtRealAPesos.ReadOnly = true;
            this.txtRealAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtRealAPesos.TabIndex = 16;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Location = new System.Drawing.Point(556, 63);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.ReadOnly = true;
            this.txtDolarAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPesos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dolar";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Real";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pesos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtRealAPesos);
            this.Controls.Add(this.txtRealAReal);
            this.Controls.Add(this.txtDolarAReal);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtRealADolar);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertReal);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtPesosAReal);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lalReal);
            this.Controls.Add(this.lblPesos);
            this.Name = "Form1";
            this.Text = "Converor Dinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lalReal;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAReal;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.Button btnConvertReal;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.TextBox txtRealADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAReal;
        private System.Windows.Forms.TextBox txtRealAReal;
        private System.Windows.Forms.TextBox txtRealAPesos;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

