using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        // Ejecuta la nomina de el usuario por cedula, si no lo encuentra muestra error.
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpia la tabla
            dataGridView1.Rows.Clear();
            string cedula = inputCedula.Text;

            // busca empleado
            Models.Empleado empleadoSeleccionado = Models.Empleados.ObtenerEmpleados().Where(em => em.cedula == cedula).FirstOrDefault();
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No Se encontro el empleado.");
                return;
            }

            // Crea nomina del usuario
            Models.EjecutarNomina nomina = new Models.EjecutarNomina(empleadoSeleccionado);

            nomina.CrearNomina();
            Models.Calculadora nominaEmpleado = nomina.ObtenerNomina();

            
            dataGridView1.Rows.Add();
            int i = dataGridView1.Rows.Count - 1;
            // Llena los datos de la tabla con los datos de la nomina del empleado
            dataGridView1[0, i].Value = empleadoSeleccionado.cedula;
            dataGridView1[1, i].Value = empleadoSeleccionado.nombre;
            dataGridView1[2, i].Value = convertNumber(nominaEmpleado.basico);
            dataGridView1[3, i].Value = convertNumber(nominaEmpleado.auxilio);
            dataGridView1[4, i].Value = convertNumber(nominaEmpleado.nhed);
            dataGridView1[5, i].Value = convertNumber(nominaEmpleado.nhen);
            dataGridView1[6, i].Value = convertNumber(nominaEmpleado.nhedd);
            dataGridView1[7, i].Value = convertNumber(nominaEmpleado.nhedn);
            dataGridView1[8, i].Value = convertNumber(nominaEmpleado.nhrn);
            dataGridView1[9, i].Value = convertNumber(nominaEmpleado.totalExtras);
            dataGridView1[10, i].Value = convertNumber(nominaEmpleado.totalDevengado);
            dataGridView1[11, i].Value = convertNumber(nominaEmpleado.salud);
            dataGridView1[12, i].Value = convertNumber(nominaEmpleado.pension);
            dataGridView1[13, i].Value = convertNumber(nominaEmpleado.fondoSolidario);
            dataGridView1[14, i].Value = convertNumber(nominaEmpleado.uvt);
            dataGridView1[15, i].Value = convertNumber(nominaEmpleado.retefuente);
            dataGridView1[16, i].Value = convertNumber(nominaEmpleado.deducido);
            dataGridView1[17, i].Value = convertNumber(nominaEmpleado.neto);


        }

        // Formateo de numeros, redondeados y con formato de moneda
        private String convertNumber(Double number)
        {
            return Math.Round(number).ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
