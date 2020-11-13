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
    public partial class Form1 : Form
    {
        public List<Models.Empleado> ListaEmpleados;
        public Form1()
        {
            InitializeComponent();
            ListaEmpleados = new List<Models.Empleado>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Models.Empleado empleado = new Models.Empleado();
            empleado.cedula = inputCedula.Text;

            ListaEmpleados.Add(empleado);
        }
    }
}
