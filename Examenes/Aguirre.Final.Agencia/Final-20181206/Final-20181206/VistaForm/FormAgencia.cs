using System.Windows.Forms;
using Entidades;
using System;
using Archivos;

namespace VistaForm
{
    public partial class FormAgencia : Form
    {
        private Agencia agencia;

        public FormAgencia()
        {
            InitializeComponent();
            agencia = new Agencia("Agencia UTN");
            string[] items = new string[] { "Micro", "Avión" };
            this.cmbTipoPasaje.DataSource = items;
            this.cmbTipoPasaje.SelectedIndex = 0;
            this.nudEscalas.Enabled = false;


            this.txtNombre.Text = "Nombre";
            this.txtApellido.Text = "Apellido";
            this.txtDni.Text = "33444555";
            this.txtOrigen.Text = "Buenos Aires";
            this.txtDestino.Text = "Cordoba";
            cmbTipoServicio.DataSource = Enum.GetValues(typeof(Servicio));

            agencia.informar += MostrarMensaje;
            
        }

        /*a. En el manejador del evento Click del botón EmitirPasaje:
        i. Crear el pasaje con los datos ingresados en el formulario
        ii. Agregarlo a la lista de pasajes vendidos de la agencia.*/
        private void btnEmitirPasaje_Click(object sender, System.EventArgs e)
        {
            try
            {                
                Pasajero pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, txtDni.Text);
                
                switch (cmbTipoPasaje.Text)
                {
                    case "Micro":                        
                        Pasaje pasajeMicro = new PasajeMicro( txtOrigen.Text, txtDestino.Text, pasajero, Convert.ToSingle(txtPrecio.Text), 
                                                    Convert.ToDateTime(dtpFechaPartida.Text), (Entidades.Servicio)cmbTipoServicio.SelectedValue);
                        agencia += pasajeMicro;
                        break;
                    case "Avión":
                        Pasaje pasajeAvion = new PasajeAvion(  txtOrigen.Text, txtDestino.Text, pasajero, Convert.ToSingle(txtPrecio.Text),
                                                    Convert.ToDateTime(dtpFechaPartida.Text), Convert.ToInt32(nudEscalas.Value));
                        agencia += pasajeAvion;
                        break;
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*c. En el manejador del evento Click del botón Mostrar:
        i. Mostrar en el RichTextBox rtbMostrar los datos de la agencia.*/
        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbMostrar.Text = (string)agencia;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*b. En el manejador del evento Click del botón Guardar:
        i. Serializar la agencia del formulario en un archivo llamado "Agencia.xml", en caso de error al
        serializar informar al usuario.*/
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Xml<Agencia>  xml = new Xml<Agencia>();
                xml.Guardar("Agencia.xml", this.agencia);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTipoPasaje_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cmbTipoPasaje.SelectedIndex == 0)
            {
                this.nudEscalas.Enabled = false;
                this.nudEscalas.Value = 0;
                this.cmbTipoServicio.Enabled = true;
            }
            else
            {
                this.nudEscalas.Enabled = true;
                this.cmbTipoServicio.Enabled = false;
            }
        }

        private void FormAgencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*d. Crear un manejador para el evento ​informar ​de agencia llamado MostrarMensaje el cual sólo
        mostrará al usuario el mensaje recibido.
        e. Asociar dicho evento a su manejador en el evento load del formulario.*/
        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}
