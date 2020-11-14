using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaApp.Models
{
    public static class Empleados
    {
        public static List<Empleado> empleados = new List<Empleado>();

        public static List<Empleado> ObtenerEmpleados() {
            return empleados;
        } 
        
        public static Empleado ObtenerEmpleado(string id) {
            return empleados.FirstOrDefault(e => e.id == id);
        }

        public static Empleado AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
            return empleado;
        }

        public static Empleado EditarEmpleado(Empleado empleado)
        {
            int index = empleados.FindIndex(e => e.id == empleado.id);

            empleados[index] = empleado;
            return empleado;
        }

        public static void EliminarEmpleado(Empleado empleado)
        {
            Empleado empleadoEliminar = empleados.Where(e => e.id == empleado.id).FirstOrDefault();
            empleados.Remove(empleadoEliminar);
        }
    }
}
