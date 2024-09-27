using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsProcedimiento
    {
        #region variablesprivadas
        private string Cod_Procedimiento, Tipo_P, Estado_P, Pro_Asignado;
        private DateTime Fecha_P;
        private TimeSpan Hora_P;        
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        #region variablespublicas
        public string Cod_Procedimiento1 { get => Cod_Procedimiento; set => Cod_Procedimiento = value; }
        public string Tipo_P1 { get => Tipo_P; set => Tipo_P = value; }
        public string Estado_P1 { get => Estado_P; set => Estado_P = value; }
        public string Pro_Asignado1 { get => Pro_Asignado; set => Pro_Asignado = value; }
        public DateTime Fecha_P1 { get => Fecha_P; set => Fecha_P = value; }
        public TimeSpan Hora_P1 { get => Hora_P; set => Hora_P = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion

        #region constructor
        public ClsProcedimiento(string cod_Procedimiento, string tipo_P, string estado_P, string pro_Asignado, DateTime fecha_P, TimeSpan hora_P)
        {
            Cod_Procedimiento = cod_Procedimiento;
            Tipo_P = tipo_P;
            Estado_P = estado_P;
            Pro_Asignado = pro_Asignado;
            Fecha_P = fecha_P;
            Hora_P = hora_P;
        }
        #endregion

    }
}
