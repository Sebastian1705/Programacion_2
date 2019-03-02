using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaAbstract;

namespace CentralitaForm
{
    public partial class frmMenu : Form
    {
        #region Fields

        private Centralita centralita;

        #endregion

        #region Methods

        public frmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Ejercicio 40");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.centralita);
            llamador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar el formulario?", "Cerrar", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Todas);
            mostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Local);
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Provincial);
            mostrar.ShowDialog();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar el formulario?", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        #endregion
    }
}
