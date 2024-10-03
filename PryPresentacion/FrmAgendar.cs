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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmAgendar : Form
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
        //objetos cita
        ClsCita cita = new ClsCita();
        ClsCitaLn citaLn = new ClsCitaLn();
        public FrmAgendar(ClsPersona p)
        {
            InitializeComponent();
            persona = p;
            paciente.Documento_Pa1 = persona.ID_Persona1;
            pacienteLn.Read(ref paciente);
        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {
            //llenar los tipos de cita en combo box
            cmb_tipocita.Items.Add("Odontología general");
            cmb_tipocita.Items.Add("Cirugía maxilofacial");
            cmb_tipocita.Items.Add("Odontopediatría");
            cmb_tipocita.Items.Add("Ortodoncia");
            cmb_tipocita.Items.Add("Periodoncia");
            cmb_tipocita.Items.Add("Prostodoncia");
            cmb_tipocita.Items.Add("Cardiología");
            cmb_tipocita.Items.Add("Pediatría");
            cmb_tipocita.Items.Add("Dermatología");
            cmb_tipocita.Items.Add("Neurología");
            cmb_tipocita.Items.Add("Ginecología");
            //fecha minima a elegir
            date_fecha.MinDate = DateTime.Today;
        }

        private void cmb_tipocita_SelectedIndexChanged(object sender, EventArgs e)
        {
            profecionalLn.buscar_profesionales(ref profesional, cmb_tipocita.Text);
            ClsControl.LlenarComboBox(profesional, cmb_profesional);
            //limitar horas 
            switch (cmb_tipocita.Text)
            {
                case "Odontología general":
                    date_hora.MinDate = DateTime.Today.AddHours(8);
                    date_hora.MaxDate = DateTime.Today.AddHours(14);
                    date_hora.Enabled = true;
                    break;
                case "Cirugía maxilofacial":
                    date_hora.MinDate = DateTime.Today.AddHours(9);
                    date_hora.MaxDate = DateTime.Today.AddHours(15);
                    date_hora.Enabled = true;
                    break;
                case "Odontopediatría":
                    date_hora.MinDate = DateTime.Today.AddHours(10);
                    date_hora.MaxDate = DateTime.Today.AddHours(16);
                    date_hora.Enabled = true;
                    break;
                case "Ortodoncia":
                    date_hora.MinDate = DateTime.Today.AddHours(7);
                    date_hora.MaxDate = DateTime.Today.AddHours(13);
                    date_hora.Enabled = true;
                    break;
                case "Periodoncia":
                    date_hora.MinDate = DateTime.Today.AddHours(11);
                    date_hora.MaxDate = DateTime.Today.AddHours(17);
                    date_hora.Enabled = true;
                    break;
                case "Prostodoncia":
                    date_hora.MinDate = DateTime.Today.AddHours(12);
                    date_hora.MaxDate = DateTime.Today.AddHours(18);
                    date_hora.Enabled = true;
                    break;
                case "Cardiología":
                    date_hora.MinDate = DateTime.Today.AddHours(8);
                    date_hora.MaxDate = DateTime.Today.AddHours(14);
                    date_hora.Enabled = true;
                    break;
                case "Pediatría":
                    date_hora.MinDate = DateTime.Today.AddHours(9);
                    date_hora.MaxDate = DateTime.Today.AddHours(15);
                    date_hora.Enabled = true;
                    break;
                case "Dermatología":
                    date_hora.MinDate = DateTime.Today.AddHours(10);
                    date_hora.MaxDate = DateTime.Today.AddHours(16);
                    date_hora.Enabled = true;
                    break;
                case "Neurología":
                    date_hora.MinDate = DateTime.Today.AddHours(7);
                    date_hora.MaxDate = DateTime.Today.AddHours(13);
                    date_hora.Enabled = true;
                    break;
                case "Ginecología":
                    date_hora.MinDate = DateTime.Today.AddHours(11);
                    date_hora.MaxDate = DateTime.Today.AddHours(17);
                    date_hora.Enabled = true;
                    break;
                default:
                    date_hora.Enabled = false;
                    date_hora.Text = "";
                    break;
            }

        }
        private void btn_agendar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_tipocita.Text) ||
               string.IsNullOrEmpty(cmb_profesional.Text) ||
               string.IsNullOrEmpty(date_hora.Text) ||
               string.IsNullOrEmpty(date_fecha.Text))
            {
                MessageBox.Show("por favor digite todos los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cita = new ClsCita(paciente.Documento_Pa1, profesional.Documento_Pro1, DateTime.Parse(date_fecha.Text), TimeSpan.Parse(date_hora.Text),"pendiente");
                citaLn.Create(ref cita);
                if (cita.MensajeError == null)
                {
                    MessageBox.Show($"Se esta agendada la cita correctamente", "Confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(cita.MensajeError, "Error cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cmb_profesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            profecionalLn.llenar_Por_Nombre(ref profesional, cmb_profesional.Text);
        }

        private void date_hora_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
