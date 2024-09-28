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
    public partial class FrmPerfil_Inicio : Form
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
        //panel
        Panel panel;
        public FrmPerfil_Inicio( ClsPersona person, Panel pa)
        {
            InitializeComponent();
            persona = person;
            panel = pa;
            ClsControl.identificar(persona,personaLn,paciente,pacienteLn,profesional,profecionalLn,admin,adminln);
        }
        
        private void FrmPerfil_Inicio_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(persona.Foto))
            {
                string dir = System.Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.LastIndexOf("bin")) + "Resources\\" + persona.Foto;
                pb_foto.Image = Image.FromFile(dir);
            }
            lb_bien.Text = $"Bienvenido {persona.Nombre}";
            //ocultar botones dependiendo de tipo de usuario
            if (paciente.Tipo_documento1 != null)
            {
                btn_citasp.Visible = false;
                btn_citasp.Enabled = false;
                btn_seguimiento.Visible = false;
                btn_seguimiento.Enabled = false;
                btn_Procedimiento.Visible = false;
                btn_Procedimiento.Enabled = false;
            }

            else if (profesional.Horario1 != null)
            {
                lb_c.Visible = false;
                btn_pagos.Visible = false;
                btn_pagos.Enabled = false;
                btn_agendar.Visible = false;
                btn_agendar.Enabled = false;
                btn_reprogramar.Visible = false;
                btn_reprogramar.Enabled = false;
                btn_cancelar.Visible = false;
                btn_cancelar.Enabled = false;
            }
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            FrmPagos frmPagos = new FrmPagos();
            ClsControl.AbrirFormulario(frmPagos, panel);
        }

        private void btn_Procedimiento_Click(object sender, EventArgs e)
        {
            FrmProcedimiento FrmProcedimiento = new FrmProcedimiento();
            ClsControl.AbrirFormulario(FrmProcedimiento, panel);
        }

        private void btn_seguimiento_Click(object sender, EventArgs e)
        {
            FrmHistorialClinico FrmListaPaciente = new FrmHistorialClinico();
            ClsControl.AbrirFormulario(FrmListaPaciente, panel);
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            FrmAgendar frmAgendar = new FrmAgendar();
            ClsControl.AbrirFormulario(frmAgendar, panel);
        }

        private void btn_reprogramar_Click(object sender, EventArgs e)
        {
            FrmReprogramarCita frmReprogramarCita = new FrmReprogramarCita();
            ClsControl.AbrirFormulario(frmReprogramarCita, panel);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            FrmCancelarCita frmCancelarCita = new FrmCancelarCita();
            ClsControl.AbrirFormulario(frmCancelarCita, panel);
        }

        private void btn_citasp_Click(object sender, EventArgs e)
        {
            FrmCitaPendiente citaPendiente = new FrmCitaPendiente();
            ClsControl.AbrirFormulario(citaPendiente, panel);
        }
    }
}
