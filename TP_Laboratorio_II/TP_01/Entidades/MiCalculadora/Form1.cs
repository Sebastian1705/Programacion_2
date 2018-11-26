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
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
        }

        #region

        /// <summary>
        /// Evento que cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que convierte el el resultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string auxiliar = lblResultado.Text;
            if (auxiliar != "" && auxiliar != "Resultado")
            {
                lblResultado.Text = Numero.DecimalBinario(auxiliar);
            }
            else
                lblResultado.Text = "Valor invalido";
        }

        /// <summary>
        /// Evento que convierte el el resultado a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string auxiliar = lblResultado.Text;
            if (auxiliar != "" && auxiliar != "Resultado")
            {
                lblResultado.Text = Numero.BinarioDecimal(auxiliar);
            }
            else
                lblResultado.Text = "Valor invalido";
        }

        /// <summary>
        /// Evento que llama al metodo Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        
        /// <summary>
        /// Evento que realiza la operacion segun los datos ingresados mostrando el resultado en el labelText
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text;
            string numero2 = txtNumero2.Text;
            int operador = cmbOperador.SelectedIndex;
            string retorno = "";
            double resultado = 0, aux = 0;
            if(!(Object.ReferenceEquals(numero1,null)) && !(Object.ReferenceEquals(numero2, null)))
            {
                txtNumero1.Text = (Double.TryParse(txtNumero1.Text,out aux )) ? txtNumero1.Text : "0";
                txtNumero2.Text = (Double.TryParse(txtNumero2.Text, out aux)) ? txtNumero2.Text : "0";
                if (operador != -1)
                {
                    if (operador == 2 && (double.Parse(numero2) == 0))
                    {
                        retorno = "No se puede dividir por cero";
                        lblResultado.Text = retorno;
                    }
                    else
                    {
                        resultado = Operar(numero1, numero2, cmbOperador.Items[operador].ToString());
                        lblResultado.Text = resultado.ToString();
                    }
                }
                else
                    lblResultado.Text = "No selecciono operador";
            }              
        }
    
        /// <summary>
        /// 
        /// </summary>
        public LaCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que limpia los TextBox, el operador, y lblResultado
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "Resultado";
            cmbOperador.SelectedItem = -1;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno = 0;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            retorno = Calculadora.Operar(num1, num2, operador);
            return retorno;
        }
        
        #endregion
    }
}
