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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputCedula.Text) || string.IsNullOrEmpty(inputNombre.Text) || string.IsNullOrEmpty(inputSueldo.Text) || string.IsNullOrEmpty(inputDiasTrabajados.Text) || string.IsNullOrEmpty(inputNhed.Text) || string.IsNullOrEmpty(inputNhen.Text) || string.IsNullOrEmpty(inputNhedd.Text) || string.IsNullOrEmpty(inputNhedn.Text) || string.IsNullOrEmpty(inputNhrn.Text))
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
            else
            {
                Models.Empleado empleado = new Models.Empleado();
                empleado.cedula = inputCedula.Text;
                empleado.nombre = inputNombre.Text;
                empleado.sueldo = double.Parse(inputSueldo.Text);
                empleado.diasTrabajos = int.Parse(inputDiasTrabajados.Text);
                empleado.nhed = int.Parse(inputNhed.Text);
                empleado.nhen = int.Parse(inputNhen.Text);
                empleado.nhedd = int.Parse(inputNhedd.Text);
                empleado.nhedn = int.Parse(inputNhedn.Text);
                empleado.nhrn = int.Parse(inputNhrn.Text);
                Models.Empleados.AgregarEmpleado(empleado);
                this.LlenarGrilla();
            }
        }

        public void LlenarGrilla()
        {
            dataGridEmpleados.Rows.Clear();
            foreach (Models.Empleado empleado in Models.Empleados.ObtenerEmpleados())
            {
                dataGridEmpleados.Rows.Add();
                int i = dataGridEmpleados.Rows.Count-1;

                dataGridEmpleados[0, i].Value = empleado.cedula;
                dataGridEmpleados[1, i].Value = empleado.nombre;
                dataGridEmpleados[2, i].Value = empleado.sueldo;
                dataGridEmpleados[3, i].Value = empleado.diasTrabajos;
                dataGridEmpleados[4, i].Value = empleado.nhed;
                dataGridEmpleados[5, i].Value = empleado.nhen;
                dataGridEmpleados[6, i].Value = empleado.nhedd;
                dataGridEmpleados[7, i].Value = empleado.nhedn;
                dataGridEmpleados[8, i].Value = empleado.nhrn;
            }
        }

    }
}
