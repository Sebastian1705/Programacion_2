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
    public partial class FrmLlamador : Form
    {
        #region Fields

        private Centralita centralita;

        #endregion

        #region Propieties

        public Centralita MiCentralita
        {
            get
            {
                return this.centralita;
            }
        }

        #endregion

        #region Methods

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(CentralitaException.Provincial.Franja));
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 9;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 0;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar el formulario?", "Cerrar", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "Nro Origen";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text != "")
            {
                Random r = new Random();
                try
                {
                    if (txtNroDestino.Text[0] == '#')
                    {
                        Provincial.Franja franjas;
                        Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                        Provincial provincial = new Provincial(txtNroOrigen.Text, r.Next(1, 50), txtNroDestino.Text, franjas);
                        this.centralita += provincial;
                        MessageBox.Show($"Llamada provincial realizada en {franjas}");
                    }
                    else
                    {
                        Local local = new Local(txtNroOrigen.Text, r.Next(1, 50), txtNroDestino.Text, (r.Next(5, 56) / 10));
                        this.centralita += local;
                        MessageBox.Show("Llamada local realizada");
                    }
                }
                catch(CentralitaException.CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Falta ingresar numero de destino");
        }


        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar el formulario?", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        #endregion
    }
}
