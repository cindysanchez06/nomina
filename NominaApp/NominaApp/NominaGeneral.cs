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
    public partial class NominaGeneral : Form
    {
        public NominaGeneral()
        {
            InitializeComponent();
        }
        // Ejecutar nomina de todos los empleados
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // Se obtiene todos los empleados y se agregan a la grilla todos los datos de la nomina. 
            foreach (var empleadoSeleccionado in Models.Empleados.ObtenerEmpleados())
            {

                Models.EjecutarNomina nomina = new Models.EjecutarNomina(empleadoSeleccionado);

                nomina.CrearNomina();
                Models.Calculadora nominaEmpleado = nomina.ObtenerNomina();


                dataGridView1.Rows.Add();
                int i = dataGridView1.Rows.Count - 1;

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

        }
        // Convierte el numero, lo redondea y lo formatea en moneda.
        private String convertNumber(Double number) {
            return Math.Round(number).ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
