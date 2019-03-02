using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        #region Fields 

        private Queue<Patente> cola;
        private List<Thread> lista;

        #endregion

        #region Methods

        public FrmPpal()
        {
            InitializeComponent();
            this.lista = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            foreach (Thread item in this.lista)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }

        #endregion
    }
}
