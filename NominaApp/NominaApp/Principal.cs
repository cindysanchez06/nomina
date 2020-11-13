using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        // Se abre el formulario de buscar empleado por cedula
        private void porEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEmpleadosCedula = new EmpleadoCedula();
            formEmpleadosCedula.Show();
        }
        // Se abre el formulario de generacion de nomina
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Se abre el formulario de crear empleado
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEmpleados = new Form1();
            formEmpleados.Show();
        }

    }
}
