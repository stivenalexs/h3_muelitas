using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsCita
    {
        #region VariablesPrivadas
        private string Cod_Cita;
        private string Doc_Paciente;
        private string Doc_Profesional;
        private DateTime Fecha_Cita;
        private TimeSpan Hora_Cita;
        private string Estado;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        #region VariablesPublicas
        public ClsCita(string doc_Paciente,
        string doc_Profesional, DateTime fecha_Cita,
        TimeSpan hora_Cita, string estado)
        {
            Doc_Paciente1 = doc_Paciente;
            Doc_Profesional1 = doc_Profesional;
            Fecha_Cita1 = fecha_Cita;
            Hora_Cita1 = hora_Cita;
            Estado1 = estado;
        }
         public ClsCita()  { }

        public string Cod_Cita1 { get => Cod_Cita; set => Cod_Cita = value; }
        public string Doc_Paciente1 { get => Doc_Paciente; set => Doc_Paciente = value; }
        public string Doc_Profesional1 { get => Doc_Profesional; set => Doc_Profesional = value; }
        public DateTime Fecha_Cita1 { get => Fecha_Cita; set => Fecha_Cita = value; }
        public TimeSpan Hora_Cita1 { get => Hora_Cita; set => Hora_Cita = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        #endregion
    }
}
