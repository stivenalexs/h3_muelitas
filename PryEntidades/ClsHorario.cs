using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsHorario
    {
        #region VariablesPrivadas
        private string ID_Horario;
        private TimeSpan Hora_Entrada;
        private TimeSpan Hora_Salida;
        private string Especialidad;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        #region VariablesPublicas
        public ClsHorario(string iD_Horario, TimeSpan hora_Entrada, TimeSpan hora_Salida, string especialidad)
        {
            ID_Horario1 = iD_Horario;
            Hora_Entrada1 = hora_Entrada;
            Hora_Salida1 = hora_Salida;
            Especialidad1 = especialidad;
        }

        public string ID_Horario1 { get => ID_Horario; set => ID_Horario = value; }
        public TimeSpan Hora_Entrada1 { get => Hora_Entrada; set => Hora_Entrada = value; }
        public TimeSpan Hora_Salida1 { get => Hora_Salida; set => Hora_Salida = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        #endregion
    }
}
