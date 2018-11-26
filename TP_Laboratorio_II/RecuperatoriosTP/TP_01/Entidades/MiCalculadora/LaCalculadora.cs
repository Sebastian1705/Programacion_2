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

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        #region Methods

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public LaCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que limpia los TextBox, el operador, y lblResultado.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "Resultado";
            cmbOperador.SelectedItem = 0;
        }

        /// <summary>
        /// Metodo que verifica que los parametros sean distintos de null
        /// y llama al metodo operar de la clase calculadora
        /// </summary>
        /// <param name="numero1">primer parametro para la operacion</param>
        /// <param name="numero2">segundo operando para el calcul matematico</param>
        /// <param name="operador">tipo de operacion</param>
        /// <returns>Resultado de la operacion.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno = 0;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            retorno = Calculadora.Operar(num1, num2, operador);
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento que cierra la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que llama al metodo Limpiar().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento que realiza la operacion segun los datos ingresados mostrando el resultado en el labelText.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            int operador = cmbOperador.SelectedIndex;
            double aux;
            string resultado = "";
            txtNumero1.Text = (Double.TryParse(txtNumero1.Text, out aux)) ? txtNumero1.Text : "0";
            txtNumero2.Text = (Double.TryParse(txtNumero2.Text, out aux)) ? txtNumero2.Text : "0";
            if (operador != -1)
            {
                if (operador == 2 && txtNumero2.Text == "0")
                {
                    resultado = "No se puede dividir por cero";
                }
                else
                    resultado = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Items[operador].ToString())).ToString();
            }
            lblResultado.Text = resultado;
        }

        /// <summary>
        /// Evento que convierte el el resultado a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }

        /// <summary>
        /// Evento que convierte el el resultado a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }
  
        #endregion
    }
}
