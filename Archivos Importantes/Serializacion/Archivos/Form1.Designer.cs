namespace Archivos
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
            this.Archivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button7 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Archivo
            // 
            this.Archivo.Location = new System.Drawing.Point(623, 359);
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(94, 36);
            this.Archivo.TabIndex = 0;
            this.Archivo.Text = "Crea XML";
            this.Archivo.UseVisualStyleBackColor = true;
            this.Archivo.Click += new System.EventHandler(this.Archivo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recupera XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Recupera Binario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Crea Binario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Abrir Archivo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Abrir carpeta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Guardar Archivo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(192, 176);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(116, 20);
            this.txtArchivo.TabIndex = 7;
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(192, 226);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.Size = new System.Drawing.Size(116, 20);
            this.txtCarpeta.TabIndex = 8;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(192, 280);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(116, 20);
            this.txtSave.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "Algo";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(385, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 36);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Archivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Archivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button7;
    }
}

