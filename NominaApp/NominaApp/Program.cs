using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());


            Models.Empleados.AgregarEmpleado(new Models.Empleado()
            {
                 cedula= "11334500",
                 sueldo= 12000000,
                 diasTrabajos= 30,
                 nhed= 7,
                 nhen= 5,
                 nhedd= 6,
                 nhedn= 4,
                 nhrn= 15,
                 id= Guid.NewGuid().ToString(),
                 nombre= "CARLOS PEREZ",
                 nivelARP= "CLASE V"
            });

            foreach (var item in Models.Empleados.ObtenerEmpleados())
            {
                Models.EjecutarNomina nominaEmpleado = new Models.EjecutarNomina(item);
                nominaEmpleado.CrearNomina();
                var nomina = nominaEmpleado.ObtenerNomina();
                Console.WriteLine(nomina);
            }
        }
    }
}
