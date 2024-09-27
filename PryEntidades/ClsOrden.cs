using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsOrden
    {
        #region variablesprivadas
        private string Cod_Orden, Cod_Cita, Diagnostico, Medicamento, Recomendacion, Remision;
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion
        #region variablesplublicas
        public string Cod_Orden1 { get => Cod_Orden; set => Cod_Orden = value; }
        public string Cod_Cita1 { get => Cod_Cita; set => Cod_Cita = value; }
        public string Diagnostico1 { get => Diagnostico; set => Diagnostico = value; }
        public string Medicamento1 { get => Medicamento; set => Medicamento = value; }
        public string Recomendacion1 { get => Recomendacion; set => Recomendacion = value; }
        public string Remision1 { get => Remision; set => Remision = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion

        #region constructores
        public ClsOrden(string cod_Orden, string cod_Cita, string diagnostico, string medicamento, string recomendacion, string remision)
        {
            Cod_Orden = cod_Orden;
            Cod_Cita = cod_Cita;
            Diagnostico = diagnostico;
            Medicamento = medicamento;
            Recomendacion = recomendacion;
            Remision = remision;
        }
        #endregion

    }
}
