using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocio;
using PryPresentacion.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class Frm_inicio_admin : Form
    {
        ClsAdministrador administrador = new ClsAdministrador();
        ClsPersona persona = new ClsPersona();
        ClsPersonaLn personaLn = new ClsPersonaLn();
        Panel panel;
        public Frm_inicio_admin(ClsAdministrador a, Panel p)
        {
            InitializeComponent();
            administrador = a;
            persona.ID_Persona1 = administrador.ID_Persona1;
            panel = p;
        }

        private void Frm_inicio_admin_Load(object sender, EventArgs e)
        {
            personaLn.Read(ref persona);
            if (!string.IsNullOrEmpty(persona.Foto))
            {
                string dir = System.Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.LastIndexOf("bin")) + "Resources\\" + persona.Foto;
                pb_foto.Image = Image.FromFile(dir);
            }
            lb_bien.Text = $"Bienvenido {persona.Nombre}";
        }

        private void btn_pacientes_Click(object sender, EventArgs e)
        {
            Frmgestionarpacientes pacientes = new Frmgestionarpacientes();
            ClsControl.AbrirFormulario(pacientes, panel);
        }

        private void btn_profesionales_Click(object sender, EventArgs e)
        {
            Fmrgestionarprofecionales profesionales = new Fmrgestionarprofecionales();
            ClsControl.AbrirFormulario(profesionales, panel);
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            Frmmodificarhorario horario = new Frmmodificarhorario();
            ClsControl.AbrirFormulario(horario, panel);
        }

        private void btn_nomina_Click(object sender, EventArgs e)
        {
            Frmnomina nomina = new Frmnomina();
            ClsControl.AbrirFormulario(nomina, panel);
        }
    }
}
