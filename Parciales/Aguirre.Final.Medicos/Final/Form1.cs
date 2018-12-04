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
using System.Threading;

namespace Final
{
    public partial class Form1 : Form
    {
        #region Fields

        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;

        #endregion

        #region Methods

        public Form1()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",MEspecialista.Especialidad.Traumatologo);
            this.mocker = new Thread(this.MockPacientes);
            this.pacientesEnEspera = new Queue<Paciente>();
        }

        /// <summary>
        /// inicializaremos el hilo mocker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.mocker.Start();
        }

        /// <summary>
        /// el evento de cierre del formulario, dónde, si el hilo mocker aun está activo, se abortará.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mocker.IsAlive)
                this.mocker.Abort();
        }

        /// <summary>
        /// se agreguen pacientes a la cola pacientesEnEspera, haciendo un Sleep de 5000 (Thread.Sleep(5000)).
        /// </summary>
        private void MockPacientes()
        {
            pacientesEnEspera.Enqueue(new Paciente("Sebastian", "Aguirre"));
            pacientesEnEspera.Enqueue(new Paciente("Micaela", "Salega"));
            pacientesEnEspera.Enqueue(new Paciente("Nicolas", "Aguirre"));
            Thread.Sleep(5000);
        }

        /// <summary>
        /// AtenderPacientes(IMedico) será invocado por los eventos click de los botones (btnEspecialista_Click y
        /// btnGeneral_Click) pasandole el médico que corresponda(medicoEspecialista o medicoGeneral,
        /// respectivamente). En el caso de haber pacientes en espera, se deberá iniciar la atención del primer
        /// elemento de la cola.
        /// </summary>
        /// <param name="iMEdico"></param>
        private void AtenderPacientes(IMedico iMEdico)
        {
            try
            {
                if(this.pacientesEnEspera.Count > 0)
                    iMEdico.IniciarAtencion(pacientesEnEspera.Dequeue());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// FinAtencion(Paciente, Medico) mostrará por medio de un MessageBox un mensaje con el formato
        /// "Finalizó la atención de {0} por {1}!", dónde se indicará el nombre del paciente y el del médico
        /// que lo atendió, respectivamente.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        private void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show(string.Format($"Finalizó la atención de {p.ToString()} por {m.ToString()}!"));
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoGeneral);
        }

        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoEspecialista);
        }

        #endregion
    }
}
