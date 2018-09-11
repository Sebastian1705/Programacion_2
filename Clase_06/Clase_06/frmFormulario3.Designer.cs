namespace Clase_06
{
    partial class frmFormulario3
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
            this.chkAlgo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoArgento = new System.Windows.Forms.RadioButton();
            this.rdoExt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAlgo
            // 
            this.chkAlgo.AutoSize = true;
            this.chkAlgo.Location = new System.Drawing.Point(336, 56);
            this.chkAlgo.Name = "chkAlgo";
            this.chkAlgo.Size = new System.Drawing.Size(80, 17);
            this.chkAlgo.TabIndex = 0;
            this.chkAlgo.Text = "checkBox1";
            this.chkAlgo.UseVisualStyleBackColor = true;
            this.chkAlgo.CheckedChanged += new System.EventHandler(this.chkAlgo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoArgento
            // 
            this.rdoArgento.AutoSize = true;
            this.rdoArgento.Location = new System.Drawing.Point(6, 19);
            this.rdoArgento.Name = "rdoArgento";
            this.rdoArgento.Size = new System.Drawing.Size(77, 17);
            this.rdoArgento.TabIndex = 2;
            this.rdoArgento.TabStop = true;
            this.rdoArgento.Text = "rdoArgento";
            this.rdoArgento.UseVisualStyleBackColor = true;
            this.rdoArgento.CheckedChanged += new System.EventHandler(this.r_CheckedChanged);
            // 
            // rdoExt
            // 
            this.rdoExt.AutoSize = true;
            this.rdoExt.Location = new System.Drawing.Point(6, 42);
            this.rdoExt.Name = "rdoExt";
            this.rdoExt.Size = new System.Drawing.Size(55, 17);
            this.rdoExt.TabIndex = 3;
            this.rdoExt.TabStop = true;
            this.rdoExt.Text = "rdoExt";
            this.rdoExt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoArgento);
            this.groupBox1.Controls.Add(this.rdoExt);
            this.groupBox1.Location = new System.Drawing.Point(593, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmFormulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkAlgo);
            this.Name = "frmFormulario3";
            this.Text = "frmFormulario3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAlgo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoArgento;
        private System.Windows.Forms.RadioButton rdoExt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}