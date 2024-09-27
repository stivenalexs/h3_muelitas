using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsNomina
    {
        #region VariablesPrivadas
        private string ID_Nomina;
        private string Doc_Profesional;
        private double Salario;
        private DateTime Fecha_Pago;
        private string Estado;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        #region VariablesPublicas
        public ClsNomina(string iD_Nomina, string doc_Profesional, double salario, DateTime fecha_Pago, string estado)
        {
            ID_Nomina1 = iD_Nomina;
            Doc_Profesional1 = doc_Profesional;
            Salario1 = salario;
            Fecha_Pago1 = fecha_Pago;
            Estado1 = estado;
        }

        public string ID_Nomina1 { get => ID_Nomina; set => ID_Nomina = value; }
        public string Doc_Profesional1 { get => Doc_Profesional; set => Doc_Profesional = value; }
        public double Salario1 { get => Salario; set => Salario = value; }
        public DateTime Fecha_Pago1 { get => Fecha_Pago; set => Fecha_Pago = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        #endregion
    }
}
