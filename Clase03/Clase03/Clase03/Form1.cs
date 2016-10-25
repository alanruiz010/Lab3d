using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  this.textBox1.Text = "Presionaste el Boton 1 - ";
            // MessageBox.Show("Presionaste el Boton 1 - ");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  this.textBox1.Text = "Presionaste el Boton 2 - ";
           // MessageBox.Show("Presionaste el Boton 2 - ");
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Agrego los eventos para poder utilziar los botones
            //  this.button1.Click += this.button1_Click;

            // this.button2.Click += this.button2_Click;
            //Sacando la funcionalidad del boton3 evito los cuadros repetitivos de los eventos
            // this.button3.Click -= this.button3_Click;
            //
            MessageBox.Show("nada");
        }
        private void Form1_Load(object sender, EventArgs e)
        {   //Saco Los eventos de los botones en forma manual 
            //por mas que cliqueé no va a cargar los textbox
            //this.button1.Click -= this.button1_Click;

            //this.button2.Click -= this.button2_Click;

            //---------------otro ejemplo
            //Centralizo los eventos  de los botones a 1 solo metodo 
            this.button1.Click += this.Manejador_Central;
            this.button2.Click += this.Manejador_Central;
            this.pictureBox1.Click += this.Manejador_Central;
        }

       
        //Creo mi propio metodo Manejador Central
        //los parametros deben estar siemppre
        public void Manejador_Central(object sender, EventArgs e)
        {
            Button botonEmisor = (Button)sender;

            if (sender is Button)
            {
                MessageBox.Show("El objeto SeNder[parametro] es del tipo button");
            }
                if (botonEmisor.Name == "button1")
                    MessageBox.Show("Presionaste el Boton 1 - ");
                else 
                    MessageBox.Show("Presionaste el Boton 2 - ");
              
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
