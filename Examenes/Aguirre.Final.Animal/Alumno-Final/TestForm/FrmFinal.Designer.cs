namespace TestForm
{
    partial class FrmFinal
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
            this.btnPunto1 = new System.Windows.Forms.Button();
            this.btnPunto2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.btnPunto5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPunto1
            // 
            this.btnPunto1.Location = new System.Drawing.Point(12, 33);
            this.btnPunto1.Name = "btnPunto1";
            this.btnPunto1.Size = new System.Drawing.Size(158, 83);
            this.btnPunto1.TabIndex = 0;
            this.btnPunto1.Text = "Punto 1";
            this.btnPunto1.UseVisualStyleBackColor = true;
            this.btnPunto1.Click += new System.EventHandler(this.btnPunto1_Click);
            // 
            // btnPunto2
            // 
            this.btnPunto2.Location = new System.Drawing.Point(176, 33);
            this.btnPunto2.Name = "btnPunto2";
            this.btnPunto2.Size = new System.Drawing.Size(158, 83);
            this.btnPunto2.TabIndex = 1;
            this.btnPunto2.Text = "Punto 2";
            this.btnPunto2.UseVisualStyleBackColor = true;
            this.btnPunto2.Click += new System.EventHandler(this.btnPunto2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 122);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(322, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnPunto4
            // 
            this.btnPunto4.Location = new System.Drawing.Point(176, 151);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(158, 83);
            this.btnPunto4.TabIndex = 6;
            this.btnPunto4.Text = "Punto 4";
            this.btnPunto4.UseVisualStyleBackColor = true;
            this.btnPunto4.Click += new System.EventHandler(this.btnPunto4_Click);
            // 
            // btnPunto3
            // 
            this.btnPunto3.Location = new System.Drawing.Point(12, 151);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(158, 83);
            this.btnPunto3.TabIndex = 5;
            this.btnPunto3.Text = "Punto 3";
            this.btnPunto3.UseVisualStyleBackColor = true;
            this.btnPunto3.Click += new System.EventHandler(this.btnPunto3_Click);
            // 
            // btnPunto5
            // 
            this.btnPunto5.Location = new System.Drawing.Point(98, 240);
            this.btnPunto5.Name = "btnPunto5";
            this.btnPunto5.Size = new System.Drawing.Size(158, 83);
            this.btnPunto5.TabIndex = 7;
            this.btnPunto5.Text = "Punto 5";
            this.btnPunto5.UseVisualStyleBackColor = true;
            this.btnPunto5.Click += new System.EventHandler(this.btnPunto5_Click);
            // 
            // FrmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 368);
            this.Controls.Add(this.btnPunto5);
            this.Controls.Add(this.btnPunto4);
            this.Controls.Add(this.btnPunto3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPunto2);
            this.Controls.Add(this.btnPunto1);
            this.Name = "FrmFinal";
            this.Text = "Final 13-12-2018";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFinal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPunto1;
        private System.Windows.Forms.Button btnPunto2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.Button btnPunto5;
    }
}

