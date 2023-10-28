using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DuplicarLabel
{
    public partial class Form1 : Form
    {
        int Velocidad = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            SoundPlayer Boca = new SoundPlayer();
            Boca.SoundLocation = "C:/Users/Usuario/Downloads/CarpetaBoca/Cancionboca.wav";
            Boca.Play();

            btnIniciar.Visible = false; 
            Figura F1 = new Figura();
            F1.PasoH = 10;
            F1.PasoV = 10;
            F1.PosicionH = 0;
            F1.PosicionV = 0;
            F1.Figur.BackColor = Color.Blue;
            F1.Figur.Text = "";
            F1.Figur.Width = 100;
            F1.Figur.Height = 100;
            Controls.Add(F1.Figur);

            Figura F2 = new Figura();
            F2.PasoH = 10;
            F2.PasoV = 5;
            F2.PosicionH = 250;
            F2.PosicionV = 250;
            F2.Figur.BackColor = Color.Yellow;
            F2.Figur.Text = "";
            F2.Figur.Height = 100;
            F2.Figur.Width = 100;    
            Controls.Add(F2.Figur);

            for (int i = 0; i < 10000; i++)
            {
                F1.Mover(this.Width, this.Height);
                F2.Mover(this.Width, this.Height);

                await Task.Delay(Velocidad);
            }

        }
    }
}
