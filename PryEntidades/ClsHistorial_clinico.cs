using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsHistorial_clinico
    {
        #region variablesprivadas
        private string Doc_Paciente, Orden;
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion
        #region variablesplublicas
        public string Doc_Paciente1 { get => Doc_Paciente; set => Doc_Paciente = value; }
        public string Orden1 { get => Orden; set => Orden = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion
        #region constructor
        public ClsHistorial_clinico(string doc_Paciente, string orden)
        {
            Doc_Paciente = doc_Paciente;
            Orden = orden;
        }
        #endregion
    }
}
