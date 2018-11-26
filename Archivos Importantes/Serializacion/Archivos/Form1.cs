using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Archivo_Click(object sender, EventArgs e)
        {
           
        Dato p = new Dato();   //Objeto a serializar.
            p.Nombre = "Algo";
            p.Edad = 25;
            XmlTextWriter writer;  //Objeto que escribirá en XML.
            XmlSerializer ser;        //Objeto que serializará.

            writer = new XmlTextWriter("archivo.xml",Encoding.ASCII);
            //Se indica ubicación del archivo XML y su codificación.
            ser = new XmlSerializer(typeof(Dato));
            //Se indica el tipo de objeto ha serializar.
            ser.Serialize(writer, p);
            //Serializa el objeto p en el archivo contenido en writer.
            writer.Close();
            //Se cierra el objeto writer
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dato aux ;   //Objeto que alojará los datos
                                     //contenidos en el archivo XML.
            XmlTextReader reader;   //Objeto que leerá XML.
            XmlSerializer ser;            //Objeto que Deserializará.

            reader = new XmlTextReader("archivo.xml");
            //Se indica ubicación del archivo XML.
            ser = new XmlSerializer(typeof(Dato));
            //Se indica el tipo de objeto ha serializar.
            aux = (Dato)ser.Deserialize(reader);
            //Deserializa el archivo contenido en reader, lo guarda 
            //en aux.
            reader.Close();
            //Se cierra el objeto reader.
            MessageBox.Show(aux.Nombre);
            MessageBox.Show(aux.MuestraEdad.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            Dato p = new Dato();
            p.Nombre = "Mi Nombre";
            p.Edad = 25; //Objeto a serializar.
            FileStream fs;        //Objeto que escribirá en binario.
            BinaryFormatter ser;  //Objeto que serializará.

            fs = new FileStream("archivo.dat", FileMode.Create);
            //Se indica ubicación del archivo binario y el modo.
            ser = new BinaryFormatter();
            //Se crea el objeto serializador.
            ser.Serialize(fs, p);
            //Serializa el objeto p en el archivo contenido en fs.
            fs.Close();
            //Se cierra el objeto fs.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dato aux = new Dato();   //Objeto que alojará los datos
           
            
            //contenidos en el archivo binario.
            FileStream fs;                  //Objeto que leerá en binario.
            BinaryFormatter ser;      //Objeto que Deserializará.

            fs = new FileStream("Archivo.dat", FileMode.Open);
            //Se indica ubicación del archivo binario y el modo.
            ser = new BinaryFormatter();
            //Se crea el objeto deserializador.
            aux = (Dato)ser.Deserialize(fs);
            //Deserializa el archivo contenido en fs, lo guarda 
            //en aux.
            fs.Close();
            //Se cierra el objeto fs.
            MessageBox.Show(aux.Nombre);
            MessageBox.Show(aux.MuestraEdad.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCarpeta.Text))
                openFileDialog1.InitialDirectory = txtCarpeta.Text;
            if (File.Exists(txtArchivo.Text))
                openFileDialog1.FileName = txtArchivo.Text;
            openFileDialog1.Filter = " Archivo Texto| *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtArchivo.Text  = openFileDialog1.FileName;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCarpeta.Text))
                folderBrowserDialog1.SelectedPath = txtCarpeta.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtCarpeta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCarpeta.Text))
                saveFileDialog1.InitialDirectory = txtCarpeta.Text;            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                txtSave.Text = saveFileDialog1.FileName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmVisorArchivo frm = new frmVisorArchivo();
            frm.Show();
        }
    }

    [Serializable]
    public class Dato
    {
        public string Nombre;
        private int edad;
        public int Edad {
            set
            {
                this.edad = value;
            }
        }
        public int MuestraEdad
        {
            get
            {
                return this.edad ;
            }
        }

    }
}
