using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTelefonica;

namespace CentralTelefonicaForm
{
    public partial class frmCentralTelefonica : Form
    {
        #region Fields

        private Centralita centralita;

        #endregion

        #region Methods

        public frmCentralTelefonica()
        {
            InitializeComponent();
        }

        private void btnGenararLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.centralita);
            llamador.ShowDialog();
            this.centralita = llamador.Centralita;
        }

        private void frmCentralTelefonica_Load(object sender, EventArgs e)
        {
            centralita = new Centralita("Sebastian");
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
