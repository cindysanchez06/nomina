using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaApp.Models
{
    public class EjecutarNomina
    {
        private const int DiasMes = 30;
        private const double SalarioMinimo = 877803;
        private const double auxilio = 102854;

        private Calculadora nomina;
        private Empleado empleado;
        public EjecutarNomina(Empleado empleado) {
            this.nomina = new Calculadora();
            this.empleado = empleado;
        }

        public Calculadora ObtenerNomina() {
            return nomina;
        }

        public void CrearNomina() {
            this.ObtenerSalarioBasico();
            this.ObtenerAuxilio();
            this.ObtenerValorHora();
            this.ObtenerNHED();
            this.ObtenerNHEN();
            this.ObtenerNHEDD();
            this.ObtenerNHEDN();
            this.ObtenerNHRN();
            this.ObtenerTotalExtras();
            this.ObtenerTotalDevengado();
            this.ObtenerIBC();
            this.ObtenerSalud();
            this.ObtenerPension();
            this.ObtenerSolidaridad();
            this.ObtenerNumeroUVT();
            this.ObtenerUVT();
            this.ObtenerRetefuente();
            this.ObtenerDeducido();
            this.ObtenerNeto();
            this.ObtenerSaludParafiscal();
            this.ObtenerPensionParafiscal();
            this.ObtenerARP();
            this.ObtenerSena();
            this.ObtenerICBF();
            this.ObtenerCajas();
            this.ObtenerTotalParafiscales();
            this.ObtenerPrima();
            this.ObtenerVacaciones();
            this.ObtenerCesantias();
            this.ObtenerInteresCesantias();
            this.ObtenerTotalPrestaciones();
            this.ObtenerTotalNomina();
        }

        void ObtenerSalarioBasico() {
            nomina.basico = empleado.sueldo / DiasMes * empleado.diasTrabajos; 
        }

        void ObtenerAuxilio() {
            if (empleado.sueldo <= 2*SalarioMinimo)
            {
                nomina.auxilio = auxilio/ DiasMes * empleado.diasTrabajos;
            }
        }
        void ObtenerValorHora(){
            nomina.valorHora = empleado.sueldo / 240;
        }
        void ObtenerNHED() {
            nomina.nhed = 1.25 * nomina.valorHora * empleado.nhed;
        }
        void ObtenerNHEN(){
            nomina.nhen = 1.75 * nomina.valorHora * empleado.nhen;
        }
        void ObtenerNHEDD() {
            nomina.nhedd = 2 * nomina.valorHora * empleado.nhedd;
        }
        void ObtenerNHEDN() {
            nomina.nhedn = 2.5 * nomina.valorHora * empleado.nhedn;
        }
        void ObtenerNHRN() {
            nomina.nhrn = 1.35 * nomina.valorHora * empleado.nhrn;
        }
        void ObtenerTotalExtras() {
            nomina.totalExtras = nomina.nhed + nomina.nhen + nomina.nhedd + nomina.nhedn + nomina.nhrn;
        }
        void ObtenerTotalDevengado() {
            nomina.totalDevengado = nomina.basico + nomina.auxilio + nomina.totalExtras;
        }
        void ObtenerIBC() {
            nomina.ibc = nomina.totalDevengado - nomina.auxilio;
        }
        void ObtenerSalud(){
            nomina.salud = nomina.ibc * 4 /100;
        }
        void ObtenerPension() {
            nomina.pension = nomina.ibc * 4 / 100;
        }
        void ObtenerSolidaridad(){
            if (nomina.totalDevengado >= 4 * SalarioMinimo && nomina.totalDevengado < 16 * SalarioMinimo)
            {
                nomina.fondoSolidario = nomina.totalDevengado * 1 / 100;
            }
            else if (nomina.totalDevengado >= 16 * SalarioMinimo && nomina.totalDevengado < 17 * SalarioMinimo)
            {
                nomina.fondoSolidario = nomina.totalDevengado * 1.2 / 100;
            }
            else if (nomina.totalDevengado >= 17 * SalarioMinimo && nomina.totalDevengado < 18 * SalarioMinimo)
            {
                nomina.fondoSolidario = nomina.totalDevengado * 1.4 / 100;
            }
            else if (nomina.totalDevengado >= 18 * SalarioMinimo && nomina.totalDevengado < 19 * SalarioMinimo)
            {
                nomina.fondoSolidario = nomina.totalDevengado * 1.6 / 100;
            }
            else if (nomina.totalDevengado >= 19 * SalarioMinimo && nomina.totalDevengado < 20 * SalarioMinimo)
            {
                nomina.fondoSolidario = nomina.totalDevengado * 1.8 / 100;
            }
            else if (nomina.totalDevengado >= 20)
            {
                nomina.fondoSolidario = nomina.totalDevengado * 2 / 100;
            }
            else {
                nomina.fondoSolidario = 0;
            }
        }
        void ObtenerNumeroUVT(){
            nomina.numeroUVT = (nomina.totalDevengado - (nomina.salud + nomina.pension + nomina.fondoSolidario) - ((nomina.totalDevengado - (nomina.salud + nomina.pension + nomina.fondoSolidario)) * 0.25)) / 35607;
        }
        void ObtenerUVT()
        {
            if (nomina.numeroUVT >= 0 && nomina.numeroUVT < 95) {
                nomina.uvt = 0;
            }
            else if (nomina.numeroUVT >= 95 && nomina.numeroUVT < 150 ) {
                nomina.uvt = ((nomina.numeroUVT - 95) * 19) / 100;
            }
            else if (nomina.numeroUVT >= 150 && nomina.numeroUVT < 360)
            {
                nomina.uvt = (((nomina.numeroUVT - 150) * 28) / 100) + 10;
            }
            else if (nomina.numeroUVT >= 360 && nomina.numeroUVT < 640)
            {
                nomina.uvt = (((nomina.numeroUVT - 150) * 33) / 100) + 69;
            }
            else if (nomina.numeroUVT >= 640 && nomina.numeroUVT < 945)
            {
                nomina.uvt = (((nomina.numeroUVT - 640) * 35) / 100) + 162;
            }
            else if (nomina.numeroUVT >= 945 && nomina.numeroUVT < 2300)
            {
                nomina.uvt = (((nomina.numeroUVT - 945) * 37) / 100) + 268;
            }
            else if (nomina.numeroUVT >= 2300)
            {
                nomina.uvt = (((nomina.numeroUVT - 150) * 39) / 100) + 770;
            }
        }
        void ObtenerRetefuente() {
            nomina.retefuente = nomina.uvt * 35607;
        }
        void ObtenerDeducido() {
            nomina.deducido = nomina.salud + nomina.pension + nomina.fondoSolidario + nomina.uvt + nomina.retefuente;
        }
        void ObtenerNeto() {
            nomina.neto = nomina.totalDevengado - nomina.deducido;
        }
        void ObtenerSaludParafiscal()
        {
            nomina.saludParafiscal = nomina.ibc * 8.5 / 100;
        }
        void ObtenerPensionParafiscal()
        {
            nomina.pensionParafiscal = nomina.ibc * 12 / 100;
        }
        void ObtenerARP()
        {
            if(empleado.nivelARP == "CLASE I")
            {
                nomina.arp = nomina.ibc * 0.52 / 100;
            }
            else if (empleado.nivelARP == "CLASE II")
            {
                nomina.arp = nomina.ibc * 1.04 / 100;
            }
            else if (empleado.nivelARP == "CLASE III")
            {
                nomina.arp = nomina.ibc * 2.44 / 100;
            }
            else if (empleado.nivelARP == "CLASE IV")
            {
                nomina.arp = nomina.ibc * 4.35 / 100;
            }
            else if (empleado.nivelARP == "CLASE V")
            {
                nomina.arp = nomina.ibc * 6.96 / 100;
            }
            else
            {
                nomina.arp = 0;
            }
        }
        void ObtenerSena()
        {
            nomina.sena = nomina.ibc * 2 / 100;
        }
        void ObtenerICBF()
        {
            nomina.icbf = nomina.ibc * 3 / 100;
        }
        void ObtenerCajas()
        {
            nomina.cajas = nomina.ibc * 4 / 100;
        }
        void ObtenerTotalParafiscales()
        {
            nomina.totalParafiscales = nomina.saludParafiscal + nomina.pensionParafiscal + nomina.arp + nomina.sena + nomina.icbf + nomina.cajas;
        }
        void ObtenerPrima() {
            nomina.prima = empleado.diasTrabajos * empleado.sueldo / 360;
        }
        void ObtenerVacaciones()
        {
            nomina.vacaciones = ((empleado.diasTrabajos * empleado.sueldo) + nomina.nhrn) / 720;
        }

        void ObtenerCesantias()
        {
            nomina.cesantias = empleado.diasTrabajos * empleado.sueldo / 360;
        }
        void ObtenerInteresCesantias()
        {
            nomina.interesCesantias = nomina.cesantias * 0.12;
        }
        void ObtenerTotalPrestaciones()
        {
            nomina.totalPrestaciones = nomina.prima + nomina.vacaciones + nomina.cesantias + nomina.interesCesantias;
        }
        void ObtenerTotalNomina()
        {
            nomina.totalNomina = nomina.totalDevengado + nomina.totalPrestaciones + nomina.totalParafiscales;
        }
    }
}
