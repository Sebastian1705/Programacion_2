using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercico_23
{
    public partial class Form1 : Form
    {
        #region Fields

        private Dolar dolar;
        private Real real;
        private Pesos pesos;

        #endregion

        #region Methods

        public Form1()
        {
            InitializeComponent();
        }



        #endregion

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double numero;
            try
            {
                if (double.TryParse(txtDolar.Text, out numero))
                    dolar = new Dolar(numero);
                txtDolarADolar.Text = numero.ToString("##,##0.00");
                txtDolarAPesos.Text = ((Pesos)dolar).GetCantidad().ToString("##,##0.00");
                txtDolarAReal.Text = ((Real)dolar).GetCantidad().ToString("##,##0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvertReal_Click(object sender, EventArgs e)
        {
            double numero;
            try
            {
                if (double.TryParse(txtReal.Text, out numero))
                    real = new Real(numero);
                txtRealADolar.Text = ((Dolar)real).GetCantidad().ToString("##,##0.00");
                txtRealAReal.Text = numero.ToString("##,##0.00");
                txtRealAPesos.Text = ((Pesos)real).GetCantidad().ToString("##,##0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double numero;
            try
            {
                if (double.TryParse(txtPesos.Text, out numero))
                    pesos = new Pesos(numero);
                txtPesosADolar.Text = ((Dolar)pesos).GetCantidad().ToString("##,##0.00");
                txtPesosAReal.Text = ((Real)pesos).GetCantidad().ToString("##,##0.00");
                txtPesosAPesos.Text = numero.ToString("##,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
