using System;
using System.Drawing;
using SelecciondeBoletos;
using System.Windows.Forms;

namespace HorarioSilencio
{
    public partial class FormHorarioSilencio : Form
    {
        private Form Formp;
        //Asignamos la variable form al form que contiene el horario de la pelicula
        public FormHorarioSilencio(Form Formp)
        {
            InitializeComponent();
            this.Formp = Formp;
        }
        //El botón regresar tiene como instruccion cerrar el form con los horarios y regresar a la cartelera
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Formp.Show();
        }
        //Los tres botones siguientes se utilizan cuando el usuario da click en un horario y este abre la ventana de seleccion de boletos
        private void btnsilencioh1_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }

        private void btnsilencioh2_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }

        private void btnsilencioh3_Click(object sender, EventArgs e)
        {
            FormSeleccionBoletos formseleccion = new FormSeleccionBoletos();
            formseleccion.Show();
            this.Hide();
        }
    }
}
