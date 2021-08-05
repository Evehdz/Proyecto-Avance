using System;
using SelecciondeBoletos;
using System.Windows.Forms;

namespace HorarioBW
{
    public partial class FormHorarioBW : Form
    {
        private Form Formpa;
        //Asignamos la variable form al form que contiene el horario de la pelicula

        public FormHorarioBW(Form Formpa)
        {
            InitializeComponent();
            this.Formpa = Formpa;
        }
        //El boton regresar tiene como instruccion cerrar el form con los horarios y regresar a la cartelera
        private void btnregresar2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formpa.Show();
        }
        //Los tres botones siguientes se utilizan cuando el usuario da click en un horario y este abre la ventana de seleccion de boletos
        private void btnBWh1_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }

        private void btnBWh2_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }

        private void btnBWh3_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }
    }
}
