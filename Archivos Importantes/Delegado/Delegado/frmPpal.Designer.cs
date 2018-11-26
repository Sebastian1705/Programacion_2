namespace Delegado
{
    partial class frmPpal
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
            this.btnMostrar1 = new System.Windows.Forms.Button();
            this.btnMostrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar1
            // 
            this.btnMostrar1.Location = new System.Drawing.Point(63, 53);
            this.btnMostrar1.Name = "btnMostrar1";
            this.btnMostrar1.Size = new System.Drawing.Size(141, 45);
            this.btnMostrar1.TabIndex = 0;
            this.btnMostrar1.Text = "Mostrar 1";
            this.btnMostrar1.UseVisualStyleBackColor = true;
            this.btnMostrar1.Click += new System.EventHandler(this.btnMostrar1_Click);
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.Location = new System.Drawing.Point(68, 126);
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.Size = new System.Drawing.Size(136, 46);
            this.btnMostrar2.TabIndex = 1;
            this.btnMostrar2.Text = "Mostrar 2";
            this.btnMostrar2.UseVisualStyleBackColor = true;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 270);
            this.Controls.Add(this.btnMostrar2);
            this.Controls.Add(this.btnMostrar1);
            this.Name = "frmPpal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar1;
        private System.Windows.Forms.Button btnMostrar2;
    }
}