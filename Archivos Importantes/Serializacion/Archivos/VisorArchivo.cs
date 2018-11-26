using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Archivos
{
    public partial class frmVisorArchivo : Form
    {

        private string archivo;
        public frmVisorArchivo()
        {
            InitializeComponent();
            this.guardarToolStripMenuItem.Enabled = false;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo Texto|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    archivo = openFileDialog1.FileName;
                    this.guardarToolStripMenuItem.Enabled = true;
                    StreamReader st = new StreamReader(archivo);
                    richTextBox1.Text = st.ReadToEnd();
                    st.Close();
                }

            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            StreamWriter st = new StreamWriter(archivo);
            st.Write(richTextBox1.Text);
            st.Close();

            this.guardarToolStripMenuItem.Enabled = false;
            archivo = "";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            tslblEstado.Text =   richTextBox1.Text.Length.ToString() + " Caracteres";
        }
    }
}
