using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegado
{
    

    public partial class frmPpal : Form
    {

        
        public frmPpal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            bool salida = false;

            foreach(Form frm in this.MdiChildren ){
                if(frm is frmMensaje)
                    salida = true;
            }
            
            if(!salida){
                frmMensaje men = new frmMensaje();
                men.MdiParent = this;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmAccion)
                        ((frmAccion)frm).enviarMens += men.mostrarMensaje;
                }    
                men.Show();

            }


        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            bool salida = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmAccion)
                {
                    salida = true;
                }                    
            }

            if (!salida)
            {
                frmAccion acc = new frmAccion();
                acc.MdiParent = this;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmMensaje)
                        acc.enviarMens += ((frmMensaje)frm).mostrarMensaje;
                }
                acc.Show();
            }

        }

        public int manejoDelegado(string Metodo, int cantidad )
        {
            MessageBox.Show(Metodo);
            return cantidad;
        }
    }
}
