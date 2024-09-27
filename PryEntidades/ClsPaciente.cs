using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsPaciente
    {
        #region Variables_Privadas
        private string Documento_Pa;
        private string Tipo_documento;
        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        #endregion
        #region Constructor
        public ClsPaciente( string documento_Pa, string tipo_documento)
        {
            Documento_Pa1 = documento_Pa;
            Tipo_documento1 = tipo_documento;
        }
        public ClsPaciente() { }
        #endregion
        #region
        public string Documento_Pa1 { get => Documento_Pa; set => Documento_Pa = value; }
        public string Tipo_documento1 { get => Tipo_documento; set => Tipo_documento = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion
    }
}
