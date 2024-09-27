using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsProfecional
    {
        #region Variables_privadas
        private string Documento_Pro;
        private string Horario;
        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        #endregion
        #region Constructor
        public ClsProfecional(string documento_Pro, string horario)
        {
            Documento_Pro1 = documento_Pro;
            Horario1 = horario;
        }
        public ClsProfecional()  { }
        #endregion
        #region Variables_publicas
        public string Documento_Pro1 { get => Documento_Pro; set => Documento_Pro = value; }
        public string Horario1 { get => Horario; set => Horario = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion
    }
}
