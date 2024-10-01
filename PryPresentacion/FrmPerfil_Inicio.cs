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
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            //if (indentificar() == 1)
            //{
            //    cita cita = new cita(inicio, paciente);
            //    DB.AbrirFormulario(cita, inicio);
            //}
            //else if (indentificar() == 2)
            //{
            //    lista_pacientes lista = new lista_pacientes(profesional, inicio);
            //    DB.AbrirFormulario(lista, inicio);
            //}
        }

        private void btn_Procedimiento_Click(object sender, EventArgs e)
        {
            //if (indentificar() == 1)
            //{
            //    Historial_clinico historial = new Historial_clinico(paciente);
            //    DB.AbrirFormulario(historial, inicio);
            //}
            //else if (indentificar() == 2)
            //{
            //    Historial_clinico historial = new Historial_clinico(profesional);
            //    DB.AbrirFormulario(historial, inicio);
            //}
        }

        private void btn_seguimiento_Click(object sender, EventArgs e)
        {

        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {

        }

        private void btn_citas_Click(object sender, EventArgs e)
        {

        }
    }
}
