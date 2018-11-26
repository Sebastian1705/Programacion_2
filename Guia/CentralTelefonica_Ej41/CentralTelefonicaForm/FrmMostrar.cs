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
    public partial class FrmMostrar : Form
    {
        #region Fields

        private Centralita centralita;

        #endregion

        #region Methods

        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
