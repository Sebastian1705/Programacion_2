using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace TestForm
{
    public partial class FrmFinal : Form
    {
        #region Fields

        Thread thread;
        int incrementoBarra;
        // Crear atributo Pila
        public Stack<Animal> animales;

        #endregion

        #region Methods

        public FrmFinal()
        {
            InitializeComponent();

            incrementoBarra = 1;
            // Instanciar Pila
            this.animales = new Stack<Animal>();
            thread = new Thread(new ParameterizedThreadStart(Animar));
        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal a01 = new Humano("Juan", DateTime.Now.AddYears(-10), Humano.Ocupacion.Infante);
                this.animales.Push(a01);
                Animal a02 = new Pez("Dory", Pez.PrincipalAlimento.Plancton);
                this.animales.Push(a02);
                Humano a03 = new Humano("Pedro", DateTime.Now.AddYears(1), Humano.Ocupacion.Infante);
                this.animales.Push(a03);
                Pez a04 = new Pez("Nemo", Pez.PrincipalAlimento.Otra);
                this.animales.Push(a04);
                Pez a05 = new Pez("Bruce", Pez.PrincipalAlimento.Carne);
                this.animales.Push(a04);
            }
            catch (FechaNacimientoInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Variable para acumular los datos de la pila
            string datos = "";
            // Vaciar la pila y mostrar su contenido en un solo String formado con StringBuilder
            foreach (Animal a in this.animales)
            {
                datos += a.ToString() + "\n";
            }
            // Se muestran los datos
            MessageBox.Show(datos);
        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread.IsAlive)
                    thread.Abort();
                else
                { 
                    thread = new Thread(new ParameterizedThreadStart(Animar));
                    thread.Start(100);
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CorrerBarra()
        {
            if (this.progressBar1.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(this.CorrerBarra);
                this.Invoke(d);
            }
            else
            {
                this.progressBar1.Value += incrementoBarra;

                // Invierto a valor
                if (this.progressBar1.Value == this.progressBar1.Maximum || this.progressBar1.Value == this.progressBar1.Minimum)
                    incrementoBarra *= -1;
            }
        }

        //Guardar un Humano y un Pez en el escritorio con los nombres de archivo “Humano.bin” y “Pez.xml” respectivamente.
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            Pez nemo = new Pez("Nemo", Pez.PrincipalAlimento.Plancton);
            Humano Seba = new Humano("Seba", DateTime.Now.AddYears(-29), Humano.Ocupacion.Estudiante);
            try
            {
                nemo.Guardar("Pez.xml", nemo);
                MessageBox.Show("Se serializo el pez");
                MessageBox.Show("Leyendo pez...");
                Pez aux = nemo.Leer("Pez.xml");
                MessageBox.Show(aux.ToString());

                Seba.Guardar("Humano.bin", Seba);
                MessageBox.Show("Se serializo el humano");
                MessageBox.Show("Leyendo humano...");
                Humano aux2 = Seba.Leer("Humano.bin");
                MessageBox.Show(aux2.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {
            Humano a = new Humano();
            a.miEvento += MetodoManejador;
            a.LanzarEvento();
        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {
            try
            {
                List<Animal> animales = new List<Animal>();
                List<Animal> animalesLeidos = new List<Animal>();
                AnimalDao dao = new AnimalDao();
                Animal a01 = new Humano("Juan", DateTime.Now.AddYears(-10), Humano.Ocupacion.Infante);
                Humano a02 = new Humano("Jose", DateTime.Now.AddYears(-20), Humano.Ocupacion.Infante);
                Humano a03 = new Humano("Pedro", DateTime.Now.AddYears(-30), Humano.Ocupacion.Infante);
                animales.Add(a01);
                animales.Add(a02);
                animales.Add(a03);

                dao.Guardar("dbo.Humano", animales);
                MessageBox.Show("Se guardo en la base...");
                animalesLeidos = dao.Leer("dbo.Humano");
                MessageBox.Show("Se leyo la base...");
                foreach(Animal item in animales)
                {
                    MessageBox.Show(item.ToString()); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Animar(object o)
        {
            while(thread.IsAlive)
            {
                this.CorrerBarra();
                Thread.Sleep((int)o);
            }        
        }

        private void FrmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread.IsAlive)
                thread.Abort();
        }

        private void MetodoManejador(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        #endregion

        #region Delegate

        delegate void CorrenCallback();

        #endregion
    }
}
