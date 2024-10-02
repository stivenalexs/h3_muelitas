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
using static System.Net.Mime.MediaTypeNames;

namespace PryPresentacion
{
    public partial class FrmRegistro : MaterialForm
    {
        private ClsPersona persona = new ClsPersona();
        private ClsPaciente Paciente = new ClsPaciente();
        private ClsProfecional Profesional = new ClsProfecional();

        private readonly ClsPersonaLn lnpersona = new ClsPersonaLn();
        private readonly ClsPacienteLn lnpaciente = new ClsPacienteLn();
        private readonly ClsProfecionalLn lnprofesional = new ClsProfecionalLn();
        FrmInicio f = new FrmInicio();
        string imagen = "";
        public FrmRegistro(FrmInicio form)
        {
            InitializeComponent();
            f = form;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            //tipo de usuarios
            cmb_tipo.Items.Add("paciente");
            cmb_tipo.Items.Add("profesional");
            //tipos de sangre
            cmb_sangre.Items.Add("A");
            cmb_sangre.Items.Add("B");
            cmb_sangre.Items.Add("O");
            cmb_sangre.Items.Add("AB");
            cmb_s.Items.Add("+");
            cmb_s.Items.Add("-");
            //correos
            cmb_correo.Items.Add("@gmail.com");
            cmb_correo.Items.Add("@hotmail.com");
            cmb_correo.Items.Add("@outlook.com");
            //tipos de documentos
            cmb_TipoDocumento.Items.Add("CC");
            cmb_TipoDocumento.Items.Add("TI");
            cmb_TipoDocumento.Items.Add("CE");
            cmb_TipoDocumento.Items.Add("RC");

            cmb_tp.Visible = false;
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_tp.Items.Clear();
            if (cmb_tipo.SelectedIndex == 0)
            {
                cmb_tp.Items.Clear();
                cmb_tp.Visible = false;

            }
            else if (cmb_tipo.SelectedIndex == 1)
            {
                cmb_tp.Visible = true;
                cmb_tp.Hint = "especialidad";
                cmb_tp.Items.Add("Odontología general");
                cmb_tp.Items.Add("Cirugía maxilofacial");
                cmb_tp.Items.Add("Odontopediatría");
                cmb_tp.Items.Add("Ortodoncia");
                cmb_tp.Items.Add("Periodoncia");
                cmb_tp.Items.Add("Prostodoncia");
                cmb_tp.Items.Add("Cardiología");
                cmb_tp.Items.Add("Pediatría");
                cmb_tp.Items.Add("Dermatología");
                cmb_tp.Items.Add("Neurología");
                cmb_tp.Items.Add("Ginecología");
            }
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images|*.png; *.bmp;*.jpg";
                string dir = System.Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.LastIndexOf("bin")) + "Resources\\";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dir = dir + ofd.SafeFileName;
                    imagen = ofd.SafeFileName;
                    Bitmap bitmap = new Bitmap(ofd.FileName);
                    bitmap.Save(dir);
                }
                MessageBox.Show("Imagen guardada con éxito", "Confirmación",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                pb_foto.Image = System.Drawing.Image.FromFile(dir);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible guardar la imagen por " + ex.Message,
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_documento.Text) ||
               string.IsNullOrEmpty(txb_nombre.Text) ||
               string.IsNullOrEmpty(txb_correo.Text) ||
               string.IsNullOrEmpty(cmb_s.Text) ||
               string.IsNullOrEmpty(txb_contacto.Text) ||
               string.IsNullOrEmpty(cmb_sangre.Text) ||
               string.IsNullOrEmpty(date_fechanaci.Text) ||
               string.IsNullOrEmpty(txb_contraseña.Text) ||
               string.IsNullOrEmpty(cmb_TipoDocumento.Text)||
               string.IsNullOrEmpty(cmb_correo.Text) ||
               string.IsNullOrEmpty(cmb_s.Text)

               )
            {
                MessageBox.Show("por favor digite todos los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    persona = new ClsPersona(imagen, txb_contacto.Text, txb_documento.Text,
                        txb_nombre.Text, txb_correo.Text,txb_contraseña.Text,Convert.ToDateTime(date_fechanaci.Text), cmb_sangre.Text,
                        txb_documento.Text) ;
                    lnpersona.Create(ref persona);
                    if (persona.MensajeError==null)
                    {
                        MessageBox.Show($"Se esta cargando el perfil", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(persona.MensajeError, "Error Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (cmb_tipo.Text == "paciente")
                    {
                        Paciente = new ClsPaciente(txb_documento.Text, cmb_TipoDocumento.Text);
                        lnpaciente.Create(ref Paciente);
                        if (Paciente.MensajeError == null)
                        {
                            MessageBox.Show($"se a registrado el paciente exitosamente", "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(persona.MensajeError, "Error paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cmb_tipo.Text == "profesional")
                    {
                        Profesional = new ClsProfecional() { Documento_Pro1 = txb_documento.Text };
                        lnprofesional.Asignar_Horario(ref Profesional, cmb_tp.Text);
                        lnprofesional.Create(ref Profesional);
                        if (Profesional.MensajeError == null)
                        {
                            MessageBox.Show($"se a registrado el profesional exitosamente", "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(persona.MensajeError, "Error profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hubo un error al guardar los datos " + ex.Message,
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }

        // restriciones de digitacion
        private void txb_documento_KeyPress(object sender, KeyPressEventArgs e)
        { ClsControl.solo_numeros(e); }
        private void txb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsControl.solo_letras(e);
        }
        private void txb_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsControl.solo_numeros(e);
        }
    }
}
