using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaException;

namespace CentralitaFormException
{
    public partial class FrmMostrar : Form
    {
        #region Fields

        private Llamada.TipoLlamada tipo;
        private Centralita centralita;
  
        #endregion

        #region Propieties

        public CentralitaException.Llamada.TipoLlamada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }

        #endregion

        #region Methods

        public FrmMostrar(Centralita c, Llamada.TipoLlamada t)
        {
            InitializeComponent();
            this.Tipo = t;
            this.centralita = c;
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar el formulario?", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch(this.tipo)
            {
                case Llamada.TipoLlamada.Local:
                    rtxFacturacion.Text = "Facturacion Local:" + this.centralita.GanananciasPorLocal.ToString();
                    break;
                case Llamada.TipoLlamada.Provincial:
                    rtxFacturacion.Text = "Facturacion Provincial: " + this.centralita.GanananciasPorProvincial.ToString();
                    break;
                case Llamada.TipoLlamada.Todas:
                    rtxFacturacion.Text = "Facturacion Total: " + this.centralita.GanananciasPorTotal.ToString();
                    break;
            }
        }

        #endregion
    }
}
