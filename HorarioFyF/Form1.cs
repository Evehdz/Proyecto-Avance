using System;
using System.Drawing;
using SelecciondeBoletos;
using System.Windows.Forms;

namespace HorarioFyF
{

    public partial class FormHorarioFyF : Form
    {
        private Form formpadre;
       
        //Asignamos la variable form al form que contiene el horario de la pelicula
        public FormHorarioFyF(Form formpadre)
        {
            InitializeComponent();
            this.formpadre = formpadre;
        }
        //El boton regresar tiene como instruccion cerrar el form con los horarios y regresar a la cartelera
        private void btnregresar3_Click(object sender, EventArgs e)
        {
            this.Close();
            formpadre.Show();
        }
        //Los tres botones siguientes se utilizan cuando el usuario da click en un horario y este abre la ventana de seleccion de boletos
        private void btnfyfh_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }

        private void btnfyfh2_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }

        private void btnfyfh3_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }
    }
}
