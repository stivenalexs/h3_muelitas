using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocio;
using PryLogicaNegocios;
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
    public partial class FrmPerfil : Form
    {
        //objetos persona
        ClsPersona persona = new ClsPersona();
        ClsPersonaLn personaLn = new ClsPersonaLn();
        //objetos paciente
        ClsPaciente paciente = new ClsPaciente();
        ClsPacienteLn pacienteLn = new ClsPacienteLn();
        //objetos profesional
        ClsProfecional profesional = new ClsProfecional();
        ClsProfecionalLn profecionalLn = new ClsProfecionalLn();
        //objetos profesional
        ClsAdministrador admin = new ClsAdministrador();
        ClsAdministradorLn adminln = new ClsAdministradorLn();
        //formulario de inicio
        Form inicio = new Form();

        public FrmPerfil(ClsPersona p, Form f)
        {
            InitializeComponent();
            persona = p;
            inicio = f;
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            ClsControl.identificar(persona, personaLn, paciente, pacienteLn, profesional, profecionalLn, admin, adminln);
            if (admin.Clave1 != null)
            {
                Frm_inicio_admin inicio_Admin = new Frm_inicio_admin(admin,panel1);
                ClsControl.AbrirFormulario(inicio_Admin, panel1);
            }
            else
            {
                FrmPerfil_Inicio perfil_Inicio = new FrmPerfil_Inicio(persona, panel1);
                ClsControl.AbrirFormulario(perfil_Inicio, panel1);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            ClsControl.identificar(persona, personaLn, paciente, pacienteLn, profesional, profecionalLn, admin, adminln);
            if (admin.Clave1 != null)
            {
                Frm_inicio_admin inicio_Admin = new Frm_inicio_admin(admin, panel1);
                ClsControl.AbrirFormulario(inicio_Admin, panel1);
            }
            else
            {
                FrmPerfil_Inicio perfil_Inicio = new FrmPerfil_Inicio(persona, panel1);
                ClsControl.AbrirFormulario(perfil_Inicio, panel1);
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            
            if (paciente.Tipo_documento1 != null)
            {
                FrmDatosPerfil Inicio = new FrmDatosPerfil(persona);
                ClsControl.AbrirFormulario(Inicio, panel1);
            }
            else if (profesional.Horario1 != null)
            {
                FrmDatosPerfil Inicio = new FrmDatosPerfil(persona);
                ClsControl.AbrirFormulario(Inicio, panel1);
            }
            else if (admin.Clave1 != null)
            {
                FrmDatosPerfil Inicio = new FrmDatosPerfil(persona);
                ClsControl.AbrirFormulario(Inicio, panel1);
            }
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {
            //if (indentificar() == 1)
            //{
            //    cita cita = new cita(panel1, paciente);
            //    ClsControl.AbrirFormulario(cita, panel1);
            //}
            //else if (indentificar() == 2)
            //{
            //    lista_pacientes lista = new lista_pacientes(profesional, panel1);
            //    ClsControl.AbrirFormulario(lista, panel1);
            //}
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            //if (indentificar() == 1)
            //{
            //    Historial_clinico historial = new Historial_clinico(paciente);
            //    ClsControl.AbrirFormulario(historial, panel1);
            //}
            //else if (indentificar() == 2)
            //{
            //    Historial_clinico historial = new Historial_clinico(profesional);
            //    ClsControl.AbrirFormulario(historial, panel1);
            //}
        }

        


    }
}
