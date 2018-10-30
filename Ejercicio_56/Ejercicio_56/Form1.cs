using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        string ruta;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open Text File";
            openFile.Filter = "TXT files|*.txt";
            openFile.InitialDirectory = @"C:\Users\Seba\Desktop\Utn\Programacion\Programacion_2";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruta = openFile.FileName;
                StreamReader lectura = new StreamReader(openFile.FileName);
                richTextBox1.Text = lectura.ReadToEnd();
                toolStripStatusLabel3.Text = richTextBox1.Text.Length.ToString() + "Caracteres";
                lectura.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta == null)
                guardarComoToolStripMenuItem_Click(sender, e);
            else
            {
                StreamWriter guardar = new StreamWriter(ruta);
                guardar.Write(richTextBox1.Text);
                guardar.Close();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();

            if (guardarComo.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escritura = new StreamWriter(guardarComo.FileName);
                escritura.Write(richTextBox1.Text);
                ruta = guardarComo.FileName;
                escritura.Close();
            }
        }
    }
}
