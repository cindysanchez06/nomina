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
                 diasTrabajos= 22,
                 nhed= 4,
                 nhen= 5,
                 nhedd= 0,
                 nhedn= 7,
                 nhrn= 10,
                 id= Guid.NewGuid().ToString(),
                 nombre= "CARLOS PEREZ"
            });
        }
    }
}
