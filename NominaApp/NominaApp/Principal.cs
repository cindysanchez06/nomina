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
            Models.Empleados.AgregarEmpleado(new Models.Empleado()
            {
                cedula = "113345",
                sueldo = 877803,
                diasTrabajos = 30,
                nhed = 9,
                nhen = 2,
                nhedd = 5,
                nhedn = 9,
                nhrn = 12,
                id = Guid.NewGuid().ToString(),
                nombre = "CARLOS PEREZ",
                nivelARP = "CLASE IV"
            });

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NominaEmpleado empleado = new NominaEmpleado();

            empleado.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 empleado = new Form1();

            empleado.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NominaGeneral nominaGeneral = new NominaGeneral();
            nominaGeneral.Show();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 empleado = new Form1();
            empleado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NominaEmpleado empleado = new NominaEmpleado();

            empleado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NominaGeneral nominaGeneral = new NominaGeneral();
            nominaGeneral.Show();
        }
    }
}
