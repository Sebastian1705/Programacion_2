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

namespace VistaForm
{
    public partial class FormLogin : Form
    {
        #region Fields

        Usuario usuario;

        #endregion

        #region Methods

        public FormLogin()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
        }

        /*a.En el manejador del evento Click del botón Ingresar:
         i.Agregar el código necesario para recuperar el usuario de la base de datos.
         ii.Agregar captura de errores.
         iii.En caso de no existir el usuario ingresado, mostrar el mensaje "Usuario o Clave incorectos"
         con un ícono de exclamación.
         iv.En caso de error, mostrar el mensaje "Error al intentar recuperar el usuario" con un ícono de
         error.*/
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //ALUMNO
            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                usuario = dao.Leer(txtUsuario.Text, txtClave.Text);
            }
            catch(ClaveInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar recuperar el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (usuario != null)
            {
                this.Hide();
                FormAgencia f2 = new FormAgencia();
                f2.ShowDialog();
            }
            else
                MessageBox.Show("Usuario o Clave incorectos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /* b. En el manejador del evento Click del botón Registrarse debajo del comentario “//Alumno” Agregar el
         código necesario para :
         i. Guardar el usuario en la base de datos.
         ii. Agregar captura de errores.
         iii. En caso de guardar el usuario correctamente mostrar el mensaje "Usuario registrado".
         iv. En caso de error por clave inválida, mostrar el mensaje "La clave debe contener al menos 8
         dígitos!" con un ícono de error.
         v. Ante cualquier otro error, mostrar el mensaje "Error al registrar el usuario" con un ícono de
         error.*/
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //ALUMNO
            try
            {
                if (txtUsuario.Text.Length == 0)
                    MessageBox.Show("Falta usuario");
                else
                {
                    usuario = new Usuario(txtUsuario.Text, txtClave.Text);
                    UsuarioDAO dao = new UsuarioDAO();
                    if (usuario != null)
                    {
                        dao.Guardar(usuario);
                        MessageBox.Show("Usuario registrado");
                    }
                }
            }
            catch(ClaveInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //limpio los controles después del registro
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            usuario = null;
        }

        #endregion
    }
}
