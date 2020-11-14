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

        public string idSelected;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputCedula.Text) || string.IsNullOrEmpty(inputNombre.Text) || string.IsNullOrEmpty(inputSueldo.Text) || string.IsNullOrEmpty(inputDiasTrabajados.Text) || string.IsNullOrEmpty(inputNhed.Text) || string.IsNullOrEmpty(inputNhen.Text) || string.IsNullOrEmpty(inputNhedd.Text) || string.IsNullOrEmpty(inputNhedn.Text) || string.IsNullOrEmpty(inputNhrn.Text) || string.IsNullOrEmpty(comboBoxARP.Text))
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
                empleado.nivelARP = comboBoxARP.Text;
                if (string.IsNullOrEmpty(idSelected))
                {
                    empleado.id = Guid.NewGuid().ToString();
                    Models.Empleados.AgregarEmpleado(empleado);
                }
                else
                {
                    empleado.id = idSelected;
                    Models.Empleados.EditarEmpleado(empleado);
                }
                this.LlenarGrilla();
                this.LimpiarElementos();
                idSelected = null;
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
                dataGridEmpleados[9, i].Value = empleado.id;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridEmpleados.SelectedRows.Count > 0)
            {
                idSelected = dataGridEmpleados.SelectedRows[0].Cells[9].Value.ToString();
                Models.Empleado empleado = Models.Empleados.ObtenerEmpleado(idSelected);

                inputCedula.Text = empleado.cedula;
                inputNombre.Text = empleado.nombre;
                inputSueldo.Text = empleado.sueldo.ToString();
                inputDiasTrabajados.Text = empleado.diasTrabajos.ToString() ;
                inputNhed.Text = empleado.nhed.ToString();
                inputNhen.Text =  empleado.nhen.ToString();
                inputNhedd.Text =  empleado.nhedd.ToString() ;
                inputNhedn.Text = empleado.nhedn.ToString() ;
                inputNhrn.Text =  empleado.nhrn.ToString() ;
                comboBoxARP.Text = empleado.nivelARP;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }

        public void LimpiarElementos()
        {
            inputCedula.Clear();
            inputNombre.Clear();
            inputSueldo.Clear();
            inputDiasTrabajados.Clear();
            inputNhed.Clear();
            inputNhen.Clear();
            inputNhedd.Clear();
            inputNhedn.Clear();
            inputNhrn.Clear();
            comboBoxARP.SelectedIndex = -1;
        }
    }
}
