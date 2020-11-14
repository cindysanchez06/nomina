using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaApp.Models
{
    public class Empleado
    {
        public string id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string nivelARP { get; set; }
        public double sueldo { get; set; }
        public int diasTrabajos { get; set; }
        public int nhed { get; set; }
        public int nhen { get; set; }
        public int nhedd { get; set; }
        public int nhedn { get; set; }
        public int nhrn { get; set; }
    }
}
