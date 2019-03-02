namespace CentralitaFormException
{
    partial class FrmMostrar
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
            this.rtxFacturacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxFacturacion
            // 
            this.rtxFacturacion.Location = new System.Drawing.Point(12, 12);
            this.rtxFacturacion.Name = "rtxFacturacion";
            this.rtxFacturacion.ReadOnly = true;
            this.rtxFacturacion.Size = new System.Drawing.Size(425, 314);
            this.rtxFacturacion.TabIndex = 0;
            this.rtxFacturacion.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 338);
            this.Controls.Add(this.rtxFacturacion);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMostrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMostrar_FormClosing);
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxFacturacion;
    }
}