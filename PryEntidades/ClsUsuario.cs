using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEntidades
{
    public class ClsUsuario
    {
        private string foto = "";
        private int numero_contacto;
        private int numero_documento = 0;
        private string nombre;
        private string correo_electronico;
        private string contraseña;
        private int edad;
        private string tipoSangre;

        public ClsUsuario(string foto, int numero_contacto, int numero_documento, string nombre, string correo_electronico, string contraseña, int edad, string tipoSangre)
        {
            this.Foto = foto;
            this.Numero_contacto = numero_contacto;
            this.Numero_documento = numero_documento;
            this.Nombre = nombre;
            this.Correo_electronico = correo_electronico;
            this.Contraseña = contraseña;
            this.Edad = edad;
            this.TipoSangre = tipoSangre;
        }

        public string Foto { get => foto; set => foto = value; }
        public int Numero_contacto { get => numero_contacto; set => numero_contacto = value; }
        public int Numero_documento { get => numero_documento; set => numero_documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Edad { get => edad; set => edad = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
    }
}
