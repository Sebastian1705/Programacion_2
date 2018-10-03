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

namespace AGUIRRE.SEBASTIAN
{
    public partial class Form1 : Form
    {
        Curso curso;

        public Form1()
        {
            InitializeComponent();
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }     

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if( !Object.ReferenceEquals(txtNombreProfe.Text, null) &&
                !Object.ReferenceEquals(txtApellidoProfe.Text, null) &&
                !Object.ReferenceEquals(txtDocumentoProfe.Text, null) &&
                !Object.ReferenceEquals(dtpFechaIngreso.Text, null) &&
                !Object.ReferenceEquals(cmbDivisionCurso.Text, null) &&
                !Object.ReferenceEquals(nudAnioCurso.Value, null))
            {
                Profesor profesor = new Profesor( txtNombreProfe.Text,
                                                  txtApellidoProfe.Text,
                                                  txtDocumentoProfe.Text,
                                                  dtpFechaIngreso.Value);
                Divisiones division;
                Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);

                curso = new Curso((short)nudAnioCurso.Value, division, profesor);
                this.limpiar();
            }
        }

        private void cmbDivisionCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = (string)curso;
        }

        private void limpiar()
        {
            txtApellidoProfe.Text = "";
            txtNombreProfe.Text = "";
            txtDocumentoProfe.Text = "";
            nudAnioCurso.Value = 0;
            dtpFechaIngreso.Value = DateTime.Now;
        }
    }
}
