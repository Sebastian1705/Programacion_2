using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Clase_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double auxEuro;
            if (double.TryParse(txtEuro.Text, out auxEuro))
            {
                Euro euro = new Euro(auxEuro);
                Dolar auxDolar = (Dolar)euro;
                Pesos auxPesos = (Pesos)euro;
                txtEuroADolar.Text = auxDolar.GetCantidad().ToString();
                txtEuroAPesos.Text = auxPesos.GetCantidad().ToString();
                txtEuroAEuro.Text = euro.GetCantidad().ToString();
            }   
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double auxDolar;
            if(double.TryParse(txtDolar.Text, out auxDolar))
            {
                Dolar dolar = new Dolar(auxDolar);
                Pesos auxPesos = (Pesos)dolar;
                Euro auxEuro = (Euro)dolar;
                txtDolarADolar.Text = dolar.GetCantidad().ToString();
                txtDolarAEuro.Text = auxEuro.GetCantidad().ToString();
                txtDolarAPesos.Text = auxPesos.GetCantidad().ToString();
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double auxPesos;
            if(double.TryParse(txtPesos.Text, out auxPesos))
            {
                Pesos pesos = new Pesos(auxPesos);
                Dolar auxDolar = (Dolar)pesos;
                Euro auxEuro = (Euro)pesos;
                txtPesosAEuro.Text = auxEuro.GetCantidad().ToString();
                txtPesosAPesos.Text = pesos.GetCantidad().ToString();
                txtPesosADolar.Text = auxDolar.GetCantidad().ToString();
            }
        }
    }
}
