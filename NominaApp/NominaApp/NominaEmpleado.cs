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
    public partial class NominaEmpleado : Form
    {
        public NominaEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string cedula = inputCedula.Text;

            Models.Empleado empleadoSeleccionado = Models.Empleados.ObtenerEmpleados().Where(em => em.cedula == cedula).FirstOrDefault();
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No Se encontro el empleado.");
                return;
            }
            Models.EjecutarNomina nomina = new Models.EjecutarNomina(empleadoSeleccionado);

            nomina.CrearNomina();
            Models.Calculadora nominaEmpleado = nomina.ObtenerNomina();

            
            dataGridView1.Rows.Add();
            int i = dataGridView1.Rows.Count - 1;

            dataGridView1[0, i].Value = empleadoSeleccionado.cedula;
            dataGridView1[1, i].Value = empleadoSeleccionado.nombre;
            dataGridView1[2, i].Value = nominaEmpleado.basico;
            dataGridView1[3, i].Value = nominaEmpleado.auxilio;
            dataGridView1[4, i].Value = nominaEmpleado.nhed;
            dataGridView1[5, i].Value = nominaEmpleado.nhen;
            dataGridView1[6, i].Value = nominaEmpleado.nhedd;
            dataGridView1[7, i].Value = nominaEmpleado.nhedn;
            dataGridView1[8, i].Value = nominaEmpleado.nhrn;
            dataGridView1[9, i].Value = nominaEmpleado.totalExtras;
            dataGridView1[10, i].Value = nominaEmpleado.totalDevengado;
            dataGridView1[11, i].Value = nominaEmpleado.salud;
            dataGridView1[12, i].Value = nominaEmpleado.pension;
            dataGridView1[13, i].Value = nominaEmpleado.fondoSolidario;
            dataGridView1[14, i].Value = nominaEmpleado.uvt;
            dataGridView1[15, i].Value = nominaEmpleado.retefuente;
            dataGridView1[16, i].Value = nominaEmpleado.deducido;
            dataGridView1[17, i].Value = nominaEmpleado.neto;


        }
    }
}
