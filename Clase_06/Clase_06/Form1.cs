using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hola Mundo","Titulo",   MessageBoxButtons.YesNoCancel, 
                                                        MessageBoxIcon.Exclamation,
                                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.button1.Text = "SI";
            }
            else
            {
                this.button1.Text = "No";
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en load");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro","Guardar",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            frmPantalla2 frmPantalla2 = new frmPantalla2();
            frmFormulario3 frmOwner = new frmFormulario3();
            frmPantalla2 frmPantalla3 = new frmPantalla2();
            frmPantalla2 frmPantalla4 = new frmPantalla2();

            frmOwner.Show();
            frmPantalla2.MdiParent = this;
            frmPantalla2.Show();
            frmPantalla3.Show(frmOwner);

            this.Mostrar.Text = frmPantalla2.atributoString;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              
        }
    }
}
