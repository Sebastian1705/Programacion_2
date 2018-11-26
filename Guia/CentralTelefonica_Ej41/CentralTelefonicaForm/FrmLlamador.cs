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
    public partial class FrmLlamador : Form
    {
        #region Fields

        private Centralita centralita;

        #endregion

        #region Propieties
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        #endregion

        #region Methods

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
