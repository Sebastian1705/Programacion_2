using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(txtPath.Text))
            {
                string[] paths =  Directory.GetFiles(txtPath.Text);
                progressBar1.Maximum = paths.Length;
                progressBar1.Value = 0;

                Alumno al = new Alumno();
                al.ActualizarContador += actualizaProgressBar;
                foreach (string item in paths)
                {
                    
                    Thread t1 = new Thread(new ParameterizedThreadStart(al.deserealizarXML));
                    t1.Start(item);
                    
                }

                    

            }else{
                MessageBox.Show("Seleccione una carpeta correcta");
                txtPath.Focus();
            }

        }

        public void actualizaProgressBar()
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.BeginInvoke((MethodInvoker)delegate()
                {
                    this.progressBar1.Value = this.progressBar1.Value + 1;                    
                    if (this.progressBar1.Value == this.progressBar1.Maximum)
                        MessageBox.Show("Proceso terminado");
                });

            }
            else
            {
                this.progressBar1.Value = this.progressBar1.Value + 1;                
                if (this.progressBar1.Value == this.progressBar1.Maximum)
                    MessageBox.Show("Proceso terminado");
            }            
        }

    }
}
