using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsAdministrador
    {
        #region VariablesPrivadas
        private string ID_Persona;
        private string Clave;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        #endregion

        #region VariablesPublicas
        public ClsAdministrador(string iD_Persona, string clave)
        {
            ID_Persona1 = iD_Persona;
            Clave1 = clave;
        }
        public ClsAdministrador() { }
        public string ID_Persona1 { get => ID_Persona; set => ID_Persona = value; }
        public string Clave1 { get => Clave; set => Clave = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion
    }
}
