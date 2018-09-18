using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase__08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(1, "Monitor 21'", 4000, 840);
            Producto producto = new Producto(1, "Led 40'", 6000, 40);
        }
    }
}
