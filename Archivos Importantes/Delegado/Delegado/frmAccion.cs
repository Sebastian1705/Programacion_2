using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegado
{
    public delegate void msaje(string mensaje);

    public partial class frmAccion : Form
    {

        public event msaje enviarMens;
        public frmAccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviarMens.Invoke(this.textBox1.Text);
        }
    }
}
