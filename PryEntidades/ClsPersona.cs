using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsPersona
    {
        #region variables_privadas
        private string foto = "";
        private string numero_contacto;
        private string numero_documento;
        private string nombre;
        private string correo_electronico;
        private string contraseña;
        private DateTime Fecha_N;
        private string tipoSangre;
        private string ID_Persona;
        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        #region Constructor

        public ClsPersona()
        { }
        public ClsPersona(string foto, string numero_contacto, string numero_documento, string nombre, string correo_electronico, string contraseña, DateTime fecha_N, string tipoSangre, string iD_Persona)
        {
            this.Foto = foto;
            this.Numero_contacto = numero_contacto;
            this.Numero_documento = numero_documento;
            this.Nombre = nombre;
            this.Correo_electronico = correo_electronico;
            this.Contraseña = contraseña;
            Fecha_N1 = fecha_N;
            this.TipoSangre = tipoSangre;
            ID_Persona1 = iD_Persona;
        }


        public ClsPersona (string correo_electronico, string contraseña)
        {
            this.correo_electronico = correo_electronico;
            this.contraseña = contraseña;
        }



        #endregion

        #region variables_publicas
        public string Foto { get => foto; set => foto = value; }
        public string Numero_contacto { get => numero_contacto; set => numero_contacto = value; }
        public string Numero_documento { get => numero_documento; set => numero_documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime Fecha_N1 { get => Fecha_N; set => Fecha_N = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
        public string ID_Persona1 { get => ID_Persona; set => ID_Persona = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion
    }
}
