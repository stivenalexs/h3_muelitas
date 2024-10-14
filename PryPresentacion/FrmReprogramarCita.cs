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
    public partial class FrmReprogramarCita : Form
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
        public FrmReprogramarCita(ClsPersona p)
        {
            InitializeComponent();
            persona = p;
        }

        private void FrmReprogramarCita_Load(object sender, EventArgs e)
        {
            CargarListacitas();
        }
        private void CargarListacitas()
        {

            citaLn.Buscar_Citas_Paciente(ref cita, persona.ID_Persona1);
            if (cita.MensajeError == null)
            {
                dtvListaCitas.DataSource = cita.DtResultados;
            }
            else
            {
                MessageBox.Show(cita.MensajeError, "Error citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reprogramar_Click(object sender, EventArgs e)
        {
            cita = new ClsCita()
            {
                Cod_Cita1 = int.Parse(txb_codigo.Text),
                Fecha_Cita1 = DateTime.Parse(date_fecha.Text),
                Hora_Cita1 = TimeSpan.Parse(date_hora.Text)
            };
            citaLn.Reprogramar(ref cita);
            if (cita.MensajeError == null)
            {
                MessageBox.Show("la cita fue reprogramada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListacitas();
            }
            else
            {
                MessageBox.Show(cita.MensajeError, "Error cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cita = new ClsCita()
                {
                    Cod_Cita1 = int.Parse(txb_codigo.Text)
                };
                citaLn.Delete(ref cita);
                if (cita.MensajeError == null)
                {
                    MessageBox.Show("la cita fue ELIMINADA correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListacitas();
                }
                else
                {
                    MessageBox.Show(cita.MensajeError, "Error cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsControl.solo_numeros(e);
        }
    }
}
