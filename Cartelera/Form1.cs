using System;
using HorarioFyF;
using HorarioBW;
using HorarioSilencio;
using System.Windows.Forms;

namespace Cartelera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * La instrucción que tiene todos los botones en este código es mostrar 
         * la ventana del horario y sinopsis de la pelicula dependiendo a cual
         * se le de click
         */
        private void btnRyF_Click(object sender, EventArgs e)
        {
            FormHorarioFyF formhorariofyf = new FormHorarioFyF(this);
            formhorariofyf.Show();
            this.Hide();
           
        }

        private void btnRyF2_Click(object sender, EventArgs e)
        {
            FormHorarioFyF formhorariofyf = new FormHorarioFyF(this);
            formhorariofyf.Show();
            this.Hide();
          
        }

        private void btnBW_Click(object sender, EventArgs e)
        {
            FormHorarioBW formhorariobw = new FormHorarioBW(this);
            formhorariobw.Show();
            this.Hide();
        }

        private void btnBW2_Click(object sender, EventArgs e)
        {
            FormHorarioBW formhorariobw = new FormHorarioBW(this);
            formhorariobw.Show();
            this.Hide();
        }

        private void btnSilencio_Click(object sender, EventArgs e)
        {
            FormHorarioSilencio formsilencio = new FormHorarioSilencio(this);
            formsilencio.Show();
            this.Hide();

        }

        private void btnSilencio2_Click(object sender, EventArgs e)
        {
            FormHorarioSilencio formsilencio = new FormHorarioSilencio(this);
            formsilencio.Show();
            this.Hide();
        }
    }
}
