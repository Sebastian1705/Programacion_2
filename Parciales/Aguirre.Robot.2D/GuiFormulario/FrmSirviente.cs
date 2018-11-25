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

namespace GuiFormulario
{
    public partial class FrmSirviente : Form
    {
        

        public FrmSirviente()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (!(lblEnergia.Text is null) && !(lblOrigen.Text is null))
            {
                int energia;
                if(int.TryParse(lblEnergia.Text, out energia))
                {
                    RobotSirviente nuevoRobot = new RobotSirviente(energia, lblOrigen.Text);
                   
                    MessageBox.Show(nuevoRobot.ServirHumanidad());
                    
                        
                }
                else
                    MessageBox.Show("No se creo robot");
            }
        }
    }
}
