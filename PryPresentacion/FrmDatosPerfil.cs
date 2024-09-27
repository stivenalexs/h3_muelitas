using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocio;
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
    public partial class FrmDatosPerfil : Form
    {
        //objetos persona
        ClsPersona persona = new ClsPersona();
        ClsPersonaLn personaLn = new ClsPersonaLn();
        public FrmDatosPerfil(ClsPersona p)
        {
            InitializeComponent();
            persona = p;
        }

        private void FrmDatosPerfil_Load(object sender, EventArgs e)
        {
            cmb_correo.Items.Add("@gmail.com");
            cmb_correo.Items.Add("@hotmail.com");
            cmb_correo.Items.Add("@outlook.com");

                if (!string.IsNullOrEmpty(persona.Foto))
                {
                    string dir = System.Environment.CurrentDirectory;
                    dir = dir.Substring(0, dir.LastIndexOf("bin")) + "Resources\\" + persona.Foto;
                    pb_foto.Image = Image.FromFile(dir);
                }
                lb_nombre.Text = persona.Nombre;
                lb_documento.Text = persona.Numero_documento.ToString();
                lb_Nacimiento.Text = persona.Fecha_N1.ToString();
                txb_correo.Text = persona.Correo_electronico;
                txb_contacto.Text = persona.Numero_contacto.ToString();
                txb_contra.Text = persona.Contraseña;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txb_contacto.Text) ||
                string.IsNullOrEmpty(cmb_correo.Text) ||
                string.IsNullOrEmpty(txb_correo.Text) ||
                string.IsNullOrEmpty(txb_contra.Text)
                )
            {
                MessageBox.Show("por favor digite todos los datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                persona.Nombre = lb_nombre.Text;
                persona.Correo_electronico = txb_correo.Text + cmb_correo.Text;
                persona.Numero_documento = lb_documento.Text;
                persona.Numero_contacto = txb_contacto.Text;
                persona.Contraseña = txb_contra.Text;
                personaLn.Update(ref persona);
                if (persona.MensajeError == null)
                {
                    MessageBox.Show($"se han actualizado los datos correctamente", "Confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(persona.MensajeError, "no parce muy malo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
